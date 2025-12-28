using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using ReimuUnifierMod.Cards.Template;
using ReimuUnifierMod.GunName;

namespace ReimuUnifierMod.Cards
{
	public sealed class ReimuUnifierBanishingRitualDrainingStrikeDef : ReimuUnifierCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.GunName = GunNameID.GetGunFromId(400);
			cardDefaultConfig.IsPooled = true;
			cardDefaultConfig.Colors = new List<ManaColor>
			{
				ManaColor.Red,
				ManaColor.White
			};
			cardDefaultConfig.Cost = new ManaGroup
			{
				Any = 2,
				Hybrid = 1,
				HybridColor = 2
			};
			cardDefaultConfig.UpgradedCost = new ManaGroup?(new ManaGroup
			{
				Any = 2,
				Hybrid = 1,
				HybridColor = 2
			});
			cardDefaultConfig.Rarity = Rarity.Rare;
			cardDefaultConfig.Type = CardType.Attack;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.SingleEnemy);
			cardDefaultConfig.Damage = new int?(18);
			cardDefaultConfig.UpgradedDamage = new int?(24);
			cardDefaultConfig.Value1 = new int?(8);
			cardDefaultConfig.UpgradedValue1 = new int?(12);
			cardDefaultConfig.Keywords = Keyword.Exile | Keyword.Expel;
			cardDefaultConfig.UpgradedKeywords = Keyword.Accuracy | Keyword.Exile | Keyword.Expel;
			cardDefaultConfig.Illustrator = "Saevin";
			cardDefaultConfig.Index = CardIndexGenerator.GetUniqueIndex(cardDefaultConfig);
			return cardDefaultConfig;
		}
	}
}
