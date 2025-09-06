using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using lvalonexrumia.Cards.Template;

namespace lvalonexrumia.Cards
{
	public sealed class cardshadyDef : lvalonexrumiaCardTemplate
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
			cardDefaultConfig.Rarity = Rarity.Common;
			cardDefaultConfig.Type = CardType.Skill;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.Self);
			cardDefaultConfig.Value1 = new int?(1);
			cardDefaultConfig.Value2 = new int?(2);
			cardDefaultConfig.UpgradedKeywords = Keyword.Replenish;
			cardDefaultConfig.RelativeEffects = new List<string> { "Graze", "sedarkblood" };
			cardDefaultConfig.UpgradedRelativeEffects = new List<string> { "Graze", "sedarkblood" };
			cardDefaultConfig.RelativeCards = new List<string> { "carddarkblood" };
			cardDefaultConfig.UpgradedRelativeCards = new List<string> { "carddarkblood" };
			cardDefaultConfig.Illustrator = "くーげる";
			cardDefaultConfig.Index = CardIndexGenerator.GetUniqueIndex(cardDefaultConfig);
			return cardDefaultConfig;
		}
	}
}
