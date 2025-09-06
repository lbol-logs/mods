using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using lvalonexrumia.Cards.Template;
using lvalonexrumia.GunName;

namespace lvalonexrumia.Cards
{
	public sealed class cardbloodswordDef : lvalonexrumiaCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.IsPooled = false;
			cardDefaultConfig.Colors = new List<ManaColor>
			{
				ManaColor.Black,
				ManaColor.Red
			};
			cardDefaultConfig.Cost = new ManaGroup
			{
				Any = 0
			};
			cardDefaultConfig.Rarity = Rarity.Uncommon;
			cardDefaultConfig.Type = CardType.Attack;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.SingleEnemy);
			cardDefaultConfig.Damage = new int?(10);
			cardDefaultConfig.Value1 = new int?(5);
			cardDefaultConfig.Value2 = new int?(1);
			cardDefaultConfig.GunName = GunNameID.GetGunFromId(6162);
			cardDefaultConfig.GunNameBurst = GunNameID.GetGunFromId(6162);
			cardDefaultConfig.Keywords = Keyword.Accuracy | Keyword.Exile | Keyword.Retain | Keyword.AutoExile;
			cardDefaultConfig.UpgradedKeywords = Keyword.Accuracy | Keyword.Exile | Keyword.Retain | Keyword.AutoExile;
			cardDefaultConfig.RelativeEffects = new List<string> { "seincrease", "sebloodmark", "sebloodsword" };
			cardDefaultConfig.UpgradedRelativeEffects = new List<string> { "seincrease", "sebloodmark", "sebloodsword" };
			cardDefaultConfig.Illustrator = "sarise";
			cardDefaultConfig.Index = CardIndexGenerator.GetUniqueIndex(cardDefaultConfig);
			return cardDefaultConfig;
		}
	}
}
