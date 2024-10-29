using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using YoumuCharacterMod.Cards.Template;
using YoumuCharacterMod.GunName;
using YoumuCharacterMod.Illustrator;

namespace YoumuCharacterMod.Cards
{
	public sealed class YoumuGhostSlashDef : YoumuCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.GunName = YoumuGunName.GhostSlash;
			cardDefaultConfig.IsPooled = true;
			cardDefaultConfig.Index = 3120;
			cardDefaultConfig.Colors = new List<ManaColor> { ManaColor.White };
			cardDefaultConfig.Cost = new ManaGroup
			{
				Any = 1,
				White = 1
			};
			cardDefaultConfig.Rarity = Rarity.Common;
			cardDefaultConfig.Owner = this.OwnerName;
			cardDefaultConfig.Type = CardType.Attack;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.SingleEnemy);
			cardDefaultConfig.Damage = new int?(14);
			cardDefaultConfig.UpgradedDamage = new int?(18);
			cardDefaultConfig.Block = new int?(6);
			cardDefaultConfig.UpgradedBlock = new int?(8);
			cardDefaultConfig.Keywords = Keyword.Ethereal;
			cardDefaultConfig.UpgradedKeywords = Keyword.Ethereal;
			cardDefaultConfig.RelativeKeyword = Keyword.Block;
			cardDefaultConfig.UpgradedRelativeKeyword = Keyword.Block;
			cardDefaultConfig.Illustrator = YoumuIllustrator.GhostSlash;
			return cardDefaultConfig;
		}
	}
}
