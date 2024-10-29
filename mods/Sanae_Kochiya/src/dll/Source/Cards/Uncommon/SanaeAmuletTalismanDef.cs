using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using Sanae_Kochiya.Cards.Template;

namespace Sanae_Kochiya.Source.Cards.Uncommon
{
	public sealed class SanaeAmuletTalismanDef : SampleCharacterCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.Colors = new List<ManaColor>
			{
				ManaColor.White,
				ManaColor.Green
			};
			cardDefaultConfig.Cost = new ManaGroup
			{
				Any = 3,
				White = 1,
				Green = 1
			};
			cardDefaultConfig.UpgradedCost = new ManaGroup?(new ManaGroup
			{
				Any = 4,
				Hybrid = 1,
				HybridColor = 3
			});
			cardDefaultConfig.Rarity = Rarity.Uncommon;
			cardDefaultConfig.Type = CardType.Skill;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.Self);
			cardDefaultConfig.Value1 = new int?(15);
			cardDefaultConfig.UpgradedValue1 = new int?(20);
			cardDefaultConfig.Value2 = new int?(4);
			cardDefaultConfig.Mana = new ManaGroup?(new ManaGroup
			{
				Any = 1
			});
			cardDefaultConfig.RelativeKeyword = Keyword.Power | Keyword.TempMorph;
			cardDefaultConfig.UpgradedRelativeKeyword = Keyword.Power | Keyword.TempMorph;
			cardDefaultConfig.RelativeEffects = new List<string> { "Amulet" };
			cardDefaultConfig.UpgradedRelativeEffects = new List<string> { "Amulet" };
			cardDefaultConfig.RelativeCards = new List<string> { "SanaeStatus" };
			cardDefaultConfig.UpgradedRelativeCards = new List<string> { "SanaeStatus" };
			cardDefaultConfig.Illustrator = "";
			cardDefaultConfig.Index = CardIndexGenerator.Initial_offset + 275301;
			return cardDefaultConfig;
		}
	}
}
