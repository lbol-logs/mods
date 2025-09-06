using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using lvalonexrumia.Cards.Template;
using lvalonexrumia.GunName;

namespace lvalonexrumia.Cards
{
	public sealed class cardetudeDef : lvalonexrumiaCardTemplate
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
				Black = 1,
				Red = 1
			};
			cardDefaultConfig.UpgradedCost = new ManaGroup?(new ManaGroup
			{
				Hybrid = 1,
				HybridColor = 7
			});
			cardDefaultConfig.Rarity = Rarity.Rare;
			cardDefaultConfig.Type = CardType.Attack;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.RandomEnemy);
			cardDefaultConfig.Damage = new int?(4);
			cardDefaultConfig.GunName = GunNameID.GetGunFromId(7041);
			cardDefaultConfig.GunNameBurst = GunNameID.GetGunFromId(7041);
			cardDefaultConfig.Value1 = new int?(5);
			cardDefaultConfig.Value2 = new int?(30);
			cardDefaultConfig.Keywords = Keyword.Accuracy;
			cardDefaultConfig.UpgradedKeywords = Keyword.Accuracy;
			cardDefaultConfig.RelativeEffects = new List<string> { "sedecrease", "seatkincrease" };
			cardDefaultConfig.UpgradedRelativeEffects = new List<string> { "sedecrease", "seatkincrease" };
			cardDefaultConfig.Illustrator = "awa yume";
			cardDefaultConfig.Index = CardIndexGenerator.GetUniqueIndex(cardDefaultConfig);
			return cardDefaultConfig;
		}
	}
}
