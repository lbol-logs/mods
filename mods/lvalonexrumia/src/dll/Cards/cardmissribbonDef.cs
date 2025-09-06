using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using lvalonexrumia.Cards.Template;

namespace lvalonexrumia.Cards
{
	public sealed class cardmissribbonDef : lvalonexrumiaCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.Colors = new List<ManaColor> { ManaColor.Black };
			cardDefaultConfig.Cost = new ManaGroup
			{
				Any = 1,
				Black = 2
			};
			cardDefaultConfig.Rarity = Rarity.Uncommon;
			cardDefaultConfig.Type = CardType.Friend;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.Nobody);
			cardDefaultConfig.Value1 = new int?(5);
			cardDefaultConfig.Value2 = new int?(1);
			cardDefaultConfig.UpgradedValue2 = new int?(2);
			cardDefaultConfig.PassiveCost = new int?(1);
			cardDefaultConfig.ActiveCost = new int?(-3);
			cardDefaultConfig.UltimateCost = new int?(-5);
			cardDefaultConfig.Loyalty = new int?(3);
			cardDefaultConfig.UpgradedLoyalty = new int?(5);
			cardDefaultConfig.Mana = new ManaGroup?(new ManaGroup
			{
				Black = 1
			});
			cardDefaultConfig.UpgradedMana = new ManaGroup?(new ManaGroup
			{
				Philosophy = 1
			});
			cardDefaultConfig.RelativeEffects = new List<string> { "sedecrease", "sebloodmark", "sebloodsword" };
			cardDefaultConfig.UpgradedRelativeEffects = new List<string> { "sedecrease", "sebloodmark", "sebloodsword" };
			cardDefaultConfig.RelativeCards = new List<string> { "cardbloodsword" };
			cardDefaultConfig.UpgradedRelativeCards = new List<string> { "cardbloodsword" };
			cardDefaultConfig.Illustrator = "わんどろいど";
			cardDefaultConfig.Index = CardIndexGenerator.GetUniqueIndex(cardDefaultConfig);
			return cardDefaultConfig;
		}
	}
}
