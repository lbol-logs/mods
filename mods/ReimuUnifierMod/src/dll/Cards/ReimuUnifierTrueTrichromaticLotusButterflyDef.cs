using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using ReimuUnifierMod.Cards.Template;

namespace ReimuUnifierMod.Cards
{
	public sealed class ReimuUnifierTrueTrichromaticLotusButterflyDef : ReimuUnifierCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.GunName = "究极火花B";
			cardDefaultConfig.IsPooled = true;
			cardDefaultConfig.Colors = new List<ManaColor> { ManaColor.Red };
			cardDefaultConfig.Cost = new ManaGroup
			{
				Any = 2,
				Red = 3
			};
			cardDefaultConfig.UpgradedCost = new ManaGroup?(new ManaGroup
			{
				Any = 2,
				Red = 3
			});
			cardDefaultConfig.Rarity = Rarity.Rare;
			cardDefaultConfig.Mana = new ManaGroup?(new ManaGroup
			{
				Red = 1
			});
			cardDefaultConfig.Type = CardType.Attack;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.SingleEnemy);
			cardDefaultConfig.Damage = new int?(6);
			cardDefaultConfig.UpgradedDamage = new int?(6);
			cardDefaultConfig.Value1 = new int?(10);
			cardDefaultConfig.UpgradedValue1 = new int?(10);
			cardDefaultConfig.Value2 = new int?(0);
			cardDefaultConfig.UpgradedValue2 = new int?(25);
			cardDefaultConfig.Keywords = Keyword.Accuracy;
			cardDefaultConfig.UpgradedKeywords = Keyword.Accuracy;
			cardDefaultConfig.RelativeEffects = new List<string> { "TeamUpSe", "Firepower" };
			cardDefaultConfig.UpgradedRelativeEffects = new List<string> { "TeamUpSe", "Firepower" };
			cardDefaultConfig.RelativeKeyword = Keyword.Friend;
			cardDefaultConfig.UpgradedRelativeKeyword = Keyword.Friend;
			cardDefaultConfig.Illustrator = "Saevin";
			cardDefaultConfig.Index = CardIndexGenerator.GetUniqueIndex(cardDefaultConfig);
			return cardDefaultConfig;
		}
	}
}
