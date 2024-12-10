using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;

namespace Momiji.Source.Cards
{
	public sealed class WaterfallMeditationDef : SampleCharacterCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.Colors = new List<ManaColor> { ManaColor.White };
			cardDefaultConfig.Cost = new ManaGroup
			{
				White = 1
			};
			cardDefaultConfig.UpgradedCost = new ManaGroup?(new ManaGroup
			{
				White = 1
			});
			cardDefaultConfig.Rarity = Rarity.Uncommon;
			cardDefaultConfig.Type = CardType.Skill;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.SingleEnemy);
			cardDefaultConfig.Value1 = new int?(2);
			cardDefaultConfig.UpgradedValue1 = new int?(3);
			cardDefaultConfig.Value2 = new int?(1);
			cardDefaultConfig.UpgradedValue2 = new int?(2);
			cardDefaultConfig.Block = new int?(6);
			cardDefaultConfig.UpgradedBlock = new int?(9);
			cardDefaultConfig.RelativeEffects = new List<string> { "Vulnerable", "SpiritNegative", "Firepower", "OffensiveIntention", "DefensiveIntention", "SpecialIntention" };
			cardDefaultConfig.UpgradedRelativeEffects = new List<string> { "Vulnerable", "SpiritNegative", "Firepower", "OffensiveIntention", "DefensiveIntention", "SpecialIntention" };
			cardDefaultConfig.Illustrator = "esai";
			cardDefaultConfig.Index = CardIndexGenerator.GetUniqueIndex(cardDefaultConfig);
			return cardDefaultConfig;
		}
	}
}
