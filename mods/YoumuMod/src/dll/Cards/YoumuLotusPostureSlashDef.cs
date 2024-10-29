using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using YoumuCharacterMod.Cards.Template;
using YoumuCharacterMod.GunName;
using YoumuCharacterMod.Illustrator;

namespace YoumuCharacterMod.Cards
{
	public sealed class YoumuLotusPostureSlashDef : YoumuCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.GunName = YoumuGunName.LotusPostureSlash;
			cardDefaultConfig.IsPooled = false;
			cardDefaultConfig.HideMesuem = true;
			cardDefaultConfig.Index = 3631;
			cardDefaultConfig.Colors = new List<ManaColor>
			{
				ManaColor.White,
				ManaColor.Green
			};
			cardDefaultConfig.Cost = new ManaGroup
			{
				Any = 2,
				Green = 1,
				White = 1
			};
			cardDefaultConfig.Rarity = Rarity.Uncommon;
			cardDefaultConfig.Owner = this.OwnerName;
			cardDefaultConfig.Type = CardType.Attack;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.SingleEnemy);
			cardDefaultConfig.Damage = new int?(18);
			cardDefaultConfig.UpgradedDamage = new int?(24);
			cardDefaultConfig.Mana = new ManaGroup?(new ManaGroup
			{
				Colorless = 1,
				White = 1,
				Green = 1
			});
			cardDefaultConfig.UpgradedKeywords = Keyword.Accuracy;
			cardDefaultConfig.Illustrator = YoumuIllustrator.LotusPostureSlash;
			return cardDefaultConfig;
		}
	}
}
