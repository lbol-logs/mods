using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using lvalonexrumia.Cards.Template;

namespace lvalonexrumia.Cards
{
	public sealed class cardallureDef : lvalonexrumiaCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.Colors = new List<ManaColor>
			{
				ManaColor.Black,
				ManaColor.Red
			};
			cardDefaultConfig.Cost = new ManaGroup
			{
				Hybrid = 1,
				HybridColor = 7
			};
			cardDefaultConfig.UpgradedCost = new ManaGroup?(new ManaGroup
			{
				Any = 1
			});
			cardDefaultConfig.Rarity = Rarity.Uncommon;
			cardDefaultConfig.Type = CardType.Skill;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.All);
			cardDefaultConfig.Scry = new int?(3);
			cardDefaultConfig.Value1 = new int?(5);
			cardDefaultConfig.Value2 = new int?(1);
			cardDefaultConfig.Keywords = Keyword.Scry;
			cardDefaultConfig.UpgradedKeywords = Keyword.Retain | Keyword.Scry;
			cardDefaultConfig.RelativeEffects = new List<string> { "sedecrease", "sebleed" };
			cardDefaultConfig.UpgradedRelativeEffects = new List<string> { "sedecrease", "sebleed" };
			cardDefaultConfig.Illustrator = "ファルケン@skebお仕募集中";
			cardDefaultConfig.Index = CardIndexGenerator.GetUniqueIndex(cardDefaultConfig);
			return cardDefaultConfig;
		}
	}
}
