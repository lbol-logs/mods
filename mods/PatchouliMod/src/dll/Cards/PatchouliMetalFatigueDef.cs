using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using PatchouliCharacterMod.Cards.Template;
using PatchouliCharacterMod.GunName;
using PatchouliCharacterMod.Illustrator;

namespace PatchouliCharacterMod.Cards
{
	public sealed class PatchouliMetalFatigueDef : PatchouliCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.Index = 5930;
			cardDefaultConfig.GunName = PatchouliGunName.PatchouliMetalFatigue;
			cardDefaultConfig.Colors = new List<ManaColor>
			{
				ManaColor.Blue,
				ManaColor.Black
			};
			cardDefaultConfig.Cost = new ManaGroup
			{
				Blue = 1,
				Black = 1
			};
			cardDefaultConfig.Rarity = Rarity.Rare;
			cardDefaultConfig.Owner = this.OwnerName;
			cardDefaultConfig.Type = CardType.Skill;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.SingleEnemy);
			cardDefaultConfig.Value1 = new int?(2);
			cardDefaultConfig.Value2 = new int?(2);
			cardDefaultConfig.UpgradedValue2 = new int?(3);
			cardDefaultConfig.RelativeEffects = new List<string> { "PatchouliBoostSe", "PatchouliSignKeywordSe", "PatchouliMetalSignSe", "FirepowerNegative" };
			cardDefaultConfig.UpgradedRelativeEffects = new List<string> { "PatchouliBoostSe", "PatchouliSignKeywordSe", "PatchouliMetalSignSe", "FirepowerNegative" };
			cardDefaultConfig.Illustrator = PatchouliIllustrator.PatchouliMetalFatigue;
			return cardDefaultConfig;
		}
	}
}
