using System;
using System.Collections.Generic;
using System.Linq;
using LBoL.Base;
using LBoL.ConfigData;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Cards;
using LBoL.Core.Randoms;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Attributes;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;
using Utsuho_character_mod.Status;

namespace Utsuho_character_mod.CardsR
{
	public sealed class FissionDefinition : CardTemplate
	{
		public override IdContainer GetId()
		{
			return "Fission";
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
			return new CardConfig(13310, "", 10, true, new string[0][], "Simple1", "Simple1", 0, false, true, true, false, true, Rarity.Uncommon, CardType.Skill, new TargetType?(TargetType.Nobody), new List<ManaColor> { ManaColor.Red }, false, new ManaGroup
			{
				Red = 2
			}, new ManaGroup?(new ManaGroup
			{
				Red = 2
			}), null, null, null, null, null, null, null, new int?(8), new int?(8), null, null, new ManaGroup?(new ManaGroup
			{
				Red = 2
			}), new ManaGroup?(new ManaGroup
			{
				Philosophy = 2
			}), null, null, null, null, null, null, null, null, null, null, null, Keyword.Exile, Keyword.Exile, false, Keyword.None, Keyword.None, new List<string> { "HeatStatus" }, new List<string> { "HeatStatus" }, new List<string>(), new List<string>(), "Utsuho", "", "", false, "Zosit", new List<string>());
		}

		[EntityLogic(typeof(FissionDefinition))]
		public sealed class Fission : Card
		{
			protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
			{
				Card Attack = base.Battle.RollCard(new CardWeightTable(RarityWeightTable.BattleCard, OwnerWeightTable.Valid, CardTypeWeightTable.OnlyAttack, false), delegate(CardConfig config)
				{
					bool flag2 = config.Colors.Count > 0;
					bool flag3;
					if (flag2)
					{
						flag3 = config.Colors.All((ManaColor color) => color == ManaColor.Red);
					}
					else
					{
						flag3 = false;
					}
					return flag3;
				});
				Card Defense = base.Battle.RollCard(new CardWeightTable(RarityWeightTable.BattleCard, OwnerWeightTable.Valid, CardTypeWeightTable.OnlyDefense, false), delegate(CardConfig config)
				{
					bool flag4 = config.Colors.Count > 0;
					bool flag5;
					if (flag4)
					{
						flag5 = config.Colors.All((ManaColor color) => color == ManaColor.Red);
					}
					else
					{
						flag5 = false;
					}
					return flag5;
				});
				bool isUpgraded = this.IsUpgraded;
				if (isUpgraded)
				{
					Attack.Upgrade();
					Defense.Upgrade();
				}
				bool flag = Attack != null && Defense != null;
				if (flag)
				{
					Attack.SetBaseCost(ManaGroup.Anys(Attack.ConfigCost.Amount));
					Defense.SetBaseCost(ManaGroup.Anys(Defense.ConfigCost.Amount));
					yield return new AddCardsToHandAction(new Card[] { Attack });
					yield return new AddCardsToHandAction(new Card[] { Defense });
				}
				yield return new ApplyStatusEffectAction<HeatStatus>(base.Battle.Player, new int?(base.Value1), null, null, null, 0f, true);
				yield return new GainManaAction(base.Mana);
				yield break;
			}
		}
	}
}
