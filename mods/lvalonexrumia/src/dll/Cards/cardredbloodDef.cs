using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using lvalonexrumia.Cards.Template;
using lvalonexrumia.GunName;

namespace lvalonexrumia.Cards
{
	public sealed class cardredbloodDef : lvalonexrumiaCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.IsPooled = false;
			cardDefaultConfig.Colors = new List<ManaColor> { ManaColor.Red };
			cardDefaultConfig.Cost = new ManaGroup
			{
				Any = 0
			};
			cardDefaultConfig.Rarity = Rarity.Uncommon;
			cardDefaultConfig.Type = CardType.Skill;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.AllEnemies);
			cardDefaultConfig.Damage = new int?(4);
			cardDefaultConfig.UpgradedDamage = new int?(8);
			cardDefaultConfig.Value1 = new int?(5);
			cardDefaultConfig.GunName = GunNameID.GetGunFromId(23010);
			cardDefaultConfig.GunNameBurst = GunNameID.GetGunFromId(23011);
			cardDefaultConfig.Mana = new ManaGroup?(new ManaGroup
			{
				Red = 1
			});
			cardDefaultConfig.UpgradedMana = new ManaGroup?(new ManaGroup
			{
				Philosophy = 1
			});
			cardDefaultConfig.Keywords = Keyword.Exile | Keyword.Retain;
			cardDefaultConfig.UpgradedKeywords = Keyword.Exile | Keyword.Retain;
			cardDefaultConfig.RelativeEffects = new List<string> { "seincrease", "sebleed" };
			cardDefaultConfig.UpgradedRelativeEffects = new List<string> { "seincrease", "sebleed" };
			cardDefaultConfig.Illustrator = "とたけけ";
			cardDefaultConfig.Index = CardIndexGenerator.GetUniqueIndex(cardDefaultConfig);
			return cardDefaultConfig;
		}
	}
}
