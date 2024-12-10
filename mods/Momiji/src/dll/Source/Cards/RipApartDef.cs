using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;

namespace Momiji.Source.Cards
{
	public sealed class RipApartDef : SampleCharacterCardTemplate
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
				Hybrid = 2,
				HybridColor = 2
			};
			cardDefaultConfig.UpgradedCost = new ManaGroup?(new ManaGroup
			{
				Any = 1,
				Hybrid = 1,
				HybridColor = 2
			});
			cardDefaultConfig.Rarity = Rarity.Uncommon;
			cardDefaultConfig.Type = CardType.Attack;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.AllEnemies);
			cardDefaultConfig.Damage = new int?(13);
			cardDefaultConfig.UpgradedDamage = new int?(9);
			cardDefaultConfig.Value1 = new int?(2);
			cardDefaultConfig.UpgradedValue1 = new int?(2);
			cardDefaultConfig.RelativeEffects = new List<string> { "Vulnerable" };
			cardDefaultConfig.UpgradedRelativeEffects = new List<string> { "Vulnerable" };
			cardDefaultConfig.Illustrator = "ゴ太郎\u3000(ゴミ豚クズ太郎）";
			cardDefaultConfig.Index = CardIndexGenerator.GetUniqueIndex(cardDefaultConfig);
			return cardDefaultConfig;
		}
	}
}
