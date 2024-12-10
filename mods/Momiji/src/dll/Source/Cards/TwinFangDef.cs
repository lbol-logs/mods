using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;

namespace Momiji.Source.Cards
{
	public sealed class TwinFangDef : SampleCharacterCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.Colors = new List<ManaColor> { ManaColor.White };
			cardDefaultConfig.Cost = new ManaGroup
			{
				Any = 1,
				White = 1
			};
			cardDefaultConfig.UpgradedCost = new ManaGroup?(new ManaGroup
			{
				White = 1
			});
			cardDefaultConfig.Rarity = Rarity.Common;
			cardDefaultConfig.Type = CardType.Skill;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.Self);
			cardDefaultConfig.Value1 = new int?(1);
			cardDefaultConfig.UpgradedValue1 = new int?(1);
			cardDefaultConfig.Value2 = new int?(4);
			cardDefaultConfig.UpgradedValue2 = new int?(7);
			cardDefaultConfig.RelativeEffects = new List<string> { "Reflect" };
			cardDefaultConfig.UpgradedRelativeEffects = new List<string> { "Reflect" };
			cardDefaultConfig.Illustrator = "崩壊";
			cardDefaultConfig.Index = CardIndexGenerator.GetUniqueIndex(cardDefaultConfig);
			return cardDefaultConfig;
		}
	}
}
