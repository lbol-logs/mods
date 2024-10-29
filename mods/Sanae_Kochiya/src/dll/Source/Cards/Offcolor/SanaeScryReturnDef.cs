using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using Sanae_Kochiya.Cards.Template;

namespace Sanae_Kochiya.Source.Cards.Offcolor
{
	public sealed class SanaeScryReturnDef : SampleCharacterCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.Colors = new List<ManaColor>
			{
				ManaColor.White,
				ManaColor.Black
			};
			cardDefaultConfig.Cost = new ManaGroup
			{
				White = 1,
				Black = 1
			};
			cardDefaultConfig.UpgradedCost = new ManaGroup?(new ManaGroup
			{
				Hybrid = 1,
				HybridColor = 1
			});
			cardDefaultConfig.Rarity = Rarity.Uncommon;
			cardDefaultConfig.Type = CardType.Skill;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.Self);
			cardDefaultConfig.Value1 = new int?(1);
			cardDefaultConfig.Scry = new int?(4);
			cardDefaultConfig.UpgradedScry = new int?(5);
			cardDefaultConfig.RelativeKeyword = Keyword.Scry;
			cardDefaultConfig.UpgradedRelativeKeyword = Keyword.Scry;
			cardDefaultConfig.Illustrator = "";
			cardDefaultConfig.Index = CardIndexGenerator.Initial_offset + 422301;
			return cardDefaultConfig;
		}
	}
}
