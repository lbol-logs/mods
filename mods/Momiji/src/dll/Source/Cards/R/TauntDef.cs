using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;

namespace Momiji.Source.Cards.R
{
	public sealed class TauntDef : SampleCharacterCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.Colors = new List<ManaColor> { ManaColor.Red };
			cardDefaultConfig.Cost = new ManaGroup
			{
				Red = 1
			};
			cardDefaultConfig.UpgradedCost = new ManaGroup?(new ManaGroup
			{
				Any = 1
			});
			cardDefaultConfig.Rarity = Rarity.Common;
			cardDefaultConfig.Type = CardType.Skill;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.SingleEnemy);
			cardDefaultConfig.Value1 = new int?(2);
			cardDefaultConfig.UpgradedValue1 = new int?(2);
			cardDefaultConfig.Value2 = new int?(4);
			cardDefaultConfig.UpgradedValue2 = new int?(2);
			cardDefaultConfig.Illustrator = "さるかな";
			cardDefaultConfig.RelativeEffects = new List<string> { "Weak", "Vulnerable" };
			cardDefaultConfig.UpgradedRelativeEffects = new List<string> { "Weak", "Vulnerable" };
			cardDefaultConfig.Index = CardIndexGenerator.GetUniqueIndex(cardDefaultConfig);
			return cardDefaultConfig;
		}
	}
}
