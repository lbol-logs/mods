using System;
using System.Collections.Generic;
using System.Linq;
using LBoL.Base;
using LBoL.ConfigData;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Cards;
using LBoL.Core.StatusEffects;
using LBoL.Presentation.UI;
using LBoL.Presentation.UI.Panels;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Attributes;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;

namespace Utsuho_character_mod.CardsMulti
{
	public sealed class CoolantDef : CardTemplate
	{
		public override IdContainer GetId()
		{
			return "Coolant";
		}

		public override CardImages LoadCardImages()
		{
			CardImages cardImages = new CardImages(BepinexPlugin.embeddedSource);
			cardImages.AutoLoad(this, ".png", "", false);
			return cardImages;
		}

		public override LocalizationOption LoadLocalization()
		{
			GlobalLocalization globalLocalization = new GlobalLocalization(BepinexPlugin.directorySource);
			globalLocalization.DiscoverAndLoadLocFiles(this);
			return globalLocalization;
		}

		public override CardConfig MakeConfig()
		{
			return new CardConfig(13610, "", 10, true, new string[0][], "Simple1", "Simple1", 0, false, true, true, false, true, Rarity.Uncommon, CardType.Ability, new TargetType?(TargetType.Nobody), new List<ManaColor>
			{
				ManaColor.Blue,
				ManaColor.Red
			}, false, new ManaGroup
			{
				Blue = 1,
				Any = 2
			}, new ManaGroup?(new ManaGroup
			{
				Blue = 1,
				Any = 2
			}), null, null, null, null, null, null, null, new int?(4), new int?(6), new int?(4), new int?(6), new ManaGroup?(new ManaGroup
			{
				Red = 1,
				Any = 1
			}), null, null, null, null, null, null, null, null, null, null, null, null, Keyword.None, Keyword.None, false, Keyword.None, Keyword.None, new List<string> { "Spirit", "Firepower" }, new List<string> { "Spirit", "Firepower" }, new List<string>(), new List<string>(), "Utsuho", "", "", false, "", new List<string>());
		}

		[EntityLogic(typeof(CoolantDef))]
		public sealed class Coolant : Card
		{
			protected override void OnEnterBattle(BattleController battle)
			{
				base.ReactBattleEvent<ManaEventArgs>(base.Battle.ManaConsuming, new EventSequencedReactor<ManaEventArgs>(this.OnManaConsuming));
				base.ReactBattleEvent<ManaEventArgs>(base.Battle.ManaConsumed, new EventSequencedReactor<ManaEventArgs>(this.OnManaConsumed));
			}

			private IEnumerable<BattleAction> OnManaConsuming(ManaEventArgs args)
			{
				BattleManaPanel panel = UiManager.GetPanel<BattleManaPanel>();
				ManaGroup manaGroup = panel.PooledMana + args.Value;
				bool flag = args.ActionSource == this && args.Cause == ActionCause.CardUse;
				if (flag)
				{
					bool flag2 = manaGroup.CanAfford(base.Mana + base.TurnCost);
					if (flag2)
					{
						this.temp = manaGroup;
						this.isKicked = true;
					}
					else
					{
						this.isKicked = false;
					}
				}
				return null;
			}

			private IEnumerable<BattleAction> OnManaConsumed(ManaEventArgs args)
			{
				bool flag = this.isKicked;
				if (flag)
				{
					this.isKicked = false;
					BattleManaPanel panel = UiManager.GetPanel<BattleManaPanel>();
					ManaGroup pool = panel.PooledMana;
					yield return new ConsumeManaAction(pool);
					yield return base.BuffAction<Firepower>(base.Value2, 0, 0, 0, 0.2f);
					panel = null;
					pool = default(ManaGroup);
				}
				yield break;
			}

			protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
			{
				yield return base.BuffAction<Spirit>(base.Value1, 0, 0, 0, 0.2f);
				List<Card> list = base.Battle.HandZone.Where((Card card) => card.CardType != CardType.Defense).ToList<Card>();
				yield return new DiscardManyAction(list);
				yield break;
			}

			private ManaGroup temp;

			private bool isKicked = false;
		}
	}
}
