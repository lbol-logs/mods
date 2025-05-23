﻿using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using PatchouliCharacterMod.Cards.Template;
using PatchouliCharacterMod.Illustrator;

namespace PatchouliCharacterMod.Cards
{
	public sealed class PatchouliAwakenedSpellbookDef : PatchouliCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.Index = 5940;
			cardDefaultConfig.Colors = new List<ManaColor>
			{
				ManaColor.Blue,
				ManaColor.Black
			};
			cardDefaultConfig.Cost = new ManaGroup
			{
				Blue = 2,
				Black = 2
			};
			cardDefaultConfig.UpgradedCost = new ManaGroup?(new ManaGroup
			{
				Blue = 1,
				Black = 1
			});
			cardDefaultConfig.Rarity = Rarity.Rare;
			cardDefaultConfig.Owner = this.OwnerName;
			cardDefaultConfig.Type = CardType.Ability;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.Nobody);
			cardDefaultConfig.Value1 = new int?(1);
			cardDefaultConfig.Value2 = new int?(4);
			cardDefaultConfig.RelativeEffects = new List<string> { "PatchouliSignKeywordSe", "PatchouliBoostSe" };
			cardDefaultConfig.UpgradedRelativeEffects = new List<string> { "PatchouliSignKeywordSe", "PatchouliBoostSe" };
			cardDefaultConfig.Illustrator = PatchouliIllustrator.PatchouliAwakenedSpellbook;
			return cardDefaultConfig;
		}
	}
}
