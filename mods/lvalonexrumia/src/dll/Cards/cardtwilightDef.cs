using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using lvalonexrumia.Cards.Template;

namespace lvalonexrumia.Cards
{
	public sealed class cardtwilightDef : lvalonexrumiaCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.Colors = new List<ManaColor> { ManaColor.Colorless };
			cardDefaultConfig.Cost = new ManaGroup
			{
				Any = 3,
				Red = 1,
				Colorless = 1
			};
			cardDefaultConfig.UpgradedCost = new ManaGroup?(new ManaGroup
			{
				Any = 1,
				Red = 1,
				Colorless = 1
			});
			cardDefaultConfig.Rarity = Rarity.Rare;
			cardDefaultConfig.Type = CardType.Ability;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.Self);
			cardDefaultConfig.Value1 = new int?(1);
			cardDefaultConfig.Keywords = Keyword.Initial | Keyword.Retain;
			cardDefaultConfig.UpgradedKeywords = Keyword.Initial | Keyword.Retain;
			cardDefaultConfig.RelativeEffects = new List<string> { "Charging" };
			cardDefaultConfig.UpgradedRelativeEffects = new List<string> { "Charging" };
			cardDefaultConfig.RelativeCards = new List<string> { "cardredblood" };
			cardDefaultConfig.UpgradedRelativeCards = new List<string> { "cardredblood" };
			cardDefaultConfig.Illustrator = "Spark621";
			cardDefaultConfig.Index = CardIndexGenerator.GetUniqueIndex(cardDefaultConfig);
			return cardDefaultConfig;
		}
	}
}
