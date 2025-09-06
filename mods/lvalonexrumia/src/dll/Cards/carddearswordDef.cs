using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using lvalonexrumia.Cards.Template;

namespace lvalonexrumia.Cards
{
	public sealed class carddearswordDef : lvalonexrumiaCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.Colors = new List<ManaColor> { ManaColor.Red };
			cardDefaultConfig.Cost = new ManaGroup
			{
				Any = 1,
				Red = 1
			};
			cardDefaultConfig.Rarity = Rarity.Uncommon;
			cardDefaultConfig.Type = CardType.Friend;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.Nobody);
			cardDefaultConfig.Value1 = new int?(1);
			cardDefaultConfig.Value2 = new int?(2);
			cardDefaultConfig.PassiveCost = new int?(1);
			cardDefaultConfig.ActiveCost = new int?(-4);
			cardDefaultConfig.UpgradedActiveCost = new int?(-3);
			cardDefaultConfig.UltimateCost = new int?(-6);
			cardDefaultConfig.UpgradedUltimateCost = new int?(-5);
			cardDefaultConfig.Loyalty = new int?(3);
			cardDefaultConfig.RelativeEffects = new List<string> { "sedecrease", "sebloodstorm", "sebloodmark", "sebleed" };
			cardDefaultConfig.UpgradedRelativeEffects = new List<string> { "sedecrease", "sebloodstorm", "sebloodmark", "sebleed" };
			cardDefaultConfig.RelativeCards = new List<string> { "cardredblood", "cardbloodstorm" };
			cardDefaultConfig.UpgradedRelativeCards = new List<string> { "cardredblood", "cardbloodstorm" };
			cardDefaultConfig.Illustrator = "sarise";
			cardDefaultConfig.Index = CardIndexGenerator.GetUniqueIndex(cardDefaultConfig);
			return cardDefaultConfig;
		}
	}
}
