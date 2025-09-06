using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using lvalonexrumia.Cards.Template;

namespace lvalonexrumia.Cards
{
	public sealed class cardnightfallsDef : lvalonexrumiaCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.Colors = new List<ManaColor> { ManaColor.Black };
			cardDefaultConfig.Cost = new ManaGroup
			{
				Any = 2,
				Black = 1
			};
			cardDefaultConfig.Rarity = Rarity.Rare;
			cardDefaultConfig.Type = CardType.Skill;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.Self);
			cardDefaultConfig.Value1 = new int?(1);
			cardDefaultConfig.Value2 = new int?(2);
			cardDefaultConfig.UpgradedValue2 = new int?(3);
			cardDefaultConfig.Mana = new ManaGroup?(new ManaGroup
			{
				Philosophy = 1
			});
			cardDefaultConfig.Keywords = Keyword.Retain;
			cardDefaultConfig.UpgradedKeywords = Keyword.Retain;
			cardDefaultConfig.RelativeEffects = new List<string> { "sebloodsword" };
			cardDefaultConfig.UpgradedRelativeEffects = new List<string> { "sebloodsword" };
			cardDefaultConfig.RelativeCards = new List<string> { "cardbloodsword" };
			cardDefaultConfig.UpgradedRelativeCards = new List<string> { "cardbloodsword" };
			cardDefaultConfig.Illustrator = "Spark621";
			cardDefaultConfig.Index = CardIndexGenerator.GetUniqueIndex(cardDefaultConfig);
			return cardDefaultConfig;
		}
	}
}
