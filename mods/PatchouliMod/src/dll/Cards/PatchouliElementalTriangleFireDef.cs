using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using PatchouliCharacterMod.Cards.Template;
using PatchouliCharacterMod.Illustrator;

namespace PatchouliCharacterMod.Cards
{
	public sealed class PatchouliElementalTriangleFireDef : PatchouliCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.Index = 6090;
			cardDefaultConfig.HideMesuem = true;
			cardDefaultConfig.IsPooled = false;
			cardDefaultConfig.Colors = new List<ManaColor> { ManaColor.Red };
			cardDefaultConfig.Cost = default(ManaGroup);
			cardDefaultConfig.Rarity = Rarity.Common;
			cardDefaultConfig.Owner = this.OwnerName;
			cardDefaultConfig.Type = CardType.Skill;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.Self);
			cardDefaultConfig.Value1 = new int?(1);
			cardDefaultConfig.RelativeEffects = new List<string> { "PatchouliSignKeywordSe", "PatchouliFireSignSe" };
			cardDefaultConfig.UpgradedRelativeEffects = new List<string> { "PatchouliSignKeywordSe", "PatchouliFireSignSe" };
			cardDefaultConfig.Illustrator = PatchouliIllustrator.PatchouliElementalTriangleFire;
			return cardDefaultConfig;
		}
	}
}
