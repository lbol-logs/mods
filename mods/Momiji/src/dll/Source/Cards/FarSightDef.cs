using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;

namespace Momiji.Source.Cards
{
	public sealed class FarSightDef : SampleCharacterCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.Colors = new List<ManaColor> { ManaColor.White };
			cardDefaultConfig.Cost = new ManaGroup
			{
				White = 2
			};
			cardDefaultConfig.UpgradedCost = new ManaGroup?(new ManaGroup
			{
				White = 1
			});
			cardDefaultConfig.Rarity = Rarity.Common;
			cardDefaultConfig.Type = CardType.Skill;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.AllEnemies);
			cardDefaultConfig.Block = new int?(12);
			cardDefaultConfig.UpgradedBlock = new int?(12);
			cardDefaultConfig.Value1 = new int?(12);
			cardDefaultConfig.UpgradedValue1 = new int?(12);
			cardDefaultConfig.RelativeEffects = new List<string> { "Reflect" };
			cardDefaultConfig.UpgradedRelativeEffects = new List<string> { "Reflect" };
			cardDefaultConfig.Illustrator = "hasebe yuusaku";
			cardDefaultConfig.Index = CardIndexGenerator.GetUniqueIndex(cardDefaultConfig);
			return cardDefaultConfig;
		}
	}
}
