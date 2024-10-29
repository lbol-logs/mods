using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using PatchouliCharacterMod.Cards.Template;
using PatchouliCharacterMod.Illustrator;

namespace PatchouliCharacterMod.Cards
{
	public sealed class PatchouliBuryInLakeDef : PatchouliCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.Index = 5420;
			cardDefaultConfig.Colors = new List<ManaColor> { ManaColor.Blue };
			cardDefaultConfig.Cost = new ManaGroup
			{
				Any = 1,
				Blue = 1
			};
			cardDefaultConfig.Rarity = Rarity.Uncommon;
			cardDefaultConfig.Owner = this.OwnerName;
			cardDefaultConfig.Type = CardType.Defense;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.Self);
			cardDefaultConfig.Block = new int?(12);
			cardDefaultConfig.UpgradedBlock = new int?(0);
			cardDefaultConfig.Shield = new int?(0);
			cardDefaultConfig.UpgradedShield = new int?(12);
			cardDefaultConfig.Value1 = new int?(1);
			cardDefaultConfig.RelativeEffects = new List<string> { "PatchouliSignKeywordSe", "PatchouliWaterSignSe" };
			cardDefaultConfig.UpgradedRelativeEffects = new List<string> { "PatchouliSignKeywordSe", "PatchouliWaterSignSe" };
			cardDefaultConfig.Illustrator = PatchouliIllustrator.PatchouliBuryInLake;
			return cardDefaultConfig;
		}
	}
}
