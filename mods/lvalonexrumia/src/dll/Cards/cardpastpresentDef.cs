using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using lvalonexrumia.Cards.Template;
using lvalonexrumia.GunName;

namespace lvalonexrumia.Cards
{
	public sealed class cardpastpresentDef : lvalonexrumiaCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.Colors = new List<ManaColor>
			{
				ManaColor.Black,
				ManaColor.Red,
				ManaColor.Green
			};
			cardDefaultConfig.Cost = new ManaGroup
			{
				Black = 1,
				Red = 1,
				Green = 1
			};
			cardDefaultConfig.Rarity = Rarity.Rare;
			cardDefaultConfig.Type = CardType.Attack;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.SingleEnemy);
			cardDefaultConfig.GunName = GunNameID.GetGunFromId(13200);
			cardDefaultConfig.GunNameBurst = GunNameID.GetGunFromId(13201);
			cardDefaultConfig.Damage = new int?(2);
			cardDefaultConfig.Value1 = new int?(1);
			cardDefaultConfig.Keywords = Keyword.Accuracy | Keyword.Retain;
			cardDefaultConfig.UpgradedKeywords = Keyword.Accuracy | Keyword.Echo | Keyword.Retain;
			cardDefaultConfig.Illustrator = "ポップル";
			cardDefaultConfig.Index = CardIndexGenerator.GetUniqueIndex(cardDefaultConfig);
			return cardDefaultConfig;
		}
	}
}
