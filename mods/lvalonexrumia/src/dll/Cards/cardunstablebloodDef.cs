using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using lvalonexrumia.Cards.Template;
using lvalonexrumia.GunName;

namespace lvalonexrumia.Cards
{
	public sealed class cardunstablebloodDef : lvalonexrumiaCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.Colors = new List<ManaColor> { ManaColor.Red };
			cardDefaultConfig.Cost = new ManaGroup
			{
				Any = 2,
				Red = 1
			};
			cardDefaultConfig.Rarity = Rarity.Uncommon;
			cardDefaultConfig.Type = CardType.Attack;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.AllEnemies);
			cardDefaultConfig.Damage = new int?(14);
			cardDefaultConfig.UpgradedDamage = new int?(18);
			cardDefaultConfig.Value1 = new int?(5);
			cardDefaultConfig.Value2 = new int?(2);
			cardDefaultConfig.UpgradedValue2 = new int?(3);
			cardDefaultConfig.GunName = GunNameID.GetGunFromId(23051);
			cardDefaultConfig.GunNameBurst = GunNameID.GetGunFromId(23052);
			cardDefaultConfig.Keywords = Keyword.Accuracy;
			cardDefaultConfig.UpgradedKeywords = Keyword.Accuracy;
			cardDefaultConfig.RelativeEffects = new List<string> { "sedecrease", "sebleed", "sebloodstorm" };
			cardDefaultConfig.UpgradedRelativeEffects = new List<string> { "sedecrease", "sebleed", "sebloodstorm" };
			cardDefaultConfig.RelativeCards = new List<string> { "cardbloodstorm" };
			cardDefaultConfig.UpgradedRelativeCards = new List<string> { "cardbloodstorm" };
			cardDefaultConfig.Illustrator = "Chama@skeb募集中";
			cardDefaultConfig.Index = CardIndexGenerator.GetUniqueIndex(cardDefaultConfig);
			return cardDefaultConfig;
		}
	}
}
