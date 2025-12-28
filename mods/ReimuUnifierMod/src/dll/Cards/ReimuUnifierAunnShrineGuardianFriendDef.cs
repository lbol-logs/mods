using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using ReimuUnifierMod.Cards.Template;

namespace ReimuUnifierMod.Cards
{
	public sealed class ReimuUnifierAunnShrineGuardianFriendDef : ReimuUnifierCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.Colors = new List<ManaColor> { ManaColor.White };
			cardDefaultConfig.Cost = new ManaGroup
			{
				White = 3
			};
			cardDefaultConfig.Rarity = Rarity.Uncommon;
			cardDefaultConfig.GunName = "Simple1";
			cardDefaultConfig.IsPooled = true;
			cardDefaultConfig.Type = CardType.Friend;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.Nobody);
			cardDefaultConfig.Loyalty = new int?(8);
			cardDefaultConfig.UpgradedLoyalty = new int?(8);
			cardDefaultConfig.PassiveCost = new int?(-1);
			cardDefaultConfig.UpgradedPassiveCost = new int?(0);
			cardDefaultConfig.ActiveCost = new int?(-4);
			cardDefaultConfig.UpgradedActiveCost = new int?(-4);
			cardDefaultConfig.UltimateCost = new int?(-8);
			cardDefaultConfig.UpgradedUltimateCost = new int?(-8);
			cardDefaultConfig.Block = new int?(8);
			cardDefaultConfig.UpgradedBlock = new int?(10);
			cardDefaultConfig.Shield = new int?(8);
			cardDefaultConfig.UpgradedShield = new int?(10);
			cardDefaultConfig.Value1 = new int?(1);
			cardDefaultConfig.UpgradedValue1 = new int?(2);
			cardDefaultConfig.Value2 = new int?(2);
			cardDefaultConfig.UpgradedValue2 = new int?(3);
			cardDefaultConfig.RelativeKeyword = Keyword.Misfortune | Keyword.Block | Keyword.Shield | Keyword.Exile;
			cardDefaultConfig.UpgradedRelativeKeyword = Keyword.Misfortune | Keyword.Block | Keyword.Shield | Keyword.Exile;
			cardDefaultConfig.RelativeEffects = new List<string> { "Amulet", "AmuletForCard", "Graze", "TempSpirit", "FakeSealedSe" };
			cardDefaultConfig.UpgradedRelativeEffects = new List<string> { "Amulet", "AmuletForCard", "Graze", "TempSpirit", "FakeSealedSe" };
			cardDefaultConfig.Illustrator = "Saevin";
			cardDefaultConfig.Index = CardIndexGenerator.GetUniqueIndex(cardDefaultConfig);
			return cardDefaultConfig;
		}
	}
}
