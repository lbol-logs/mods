using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using PatchouliCharacterMod.Cards.Template;
using PatchouliCharacterMod.GunName;
using PatchouliCharacterMod.Illustrator;

namespace PatchouliCharacterMod.Cards
{
	public sealed class PatchouliSpellCreationDef : PatchouliCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.Index = 5920;
			cardDefaultConfig.GunName = PatchouliGunName.PatchouliSpellCreation;
			cardDefaultConfig.Colors = new List<ManaColor>
			{
				ManaColor.Blue,
				ManaColor.Black
			};
			cardDefaultConfig.Cost = new ManaGroup
			{
				Hybrid = 2,
				HybridColor = 4
			};
			cardDefaultConfig.Rarity = Rarity.Rare;
			cardDefaultConfig.Owner = this.OwnerName;
			cardDefaultConfig.Type = CardType.Attack;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.SingleEnemy);
			cardDefaultConfig.Damage = new int?(15);
			cardDefaultConfig.UpgradedDamage = new int?(18);
			cardDefaultConfig.Value1 = new int?(4);
			cardDefaultConfig.Value2 = new int?(1);
			cardDefaultConfig.RelativeEffects = new List<string> { "PatchouliBoostSe" };
			cardDefaultConfig.UpgradedRelativeEffects = new List<string> { "PatchouliBoostSe" };
			cardDefaultConfig.RelativeCards = new List<string> { "PatchouliSpellCreationBlock", "PatchouliSpellCreationDraw", "PatchouliSpellCreationFire", "PatchouliSpellCreationWeak" };
			cardDefaultConfig.UpgradedRelativeCards = new List<string> { "PatchouliSpellCreationBlock", "PatchouliSpellCreationDraw", "PatchouliSpellCreationFire", "PatchouliSpellCreationWeak" };
			cardDefaultConfig.Illustrator = PatchouliIllustrator.PatchouliSpellCreation;
			return cardDefaultConfig;
		}
	}
}
