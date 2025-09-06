using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using lvalonexrumia.Cards.Template;
using lvalonexrumia.GunName;

namespace lvalonexrumia.Cards
{
	public sealed class cardnoradrenalineDef : lvalonexrumiaCardTemplate
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
				Any = 1,
				Hybrid = 2,
				HybridColor = 7
			};
			cardDefaultConfig.UpgradedCost = new ManaGroup?(new ManaGroup
			{
				Any = 1,
				Hybrid = 1,
				HybridColor = 7
			});
			cardDefaultConfig.Rarity = Rarity.Uncommon;
			cardDefaultConfig.Type = CardType.Attack;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.All);
			cardDefaultConfig.GunName = GunNameID.GetGunFromId(7060);
			cardDefaultConfig.GunNameBurst = GunNameID.GetGunFromId(7061);
			cardDefaultConfig.Damage = new int?(5);
			cardDefaultConfig.Value1 = new int?(5);
			cardDefaultConfig.Value2 = new int?(2);
			cardDefaultConfig.UpgradedKeywords = Keyword.Accuracy;
			cardDefaultConfig.RelativeEffects = new List<string> { "sedecrease", "sebloodmark", "sebleed" };
			cardDefaultConfig.UpgradedRelativeEffects = new List<string> { "sedecrease", "sebloodmark", "sebleed" };
			cardDefaultConfig.RelativeCards = new List<string> { "cardredblood" };
			cardDefaultConfig.UpgradedRelativeCards = new List<string> { "cardredblood" };
			cardDefaultConfig.Illustrator = "楠なのは";
			cardDefaultConfig.Index = CardIndexGenerator.GetUniqueIndex(cardDefaultConfig);
			return cardDefaultConfig;
		}
	}
}
