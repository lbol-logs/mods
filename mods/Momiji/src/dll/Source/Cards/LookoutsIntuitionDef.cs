using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;

namespace Momiji.Source.Cards
{
	public sealed class LookoutsIntuitionDef : SampleCharacterCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.Colors = new List<ManaColor> { ManaColor.Red };
			cardDefaultConfig.Cost = new ManaGroup
			{
				Any = 2,
				Red = 1
			};
			cardDefaultConfig.UpgradedCost = new ManaGroup?(new ManaGroup
			{
				Any = 1,
				Red = 1
			});
			cardDefaultConfig.Rarity = Rarity.Common;
			cardDefaultConfig.Type = CardType.Skill;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.SingleEnemy);
			cardDefaultConfig.Value1 = new int?(2);
			cardDefaultConfig.Value2 = new int?(3);
			cardDefaultConfig.UpgradedValue2 = new int?(2);
			cardDefaultConfig.Shield = new int?(3);
			cardDefaultConfig.UpgradedShield = new int?(3);
			cardDefaultConfig.RelativeEffects = new List<string> { "Vulnerable", "Graze" };
			cardDefaultConfig.UpgradedRelativeEffects = new List<string> { "Vulnerable", "Graze" };
			cardDefaultConfig.Illustrator = "Shirokaba114";
			cardDefaultConfig.Index = CardIndexGenerator.GetUniqueIndex(cardDefaultConfig);
			return cardDefaultConfig;
		}
	}
}
