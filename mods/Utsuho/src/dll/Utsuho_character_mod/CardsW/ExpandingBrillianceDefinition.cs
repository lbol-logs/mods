using System;
using System.Collections.Generic;
using System.Linq;
using LBoL.Base;
using LBoL.ConfigData;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Battle.Interactions;
using LBoL.Core.Cards;
using LBoL.Core.StatusEffects;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Attributes;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;

namespace Utsuho_character_mod.CardsW
{
	public sealed class ExpandingBrillianceDefinition : CardTemplate
	{
		public override IdContainer GetId()
		{
			return "ExpandingBrilliance";
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
			return new CardConfig(13560, "", 10, true, new string[0][], "Simple1", "Simple1", 0, false, true, true, false, true, Rarity.Uncommon, CardType.Skill, new TargetType?(TargetType.AllEnemies), new List<ManaColor> { ManaColor.White }, false, new ManaGroup
			{
				White = 1
			}, new ManaGroup?(new ManaGroup
			{
				Any = 1
			}), null, null, null, null, null, null, null, new int?(3), new int?(5), new int?(1), new int?(1), null, null, null, null, null, null, null, null, null, null, null, null, null, Keyword.None, Keyword.None, false, Keyword.None, Keyword.None, new List<string>(), new List<string>(), new List<string>(), new List<string>(), "Utsuho", "", "", false, "", new List<string>());
		}

		[EntityLogic(typeof(ExpandingBrillianceDefinition))]
		public sealed class ExpandingBrilliance : Card
		{
			public override Interaction Precondition()
			{
				List<Card> list = base.Battle.HandZone.Where((Card hand) => hand != this && hand.CanUpgradeAndPositive).ToList<Card>();
				bool flag = list.Count == 1;
				if (flag)
				{
					this.oneTargetHand = list[0];
				}
				bool flag2 = list.Count <= 1;
				Interaction interaction;
				if (flag2)
				{
					interaction = null;
				}
				else
				{
					interaction = new SelectHandInteraction(1, 1, list);
				}
				return interaction;
			}

			protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
			{
				yield return new DrawCardAction();
				foreach (BattleAction battleAction in base.DebuffAction<TempFirepowerNegative>(selector.GetUnits(base.Battle), base.Value1, 0, 0, 0, true, 0.2f))
				{
					yield return battleAction;
					battleAction = null;
				}
				IEnumerator<BattleAction> enumerator = null;
				bool flag = precondition != null;
				if (flag)
				{
					Card card = ((SelectHandInteraction)precondition).SelectedCards[0];
					bool flag2 = card != null;
					if (flag2)
					{
						yield return new UpgradeCardAction(card);
					}
					card = null;
				}
				else
				{
					bool flag3 = this.oneTargetHand != null;
					if (flag3)
					{
						yield return new UpgradeCardAction(this.oneTargetHand);
						this.oneTargetHand = null;
					}
				}
				yield break;
				yield break;
			}

			private Card oneTargetHand;
		}
	}
}
