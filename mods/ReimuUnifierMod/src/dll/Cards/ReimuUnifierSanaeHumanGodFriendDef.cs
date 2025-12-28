using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using ReimuUnifierMod.Cards.Template;

namespace ReimuUnifierMod.Cards
{
	public sealed class ReimuUnifierSanaeHumanGodFriendDef : ReimuUnifierCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.Colors = new List<ManaColor> { ManaColor.White };
			cardDefaultConfig.Cost = new ManaGroup
			{
				Any = 2,
				White = 1
			};
			cardDefaultConfig.Rarity = Rarity.Uncommon;
			cardDefaultConfig.GunName = "ShootR";
			cardDefaultConfig.IsPooled = true;
			cardDefaultConfig.Type = CardType.Friend;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.Nobody);
			cardDefaultConfig.Loyalty = new int?(4);
			cardDefaultConfig.UpgradedLoyalty = new int?(5);
			cardDefaultConfig.PassiveCost = new int?(1);
			cardDefaultConfig.UpgradedPassiveCost = new int?(1);
			cardDefaultConfig.ActiveCost = new int?(-5);
			cardDefaultConfig.UpgradedActiveCost = new int?(-5);
			cardDefaultConfig.ActiveCost2 = new int?(-5);
			cardDefaultConfig.UpgradedActiveCost2 = new int?(-5);
			cardDefaultConfig.UltimateCost = new int?(-5);
			cardDefaultConfig.UpgradedUltimateCost = new int?(-5);
			cardDefaultConfig.Value1 = new int?(1);
			cardDefaultConfig.UpgradedValue1 = new int?(2);
			cardDefaultConfig.Value2 = new int?(2);
			cardDefaultConfig.UpgradedValue2 = new int?(2);
			cardDefaultConfig.Block = new int?(0);
			cardDefaultConfig.Shield = new int?(0);
			cardDefaultConfig.RelativeKeyword = Keyword.Block | Keyword.Exile;
			cardDefaultConfig.UpgradedRelativeKeyword = Keyword.Shield | Keyword.Exile;
			cardDefaultConfig.RelativeEffects = new List<string> { "Amulet", "AmuletForCard", "SpiritNegative", "Weak", "Spirit", "FakeCuriositySe" };
			cardDefaultConfig.UpgradedRelativeEffects = new List<string> { "Amulet", "AmuletForCard", "SpiritNegative", "Weak", "Spirit", "FakeCuriositySe" };
			cardDefaultConfig.Illustrator = "Saevin";
			cardDefaultConfig.Index = CardIndexGenerator.GetUniqueIndex(cardDefaultConfig);
			return cardDefaultConfig;
		}
	}
}
