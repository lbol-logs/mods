using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using lvalonexrumia.Cards.Template;
using lvalonexrumia.GunName;

namespace lvalonexrumia.Cards
{
	public sealed class cardbloodlaserDef : lvalonexrumiaCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.Colors = new List<ManaColor> { ManaColor.Black };
			cardDefaultConfig.Cost = new ManaGroup
			{
				Any = 1,
				Black = 1
			};
			cardDefaultConfig.Rarity = Rarity.Common;
			cardDefaultConfig.Type = CardType.Attack;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.SingleEnemy);
			cardDefaultConfig.Damage = new int?(7);
			cardDefaultConfig.UpgradedDamage = new int?(10);
			cardDefaultConfig.Value1 = new int?(5);
			cardDefaultConfig.Value2 = new int?(1);
			cardDefaultConfig.GunName = GunNameID.GetGunFromId(23061);
			cardDefaultConfig.GunNameBurst = GunNameID.GetGunFromId(23061);
			cardDefaultConfig.Keywords = Keyword.Accuracy;
			cardDefaultConfig.UpgradedKeywords = Keyword.Accuracy | Keyword.Replenish;
			cardDefaultConfig.RelativeEffects = new List<string> { "sedecrease", "sebloodmark" };
			cardDefaultConfig.UpgradedRelativeEffects = new List<string> { "sedecrease", "sebloodmark" };
			cardDefaultConfig.Illustrator = "tyourou god";
			cardDefaultConfig.Index = CardIndexGenerator.GetUniqueIndex(cardDefaultConfig);
			return cardDefaultConfig;
		}
	}
}
