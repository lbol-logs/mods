﻿using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using Sanae_Kochiya.Cards.Template;

namespace Sanae_Kochiya.Source.Cards.Rare
{
	public sealed class SanaeHisouRightArmDef : SampleCharacterCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.IsPooled = false;
			cardDefaultConfig.FindInBattle = false;
			cardDefaultConfig.HideMesuem = true;
			cardDefaultConfig.Colors = new List<ManaColor>
			{
				ManaColor.Blue,
				ManaColor.Green
			};
			cardDefaultConfig.Cost = new ManaGroup
			{
				Any = 3
			};
			cardDefaultConfig.Rarity = Rarity.Rare;
			cardDefaultConfig.Type = CardType.Skill;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.Self);
			cardDefaultConfig.Value1 = new int?(10);
			cardDefaultConfig.UpgradedValue1 = new int?(5);
			cardDefaultConfig.Keywords = Keyword.Forbidden | Keyword.Retain;
			cardDefaultConfig.UpgradedKeywords = Keyword.Forbidden | Keyword.Retain;
			cardDefaultConfig.Illustrator = "";
			cardDefaultConfig.Index = CardIndexGenerator.GetUniqueIndex(cardDefaultConfig);
			return cardDefaultConfig;
		}
	}
}