using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using PatchouliCharacterMod.Cards.Template;
using PatchouliCharacterMod.Illustrator;

namespace PatchouliCharacterMod.Cards
{
	public sealed class PatchouliGirlOfShadeDef : PatchouliCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.Index = 6401;
			cardDefaultConfig.Colors = new List<ManaColor> { ManaColor.Black };
			cardDefaultConfig.Cost = new ManaGroup
			{
				Black = 4
			};
			cardDefaultConfig.Rarity = Rarity.Rare;
			cardDefaultConfig.Owner = this.OwnerName;
			cardDefaultConfig.Type = CardType.Ability;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.Self);
			cardDefaultConfig.Value1 = new int?(3);
			cardDefaultConfig.UpgradedValue1 = new int?(5);
			cardDefaultConfig.Value2 = new int?(1);
			cardDefaultConfig.RelativeCards = new List<string> { "Shadow" };
			cardDefaultConfig.UpgradedRelativeCards = new List<string> { "Shadow" };
			cardDefaultConfig.RelativeEffects = new List<string> { "Firepower", "Spirit" };
			cardDefaultConfig.UpgradedRelativeEffects = new List<string> { "Firepower", "Spirit" };
			cardDefaultConfig.Illustrator = PatchouliIllustrator.PatchouliGirlOfShade;
			return cardDefaultConfig;
		}
	}
}
