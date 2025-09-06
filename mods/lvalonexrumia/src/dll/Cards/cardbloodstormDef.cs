using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using lvalonexrumia.Cards.Template;
using lvalonexrumia.GunName;

namespace lvalonexrumia.Cards
{
	public sealed class cardbloodstormDef : lvalonexrumiaCardTemplate
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
			cardDefaultConfig.Type = CardType.Attack;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.AllEnemies);
			cardDefaultConfig.Damage = new int?(10);
			cardDefaultConfig.Value1 = new int?(1);
			cardDefaultConfig.GunName = GunNameID.GetGunFromId(4532);
			cardDefaultConfig.GunNameBurst = GunNameID.GetGunFromId(4532);
			cardDefaultConfig.Keywords = Keyword.Exile | Keyword.Retain | Keyword.AutoExile;
			cardDefaultConfig.UpgradedKeywords = Keyword.Exile | Keyword.Retain | Keyword.AutoExile;
			cardDefaultConfig.RelativeEffects = new List<string> { "sebleed", "sebloodstorm" };
			cardDefaultConfig.UpgradedRelativeEffects = new List<string> { "sebleed", "sebloodmark", "sebloodstorm" };
			cardDefaultConfig.Illustrator = "キトボシ";
			cardDefaultConfig.Index = CardIndexGenerator.GetUniqueIndex(cardDefaultConfig);
			return cardDefaultConfig;
		}
	}
}
