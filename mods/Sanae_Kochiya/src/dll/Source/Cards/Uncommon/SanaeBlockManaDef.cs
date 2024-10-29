using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using Sanae_Kochiya.Cards.Template;

namespace Sanae_Kochiya.Source.Cards.Uncommon
{
	public sealed class SanaeBlockManaDef : SampleCharacterCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.Colors = new List<ManaColor>
			{
				ManaColor.Blue,
				ManaColor.Green
			};
			cardDefaultConfig.Cost = new ManaGroup
			{
				Any = 2,
				Hybrid = 1,
				HybridColor = 6
			};
			cardDefaultConfig.Rarity = Rarity.Uncommon;
			cardDefaultConfig.Type = CardType.Defense;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.Self);
			cardDefaultConfig.Block = new int?(16);
			cardDefaultConfig.UpgradedBlock = new int?(20);
			cardDefaultConfig.Value1 = new int?(1);
			cardDefaultConfig.UpgradedValue1 = new int?(0);
			cardDefaultConfig.Value2 = new int?(1);
			cardDefaultConfig.RelativeKeyword = Keyword.Block | Keyword.Overdraft;
			cardDefaultConfig.UpgradedRelativeKeyword = Keyword.Block;
			cardDefaultConfig.RelativeEffects = new List<string> { "TurnStartDontLoseMana" };
			cardDefaultConfig.UpgradedRelativeEffects = new List<string> { "TurnStartDontLoseMana" };
			cardDefaultConfig.Illustrator = "";
			cardDefaultConfig.Index = CardIndexGenerator.Initial_offset + 283201;
			return cardDefaultConfig;
		}
	}
}
