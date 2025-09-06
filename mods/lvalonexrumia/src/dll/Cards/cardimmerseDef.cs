using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using lvalonexrumia.Cards.Template;

namespace lvalonexrumia.Cards
{
	public sealed class cardimmerseDef : lvalonexrumiaCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.Colors = new List<ManaColor> { ManaColor.Red };
			cardDefaultConfig.Cost = new ManaGroup
			{
				Any = 2,
				Red = 1
			};
			cardDefaultConfig.UpgradedCost = new ManaGroup?(new ManaGroup
			{
				Any = 1,
				Red = 1
			});
			cardDefaultConfig.Rarity = Rarity.Common;
			cardDefaultConfig.Type = CardType.Skill;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.Self);
			cardDefaultConfig.Value1 = new int?(5);
			cardDefaultConfig.Value2 = new int?(2);
			cardDefaultConfig.RelativeEffects = new List<string> { "sedecrease", "sebloodstorm" };
			cardDefaultConfig.UpgradedRelativeEffects = new List<string> { "sedecrease", "sebloodstorm" };
			cardDefaultConfig.RelativeCards = new List<string> { "cardbloodstorm", "cardredblood" };
			cardDefaultConfig.UpgradedRelativeCards = new List<string> { "cardbloodstorm", "cardredblood" };
			cardDefaultConfig.Illustrator = "かっさんどら";
			cardDefaultConfig.Index = CardIndexGenerator.GetUniqueIndex(cardDefaultConfig);
			return cardDefaultConfig;
		}
	}
}
