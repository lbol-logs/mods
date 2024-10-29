using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using PatchouliCharacterMod.Cards.Template;
using PatchouliCharacterMod.Illustrator;

namespace PatchouliCharacterMod.Cards
{
	public sealed class PatchouliDiamondHardnessDef : PatchouliCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.Index = 6300;
			cardDefaultConfig.Colors = new List<ManaColor> { ManaColor.Colorless };
			cardDefaultConfig.Cost = new ManaGroup
			{
				Any = 3,
				Colorless = 1
			};
			cardDefaultConfig.UpgradedCost = new ManaGroup?(new ManaGroup
			{
				Any = 2,
				Colorless = 1
			});
			cardDefaultConfig.Rarity = Rarity.Uncommon;
			cardDefaultConfig.Owner = this.OwnerName;
			cardDefaultConfig.Type = CardType.Defense;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.Nobody);
			cardDefaultConfig.Shield = new int?(15);
			cardDefaultConfig.UpgradedShield = new int?(18);
			cardDefaultConfig.Value1 = new int?(15);
			cardDefaultConfig.UpgradedValue1 = new int?(18);
			cardDefaultConfig.Value2 = new int?(5);
			cardDefaultConfig.UpgradedValue2 = new int?(6);
			cardDefaultConfig.RelativeEffects = new List<string> { "PatchouliBoostSe", "Reflect", "TempElectric" };
			cardDefaultConfig.UpgradedRelativeEffects = new List<string> { "PatchouliBoostSe", "Reflect", "TempElectric" };
			cardDefaultConfig.Illustrator = PatchouliIllustrator.PatchouliDiamondHardness;
			return cardDefaultConfig;
		}
	}
}
