using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using lvalonexrumia.Cards.Template;
using lvalonexrumia.GunName;

namespace lvalonexrumia.Cards
{
	public sealed class cardletsdanceDef : lvalonexrumiaCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.Colors = new List<ManaColor> { ManaColor.Black };
			cardDefaultConfig.Cost = new ManaGroup
			{
				Any = 2,
				Black = 1
			};
			cardDefaultConfig.Rarity = Rarity.Rare;
			cardDefaultConfig.Type = CardType.Attack;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.AllEnemies);
			cardDefaultConfig.Damage = new int?(7);
			cardDefaultConfig.UpgradedDamage = new int?(10);
			cardDefaultConfig.Value1 = new int?(1);
			cardDefaultConfig.UpgradedValue1 = new int?(2);
			cardDefaultConfig.Value2 = new int?(2);
			cardDefaultConfig.GunName = GunNameID.GetGunFromId(7070);
			cardDefaultConfig.GunNameBurst = GunNameID.GetGunFromId(7071);
			cardDefaultConfig.Keywords = Keyword.Accuracy;
			cardDefaultConfig.UpgradedKeywords = Keyword.Accuracy;
			cardDefaultConfig.RelativeEffects = new List<string> { "sebloodmark", "Graze" };
			cardDefaultConfig.UpgradedRelativeEffects = new List<string> { "sebloodmark", "Graze" };
			cardDefaultConfig.Illustrator = "まめもち";
			cardDefaultConfig.Index = CardIndexGenerator.GetUniqueIndex(cardDefaultConfig);
			return cardDefaultConfig;
		}
	}
}
