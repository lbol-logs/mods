using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using PatchouliCharacterMod.Cards.Template;
using PatchouliCharacterMod.GunName;
using PatchouliCharacterMod.Illustrator;

namespace PatchouliCharacterMod.Cards
{
	public sealed class PatchouliSpringWindDef : PatchouliCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.Index = 6200;
			cardDefaultConfig.GunName = PatchouliGunName.PatchouliSpringWind;
			cardDefaultConfig.Colors = new List<ManaColor> { ManaColor.Green };
			cardDefaultConfig.Cost = new ManaGroup
			{
				Green = 1
			};
			cardDefaultConfig.UpgradedCost = new ManaGroup?(new ManaGroup
			{
				Any = 1
			});
			cardDefaultConfig.Rarity = Rarity.Uncommon;
			cardDefaultConfig.Owner = this.OwnerName;
			cardDefaultConfig.Type = CardType.Skill;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.Nobody);
			cardDefaultConfig.Value1 = new int?(1);
			cardDefaultConfig.Keywords = Keyword.Exile;
			cardDefaultConfig.UpgradedKeywords = Keyword.Exile;
			cardDefaultConfig.RelativeEffects = new List<string> { "PatchouliBoostSe" };
			cardDefaultConfig.UpgradedRelativeEffects = new List<string> { "PatchouliBoostSe" };
			cardDefaultConfig.RelativeCards = new List<string> { "GManaCard" };
			cardDefaultConfig.UpgradedRelativeCards = new List<string> { "PManaCard" };
			cardDefaultConfig.Illustrator = PatchouliIllustrator.PatchouliSpringWind;
			return cardDefaultConfig;
		}
	}
}
