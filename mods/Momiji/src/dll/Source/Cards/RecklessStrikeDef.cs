using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;

namespace Momiji.Source.Cards
{
	public sealed class RecklessStrikeDef : SampleCharacterCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.Colors = new List<ManaColor>
			{
				ManaColor.White,
				ManaColor.Red
			};
			cardDefaultConfig.Cost = new ManaGroup
			{
				Any = 1,
				White = 1,
				Red = 1
			};
			cardDefaultConfig.UpgradedCost = new ManaGroup?(new ManaGroup
			{
				Any = 2,
				Hybrid = 1,
				HybridColor = 2
			});
			cardDefaultConfig.Rarity = Rarity.Uncommon;
			cardDefaultConfig.Type = CardType.Attack;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.SingleEnemy);
			cardDefaultConfig.Damage = new int?(24);
			cardDefaultConfig.UpgradedDamage = new int?(30);
			cardDefaultConfig.Value1 = new int?(3);
			cardDefaultConfig.Value2 = new int?(2);
			cardDefaultConfig.UpgradedValue2 = new int?(2);
			cardDefaultConfig.RelativeEffects = new List<string> { "Vulnerable", "Fragil" };
			cardDefaultConfig.UpgradedRelativeEffects = new List<string> { "Vulnerable", "Fragil" };
			cardDefaultConfig.Illustrator = "猫水瀬";
			cardDefaultConfig.Index = CardIndexGenerator.GetUniqueIndex(cardDefaultConfig);
			return cardDefaultConfig;
		}
	}
}
