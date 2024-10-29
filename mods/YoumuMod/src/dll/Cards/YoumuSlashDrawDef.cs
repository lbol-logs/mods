using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using YoumuCharacterMod.Cards.Template;
using YoumuCharacterMod.GunName;
using YoumuCharacterMod.Illustrator;

namespace YoumuCharacterMod.Cards
{
	public sealed class YoumuSlashDrawDef : YoumuCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.GunName = YoumuGunName.SlashDraw;
			cardDefaultConfig.IsPooled = true;
			cardDefaultConfig.Index = 4002;
			cardDefaultConfig.Colors = new List<ManaColor> { ManaColor.Blue };
			cardDefaultConfig.Cost = default(ManaGroup);
			cardDefaultConfig.Rarity = Rarity.Uncommon;
			cardDefaultConfig.Owner = this.OwnerName;
			cardDefaultConfig.Type = CardType.Attack;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.AllEnemies);
			cardDefaultConfig.Damage = new int?(15);
			cardDefaultConfig.UpgradedDamage = new int?(20);
			cardDefaultConfig.Keywords = Keyword.Accuracy | Keyword.Forbidden | Keyword.Replenish;
			cardDefaultConfig.UpgradedKeywords = Keyword.Accuracy | Keyword.Forbidden | Keyword.Replenish;
			cardDefaultConfig.Illustrator = YoumuIllustrator.SlashDraw;
			return cardDefaultConfig;
		}
	}
}
