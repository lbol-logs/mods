using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using lvalonexrumia.Cards.Template;
using lvalonexrumia.GunName;

namespace lvalonexrumia.Cards
{
	public sealed class cardbiteDef : lvalonexrumiaCardTemplate
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
			cardDefaultConfig.Damage = new int?(13);
			cardDefaultConfig.UpgradedDamage = new int?(16);
			cardDefaultConfig.Value1 = new int?(1);
			cardDefaultConfig.UpgradedValue1 = new int?(2);
			cardDefaultConfig.GunName = GunNameID.GetGunFromId(7020);
			cardDefaultConfig.GunNameBurst = GunNameID.GetGunFromId(7021);
			cardDefaultConfig.RelativeEffects = new List<string> { "sedarkblood" };
			cardDefaultConfig.UpgradedRelativeEffects = new List<string> { "sedarkblood" };
			cardDefaultConfig.RelativeCards = new List<string> { "carddarkblood" };
			cardDefaultConfig.UpgradedRelativeCards = new List<string> { "carddarkblood" };
			cardDefaultConfig.Illustrator = "えすれき＠垢移行";
			cardDefaultConfig.SubIllustrator = new List<string> { "ワイテイ" };
			cardDefaultConfig.Index = CardIndexGenerator.GetUniqueIndex(cardDefaultConfig);
			return cardDefaultConfig;
		}
	}
}
