using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using lvalonexrumia.Cards.Template;

namespace lvalonexrumia.Cards
{
	public sealed class cardcorruptedbloodDef : lvalonexrumiaCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.Colors = new List<ManaColor> { ManaColor.Black };
			cardDefaultConfig.Cost = new ManaGroup
			{
				Any = 2,
				Black = 2
			};
			cardDefaultConfig.Rarity = Rarity.Uncommon;
			cardDefaultConfig.Type = CardType.Ability;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.Self);
			cardDefaultConfig.Value1 = new int?(1);
			cardDefaultConfig.Value2 = new int?(2);
			cardDefaultConfig.Keywords = Keyword.Replenish;
			cardDefaultConfig.UpgradedKeywords = Keyword.Replenish;
			cardDefaultConfig.RelativeEffects = new List<string> { "sedarkblood" };
			cardDefaultConfig.UpgradedRelativeEffects = new List<string> { "sedarkblood" };
			cardDefaultConfig.RelativeCards = new List<string> { "carddarkblood" };
			cardDefaultConfig.UpgradedRelativeCards = new List<string> { "carddarkblood" };
			cardDefaultConfig.Illustrator = "画框子";
			cardDefaultConfig.Index = CardIndexGenerator.GetUniqueIndex(cardDefaultConfig);
			return cardDefaultConfig;
		}
	}
}
