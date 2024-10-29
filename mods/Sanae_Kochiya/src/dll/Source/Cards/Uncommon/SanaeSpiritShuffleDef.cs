using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using Sanae_Kochiya.Cards.Template;

namespace Sanae_Kochiya.Source.Cards.Uncommon
{
	public sealed class SanaeSpiritShuffleDef : SampleCharacterCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.Colors = new List<ManaColor>
			{
				ManaColor.White,
				ManaColor.Blue
			};
			cardDefaultConfig.Cost = new ManaGroup
			{
				Hybrid = 1,
				HybridColor = 0
			};
			cardDefaultConfig.Rarity = Rarity.Uncommon;
			cardDefaultConfig.Type = CardType.Skill;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.Self);
			cardDefaultConfig.Value1 = new int?(2);
			cardDefaultConfig.Value2 = new int?(2);
			cardDefaultConfig.Keywords = Keyword.Exile;
			cardDefaultConfig.UpgradedKeywords = Keyword.Exile | Keyword.Echo;
			cardDefaultConfig.RelativeEffects = new List<string> { "TempSpirit" };
			cardDefaultConfig.UpgradedRelativeEffects = new List<string> { "TempSpirit" };
			cardDefaultConfig.Illustrator = "";
			cardDefaultConfig.Index = CardIndexGenerator.Initial_offset + 291301;
			return cardDefaultConfig;
		}
	}
}
