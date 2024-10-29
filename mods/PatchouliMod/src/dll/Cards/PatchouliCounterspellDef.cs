using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using PatchouliCharacterMod.Cards.Template;
using PatchouliCharacterMod.Illustrator;

namespace PatchouliCharacterMod.Cards
{
	public sealed class PatchouliCounterspellDef : PatchouliCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.Index = 5495;
			cardDefaultConfig.HideMesuem = true;
			cardDefaultConfig.IsPooled = false;
			cardDefaultConfig.Colors = new List<ManaColor> { ManaColor.Blue };
			cardDefaultConfig.Cost = new ManaGroup
			{
				Blue = 2
			};
			cardDefaultConfig.Rarity = Rarity.Uncommon;
			cardDefaultConfig.Owner = this.OwnerName;
			cardDefaultConfig.Type = CardType.Skill;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.SingleEnemy);
			cardDefaultConfig.Block = new int?(12);
			cardDefaultConfig.UpgradedBlock = new int?(15);
			cardDefaultConfig.Shield = new int?(12);
			cardDefaultConfig.UpgradedShield = new int?(15);
			cardDefaultConfig.Value1 = new int?(1);
			cardDefaultConfig.Illustrator = PatchouliIllustrator.PatchouliCounterspell;
			cardDefaultConfig.RelativeEffects = new List<string> { "PatchouliCounterSe" };
			cardDefaultConfig.UpgradedRelativeEffects = new List<string> { "PatchouliCounterSe" };
			return cardDefaultConfig;
		}
	}
}
