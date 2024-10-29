using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using PatchouliCharacterMod.Cards.Template;
using PatchouliCharacterMod.Illustrator;

namespace PatchouliCharacterMod.Cards
{
	public sealed class PatchouliHydrogenousProminenceDef : PatchouliCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.Index = 5840;
			cardDefaultConfig.Colors = new List<ManaColor> { ManaColor.Black };
			cardDefaultConfig.Cost = new ManaGroup
			{
				Any = 3,
				Black = 1
			};
			cardDefaultConfig.UpgradedCost = new ManaGroup?(new ManaGroup
			{
				Any = 4
			});
			cardDefaultConfig.Rarity = Rarity.Rare;
			cardDefaultConfig.Owner = this.OwnerName;
			cardDefaultConfig.Type = CardType.Defense;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.Nobody);
			cardDefaultConfig.Shield = new int?(12);
			cardDefaultConfig.UpgradedShield = new int?(15);
			cardDefaultConfig.Value1 = new int?(1);
			cardDefaultConfig.Mana = new ManaGroup?(new ManaGroup
			{
				Any = 1
			});
			cardDefaultConfig.RelativeEffects = new List<string> { "PatchouliSignKeywordSe", "PatchouliSunSignSe", "PatchouliWaterSignSe" };
			cardDefaultConfig.UpgradedRelativeEffects = new List<string> { "PatchouliSignKeywordSe", "PatchouliSunSignSe", "PatchouliWaterSignSe" };
			cardDefaultConfig.Illustrator = PatchouliIllustrator.PatchouliHydrogenousProminence;
			return cardDefaultConfig;
		}
	}
}
