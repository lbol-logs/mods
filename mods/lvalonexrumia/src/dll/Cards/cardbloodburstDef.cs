using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using lvalonexrumia.Cards.Template;
using lvalonexrumia.GunName;

namespace lvalonexrumia.Cards
{
	public sealed class cardbloodburstDef : lvalonexrumiaCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.Colors = new List<ManaColor> { ManaColor.Red };
			cardDefaultConfig.Cost = new ManaGroup
			{
				Any = 1,
				Red = 1
			};
			cardDefaultConfig.Rarity = Rarity.Rare;
			cardDefaultConfig.Type = CardType.Attack;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.All);
			cardDefaultConfig.GunName = GunNameID.GetGunFromId(4532);
			cardDefaultConfig.GunNameBurst = GunNameID.GetGunFromId(4532);
			cardDefaultConfig.Damage = new int?(5);
			cardDefaultConfig.Value1 = new int?(5);
			cardDefaultConfig.Value2 = new int?(2);
			cardDefaultConfig.UpgradedValue2 = new int?(3);
			cardDefaultConfig.Keywords = Keyword.Accuracy;
			cardDefaultConfig.UpgradedKeywords = Keyword.Accuracy;
			cardDefaultConfig.RelativeEffects = new List<string> { "sedecrease", "sebleed" };
			cardDefaultConfig.UpgradedRelativeEffects = new List<string> { "sedecrease", "sebleed" };
			cardDefaultConfig.Illustrator = "さとくら";
			cardDefaultConfig.Index = CardIndexGenerator.GetUniqueIndex(cardDefaultConfig);
			return cardDefaultConfig;
		}
	}
}
