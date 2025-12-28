using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using ReimuUnifierMod.Cards.Template;

namespace ReimuUnifierMod.Cards
{
	public sealed class ReimuUnifierYukariYakumoFriendDef : ReimuUnifierCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.Colors = new List<ManaColor> { ManaColor.White };
			cardDefaultConfig.Cost = new ManaGroup
			{
				Any = 1,
				White = 1
			};
			cardDefaultConfig.Rarity = Rarity.Common;
			cardDefaultConfig.IsPooled = true;
			cardDefaultConfig.Type = CardType.Friend;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.Nobody);
			cardDefaultConfig.Loyalty = new int?(2);
			cardDefaultConfig.UpgradedLoyalty = new int?(2);
			cardDefaultConfig.PassiveCost = new int?(2);
			cardDefaultConfig.UpgradedPassiveCost = new int?(3);
			cardDefaultConfig.ActiveCost = new int?(-5);
			cardDefaultConfig.UpgradedActiveCost = new int?(-4);
			cardDefaultConfig.UltimateCost = new int?(-9);
			cardDefaultConfig.UpgradedUltimateCost = new int?(-9);
			cardDefaultConfig.Value1 = new int?(6);
			cardDefaultConfig.Value2 = new int?(10);
			cardDefaultConfig.UpgradedValue2 = new int?(12);
			cardDefaultConfig.Keywords = Keyword.None;
			cardDefaultConfig.UpgradedKeywords = Keyword.None;
			cardDefaultConfig.RelativeKeyword = Keyword.Shield | Keyword.Exile;
			cardDefaultConfig.UpgradedRelativeKeyword = Keyword.Shield | Keyword.Exile;
			cardDefaultConfig.RelativeEffects = new List<string> { "Invincible" };
			cardDefaultConfig.UpgradedRelativeEffects = new List<string> { "Invincible" };
			cardDefaultConfig.RelativeCards = new List<string> { "ReimuUnifierCommunicatorOrbToken" };
			cardDefaultConfig.UpgradedRelativeCards = new List<string> { "ReimuUnifierCommunicatorOrbToken" };
			cardDefaultConfig.Illustrator = "Saevin";
			cardDefaultConfig.Index = CardIndexGenerator.GetUniqueIndex(cardDefaultConfig);
			return cardDefaultConfig;
		}
	}
}
