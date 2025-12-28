using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using ReimuUnifierMod.Cards.Template;

namespace ReimuUnifierMod.Cards
{
	public sealed class ReimuUnifierFaithlessMountainAssaultDef : ReimuUnifierCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.GunName = "元鬼玉B";
			cardDefaultConfig.IsPooled = true;
			cardDefaultConfig.Colors = new List<ManaColor> { ManaColor.Black };
			cardDefaultConfig.Cost = new ManaGroup
			{
				Black = 1
			};
			cardDefaultConfig.UpgradedCost = new ManaGroup?(new ManaGroup
			{
				Black = 1
			});
			cardDefaultConfig.Rarity = Rarity.Uncommon;
			cardDefaultConfig.Type = CardType.Attack;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.AllEnemies);
			cardDefaultConfig.Keywords = Keyword.Accuracy | Keyword.Expel;
			cardDefaultConfig.UpgradedKeywords = Keyword.Accuracy | Keyword.Expel;
			cardDefaultConfig.RelativeCards = new List<string> { "ReimuUnifierConsumedByVengeanceMisfortuneToken" };
			cardDefaultConfig.UpgradedRelativeCards = new List<string> { "ReimuUnifierConsumedByVengeanceMisfortuneToken" };
			cardDefaultConfig.Damage = new int?(24);
			cardDefaultConfig.UpgradedDamage = new int?(32);
			cardDefaultConfig.Illustrator = "Saevin";
			cardDefaultConfig.Index = CardIndexGenerator.GetUniqueIndex(cardDefaultConfig);
			return cardDefaultConfig;
		}
	}
}
