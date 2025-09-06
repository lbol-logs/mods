using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using lvalonexrumia.Cards.Template;

namespace lvalonexrumia.Cards
{
	public sealed class cardmagiaDef : lvalonexrumiaCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.Colors = new List<ManaColor> { ManaColor.Black };
			cardDefaultConfig.Cost = new ManaGroup
			{
				Black = 2
			};
			cardDefaultConfig.Rarity = Rarity.Uncommon;
			cardDefaultConfig.Type = CardType.Defense;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.Self);
			cardDefaultConfig.Block = new int?(10);
			cardDefaultConfig.Value1 = new int?(1);
			cardDefaultConfig.Value2 = new int?(2);
			cardDefaultConfig.UpgradedValue2 = new int?(3);
			cardDefaultConfig.Keywords = Keyword.Retain;
			cardDefaultConfig.UpgradedKeywords = Keyword.Retain;
			cardDefaultConfig.RelativeEffects = new List<string> { "seaccel", "sebloodsword" };
			cardDefaultConfig.UpgradedRelativeEffects = new List<string> { "seaccel", "sebloodsword" };
			cardDefaultConfig.RelativeCards = new List<string> { "cardbloodsword" };
			cardDefaultConfig.UpgradedRelativeCards = new List<string> { "cardbloodsword" };
			cardDefaultConfig.Illustrator = "shinh";
			cardDefaultConfig.Index = CardIndexGenerator.GetUniqueIndex(cardDefaultConfig);
			return cardDefaultConfig;
		}
	}
}
