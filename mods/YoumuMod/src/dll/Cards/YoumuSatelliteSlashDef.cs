using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using YoumuCharacterMod.Cards.Template;
using YoumuCharacterMod.GunName;
using YoumuCharacterMod.Illustrator;

namespace YoumuCharacterMod.Cards
{
	public sealed class YoumuSatelliteSlashDef : YoumuCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.GunName = YoumuGunName.SatelliteSlash;
			cardDefaultConfig.IsPooled = true;
			cardDefaultConfig.Index = 3410;
			cardDefaultConfig.Colors = new List<ManaColor> { ManaColor.White };
			cardDefaultConfig.Cost = new ManaGroup
			{
				Any = 1
			};
			cardDefaultConfig.Rarity = Rarity.Uncommon;
			cardDefaultConfig.Owner = this.OwnerName;
			cardDefaultConfig.Type = CardType.Attack;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.SingleEnemy);
			cardDefaultConfig.Damage = new int?(8);
			cardDefaultConfig.UpgradedDamage = new int?(12);
			cardDefaultConfig.Keywords = Keyword.None;
			cardDefaultConfig.UpgradedKeywords = Keyword.None;
			cardDefaultConfig.RelativeCards = new List<string> { "YoumuSlashOfPresent" };
			cardDefaultConfig.UpgradedRelativeCards = new List<string> { "YoumuSlashOfPresent" };
			cardDefaultConfig.RelativeEffects = new List<string> { "YoumuUnsheatheSe" };
			cardDefaultConfig.UpgradedRelativeEffects = new List<string> { "YoumuUnsheatheSe" };
			cardDefaultConfig.Illustrator = YoumuIllustrator.SatelliteSlash;
			return cardDefaultConfig;
		}
	}
}
