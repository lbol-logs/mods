using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using YoumuCharacterMod.Cards.Template;
using YoumuCharacterMod.GunName;
using YoumuCharacterMod.Illustrator;

namespace YoumuCharacterMod.Cards
{
	public sealed class YoumuSlashOfKarmicWindDef : YoumuCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.GunName = YoumuGunName.SlashOfKarmicWind;
			cardDefaultConfig.GunNameBurst = YoumuGunName.SlashOfKarmicWindBurst;
			cardDefaultConfig.IsPooled = true;
			cardDefaultConfig.Index = 3540;
			cardDefaultConfig.Colors = new List<ManaColor> { ManaColor.Green };
			cardDefaultConfig.Cost = new ManaGroup
			{
				Any = 3,
				Green = 1
			};
			cardDefaultConfig.Rarity = Rarity.Uncommon;
			cardDefaultConfig.Owner = this.OwnerName;
			cardDefaultConfig.Type = CardType.Attack;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.SingleEnemy);
			cardDefaultConfig.Damage = new int?(8);
			cardDefaultConfig.UpgradedDamage = new int?(6);
			cardDefaultConfig.Value1 = new int?(2);
			cardDefaultConfig.UpgradedValue1 = new int?(3);
			cardDefaultConfig.Keywords = Keyword.Accuracy;
			cardDefaultConfig.UpgradedKeywords = Keyword.Accuracy;
			cardDefaultConfig.RelativeEffects = new List<string> { "LockedOn" };
			cardDefaultConfig.UpgradedRelativeEffects = new List<string> { "LockedOn" };
			cardDefaultConfig.Illustrator = YoumuIllustrator.SlashOfKarmicWind;
			return cardDefaultConfig;
		}
	}
}
