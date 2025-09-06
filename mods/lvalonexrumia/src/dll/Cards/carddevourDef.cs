using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using lvalonexrumia.Cards.Template;
using lvalonexrumia.GunName;

namespace lvalonexrumia.Cards
{
	public sealed class carddevourDef : lvalonexrumiaCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.Colors = new List<ManaColor>
			{
				ManaColor.Black,
				ManaColor.Red
			};
			cardDefaultConfig.Cost = new ManaGroup
			{
				Hybrid = 2,
				HybridColor = 7
			};
			cardDefaultConfig.Rarity = Rarity.Uncommon;
			cardDefaultConfig.FindInBattle = false;
			cardDefaultConfig.Type = CardType.Attack;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.SingleEnemy);
			cardDefaultConfig.GunName = GunNameID.GetGunFromId(7020);
			cardDefaultConfig.GunNameBurst = GunNameID.GetGunFromId(7021);
			cardDefaultConfig.Damage = new int?(13);
			cardDefaultConfig.UpgradedDamage = new int?(17);
			cardDefaultConfig.Value1 = new int?(10);
			cardDefaultConfig.Keywords = Keyword.Accuracy | Keyword.Expel;
			cardDefaultConfig.UpgradedKeywords = Keyword.Accuracy | Keyword.Expel;
			cardDefaultConfig.Illustrator = "c0sm1c0wl";
			cardDefaultConfig.Index = CardIndexGenerator.GetUniqueIndex(cardDefaultConfig);
			return cardDefaultConfig;
		}
	}
}
