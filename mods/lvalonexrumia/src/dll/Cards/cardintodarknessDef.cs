using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using lvalonexrumia.Cards.Template;
using lvalonexrumia.GunName;

namespace lvalonexrumia.Cards
{
	public sealed class cardintodarknessDef : lvalonexrumiaCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.Colors = new List<ManaColor> { ManaColor.Black };
			cardDefaultConfig.Cost = new ManaGroup
			{
				Black = 1
			};
			cardDefaultConfig.Rarity = Rarity.Common;
			cardDefaultConfig.Type = CardType.Attack;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.SingleEnemy);
			cardDefaultConfig.Damage = new int?(5);
			cardDefaultConfig.Value1 = new int?(1);
			cardDefaultConfig.UpgradedValue1 = new int?(2);
			cardDefaultConfig.GunName = GunNameID.GetGunFromId(7000);
			cardDefaultConfig.GunNameBurst = GunNameID.GetGunFromId(7001);
			cardDefaultConfig.Keywords = Keyword.Accuracy;
			cardDefaultConfig.UpgradedKeywords = Keyword.Accuracy;
			cardDefaultConfig.RelativeEffects = new List<string> { "sebloodmark" };
			cardDefaultConfig.UpgradedRelativeEffects = new List<string> { "sebloodmark" };
			cardDefaultConfig.Illustrator = "cervus";
			cardDefaultConfig.Index = CardIndexGenerator.GetUniqueIndex(cardDefaultConfig);
			return cardDefaultConfig;
		}
	}
}
