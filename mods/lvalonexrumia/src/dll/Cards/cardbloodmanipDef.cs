using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using lvalonexrumia.Cards.Template;

namespace lvalonexrumia.Cards
{
	public sealed class cardbloodmanipDef : lvalonexrumiaCardTemplate
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
			cardDefaultConfig.Type = CardType.Defense;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.All);
			cardDefaultConfig.Value1 = new int?(8);
			cardDefaultConfig.UpgradedValue1 = new int?(10);
			cardDefaultConfig.Value2 = new int?(1);
			cardDefaultConfig.UpgradedValue2 = new int?(2);
			cardDefaultConfig.Block = new int?(0);
			cardDefaultConfig.Keywords = Keyword.Exile;
			cardDefaultConfig.UpgradedKeywords = Keyword.Exile;
			cardDefaultConfig.RelativeEffects = new List<string> { "sedecrease", "sebloodclot", "sebloodmark", "sebleed" };
			cardDefaultConfig.UpgradedRelativeEffects = new List<string> { "sedecrease", "sebloodclot", "sebloodmark", "sebleed" };
			cardDefaultConfig.Illustrator = "Anderson_M3011";
			cardDefaultConfig.Index = CardIndexGenerator.GetUniqueIndex(cardDefaultConfig);
			return cardDefaultConfig;
		}
	}
}
