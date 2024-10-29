using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using PatchouliCharacterMod.Cards.Template;
using PatchouliCharacterMod.Illustrator;

namespace PatchouliCharacterMod.Cards
{
	public sealed class PatchouliElementalTriangleDef : PatchouliCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.Index = 6000;
			cardDefaultConfig.Colors = new List<ManaColor> { ManaColor.White };
			cardDefaultConfig.Cost = new ManaGroup
			{
				White = 1
			};
			cardDefaultConfig.UpgradedCost = new ManaGroup?(new ManaGroup
			{
				Any = 0
			});
			cardDefaultConfig.Rarity = Rarity.Uncommon;
			cardDefaultConfig.Owner = this.OwnerName;
			cardDefaultConfig.Type = CardType.Skill;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.Nobody);
			cardDefaultConfig.Value1 = new int?(1);
			cardDefaultConfig.RelativeEffects = new List<string> { "PatchouliSignKeywordSe", "PatchouliFireSignSe", "PatchouliWaterSignSe", "PatchouliWoodSignSe" };
			cardDefaultConfig.UpgradedRelativeEffects = new List<string> { "PatchouliSignKeywordSe", "PatchouliFireSignSe", "PatchouliWaterSignSe", "PatchouliWoodSignSe" };
			cardDefaultConfig.RelativeCards = new List<string> { "PatchouliElementalTriangleFire", "PatchouliElementalTriangleWater", "PatchouliElementalTriangleWood" };
			cardDefaultConfig.UpgradedRelativeCards = new List<string> { "PatchouliElementalTriangleFire", "PatchouliElementalTriangleWater", "PatchouliElementalTriangleWood" };
			cardDefaultConfig.Illustrator = PatchouliIllustrator.PatchouliElementalTriangle;
			return cardDefaultConfig;
		}
	}
}
