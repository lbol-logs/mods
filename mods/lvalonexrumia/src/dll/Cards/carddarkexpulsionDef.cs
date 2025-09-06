using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using lvalonexrumia.Cards.Template;

namespace lvalonexrumia.Cards
{
	public sealed class carddarkexpulsionDef : lvalonexrumiaCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.Colors = new List<ManaColor> { ManaColor.Black };
			cardDefaultConfig.Cost = new ManaGroup
			{
				Any = 1,
				Black = 1
			};
			cardDefaultConfig.Rarity = Rarity.Common;
			cardDefaultConfig.Type = CardType.Skill;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.Self);
			cardDefaultConfig.Value1 = new int?(1);
			cardDefaultConfig.Value2 = new int?(4);
			cardDefaultConfig.UpgradedValue2 = new int?(5);
			cardDefaultConfig.Keywords = Keyword.Retain | Keyword.Replenish;
			cardDefaultConfig.UpgradedKeywords = Keyword.Retain | Keyword.Replenish;
			cardDefaultConfig.RelativeEffects = new List<string> { "sedarkblood" };
			cardDefaultConfig.UpgradedRelativeEffects = new List<string> { "sedarkblood" };
			cardDefaultConfig.RelativeCards = new List<string> { "carddarkblood", "Shadow" };
			cardDefaultConfig.UpgradedRelativeCards = new List<string> { "carddarkblood", "Shadow" };
			cardDefaultConfig.Illustrator = "arutana";
			cardDefaultConfig.Index = CardIndexGenerator.GetUniqueIndex(cardDefaultConfig);
			return cardDefaultConfig;
		}
	}
}
