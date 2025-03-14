﻿using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;

namespace Momiji.Source.Cards
{
	public sealed class PatientHunterDef : SampleCharacterCardTemplate
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
			cardDefaultConfig.Rarity = Rarity.Common;
			cardDefaultConfig.Type = CardType.Defense;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.Self);
			cardDefaultConfig.Block = new int?(13);
			cardDefaultConfig.UpgradedBlock = new int?(17);
			cardDefaultConfig.Illustrator = "降旗原";
			cardDefaultConfig.Index = CardIndexGenerator.GetUniqueIndex(cardDefaultConfig);
			return cardDefaultConfig;
		}
	}
}
