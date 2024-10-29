using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using Sanae_Kochiya.Cards.Template;

namespace Sanae_Kochiya.Source.Cards.Rare
{
	public sealed class SanaeToolNewsDef : SampleCharacterCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.Colors = new List<ManaColor> { ManaColor.Green };
			cardDefaultConfig.Cost = new ManaGroup
			{
				Any = 2,
				Green = 1
			};
			cardDefaultConfig.Rarity = Rarity.Rare;
			cardDefaultConfig.Type = CardType.Skill;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.Self);
			cardDefaultConfig.Value1 = new int?(2);
			cardDefaultConfig.UpgradedValue1 = new int?(3);
			cardDefaultConfig.Value2 = new int?(3);
			cardDefaultConfig.UpgradedValue2 = new int?(4);
			cardDefaultConfig.Keywords = Keyword.Exile;
			cardDefaultConfig.UpgradedKeywords = Keyword.Exile;
			cardDefaultConfig.RelativeKeyword = Keyword.Tool | Keyword.Copy | Keyword.AutoExile;
			cardDefaultConfig.UpgradedRelativeKeyword = Keyword.Tool | Keyword.Copy | Keyword.AutoExile;
			cardDefaultConfig.RelativeCards = new List<string> { "NewsPositive", "ToolAmulet" };
			cardDefaultConfig.UpgradedRelativeCards = new List<string> { "NewsPositive", "ToolAmulet" };
			cardDefaultConfig.Illustrator = "";
			cardDefaultConfig.Index = CardIndexGenerator.Initial_offset + 353301;
			return cardDefaultConfig;
		}
	}
}
