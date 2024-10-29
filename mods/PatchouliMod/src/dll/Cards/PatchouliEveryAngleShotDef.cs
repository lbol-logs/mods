using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using PatchouliCharacterMod.Cards.Template;
using PatchouliCharacterMod.GunName;
using PatchouliCharacterMod.Illustrator;

namespace PatchouliCharacterMod.Cards
{
	public sealed class PatchouliEveryAngleShotDef : PatchouliCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.Index = 5400;
			cardDefaultConfig.GunName = PatchouliGunName.PatchouliEveryAngleShot;
			cardDefaultConfig.Colors = new List<ManaColor> { ManaColor.Blue };
			cardDefaultConfig.Cost = new ManaGroup
			{
				Any = 0
			};
			cardDefaultConfig.Rarity = Rarity.Uncommon;
			cardDefaultConfig.Owner = this.OwnerName;
			cardDefaultConfig.Type = CardType.Attack;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.SingleEnemy);
			cardDefaultConfig.Damage = new int?(6);
			cardDefaultConfig.UpgradedDamage = new int?(9);
			cardDefaultConfig.Keywords = Keyword.Accuracy | Keyword.Exile;
			cardDefaultConfig.UpgradedKeywords = Keyword.Accuracy | Keyword.Exile;
			cardDefaultConfig.RelativeEffects = new List<string> { "PatchouliBoostSe" };
			cardDefaultConfig.UpgradedRelativeEffects = new List<string> { "PatchouliBoostSe" };
			cardDefaultConfig.Illustrator = PatchouliIllustrator.PatchouliEveryAngleShot;
			return cardDefaultConfig;
		}
	}
}
