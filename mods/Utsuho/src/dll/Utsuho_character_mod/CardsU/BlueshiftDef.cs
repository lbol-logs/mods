using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Cards;
using LBoL.Presentation.UI;
using LBoL.Presentation.UI.Panels;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Attributes;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;

namespace Utsuho_character_mod.CardsU
{
	public sealed class BlueshiftDef : CardTemplate
	{
		public override IdContainer GetId()
		{
			return "Blueshift";
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
			return new CardConfig(13600, "", 10, true, new string[0][], "Simple1", "Simple1", 0, false, true, true, false, true, Rarity.Uncommon, CardType.Defense, new TargetType?(TargetType.Nobody), new List<ManaColor> { ManaColor.Blue }, false, new ManaGroup
			{
				Any = 0
			}, new ManaGroup?(new ManaGroup
			{
				Any = 0
			}), null, null, null, new int?(12), new int?(12), null, null, null, null, null, null, new ManaGroup?(new ManaGroup
			{
				Any = 2
			}), new ManaGroup?(new ManaGroup
			{
				Any = 2
			}), null, null, null, null, null, null, null, null, null, null, null, Keyword.Exile | Keyword.Ethereal, Keyword.Exile, false, Keyword.None, Keyword.None, new List<string>(), new List<string>(), new List<string>(), new List<string>(), "Utsuho", "", "", false, "Flippin'Loser", new List<string>());
		}

		[EntityLogic(typeof(BlueshiftDef))]
		public sealed class Blueshift : Card
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
					bool flag2 = manaGroup.CanAfford(base.Mana);
					if (flag2)
					{
						this.temp = manaGroup;
						this.KickCount = panel.PooledMana.Amount / 2;
					}
				}
				return null;
			}

			private IEnumerable<BattleAction> OnManaConsumed(ManaEventArgs args)
			{
				bool flag = this.KickCount > 0;
				if (flag)
				{
					bool flag2 = !this.IsUpgraded;
					if (flag2)
					{
						yield return new AddCardsToHandAction(Library.CreateCards<BlueshiftDef.Blueshift>(this.KickCount, false), AddCardsType.Normal);
					}
					else
					{
						yield return new AddCardsToHandAction(Library.CreateCards<BlueshiftDef.Blueshift>(this.KickCount, true), AddCardsType.Normal);
					}
					this.KickCount = 0;
					BattleManaPanel panel = UiManager.GetPanel<BattleManaPanel>();
					ManaGroup pool = panel.PooledMana;
					yield return new ConsumeManaAction(pool);
					panel = null;
					pool = default(ManaGroup);
				}
				yield break;
			}

			protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
			{
				yield return base.DefenseAction(true);
				yield break;
			}

			private ManaGroup temp;

			private int KickCount = 0;
		}
	}
}
