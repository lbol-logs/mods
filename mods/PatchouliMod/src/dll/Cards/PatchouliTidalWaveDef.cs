using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using PatchouliCharacterMod.Cards.Template;
using PatchouliCharacterMod.Illustrator;

namespace PatchouliCharacterMod.Cards
{
	public sealed class PatchouliTidalWaveDef : PatchouliCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.Index = 5422;
			cardDefaultConfig.Colors = new List<ManaColor> { ManaColor.Blue };
			cardDefaultConfig.Cost = new ManaGroup
			{
				Any = 1,
				Blue = 1
			};
			cardDefaultConfig.Rarity = Rarity.Uncommon;
			cardDefaultConfig.Owner = this.OwnerName;
			cardDefaultConfig.Type = CardType.Skill;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.SingleEnemy);
			cardDefaultConfig.Value1 = new int?(5);
			cardDefaultConfig.UpgradedValue1 = new int?(7);
			cardDefaultConfig.Value2 = new int?(2);
			cardDefaultConfig.Illustrator = PatchouliIllustrator.PatchouliTidalWave;
			cardDefaultConfig.RelativeEffects = new List<string> { "Drowning", "PatchouliBoostSe" };
			cardDefaultConfig.UpgradedRelativeEffects = new List<string> { "Drowning", "PatchouliBoostSe" };
			return cardDefaultConfig;
		}
	}
}
