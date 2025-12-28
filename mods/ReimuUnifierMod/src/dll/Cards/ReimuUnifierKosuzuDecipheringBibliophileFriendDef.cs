using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using ReimuUnifierMod.Cards.Template;

namespace ReimuUnifierMod.Cards
{
	public sealed class ReimuUnifierKosuzuDecipheringBibliophileFriendDef : ReimuUnifierCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.Colors = new List<ManaColor>
			{
				ManaColor.Red,
				ManaColor.White
			};
			cardDefaultConfig.Cost = new ManaGroup
			{
				Red = 1,
				White = 1
			};
			cardDefaultConfig.Rarity = Rarity.Uncommon;
			cardDefaultConfig.Type = CardType.Friend;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.Nobody);
			cardDefaultConfig.Loyalty = new int?(8);
			cardDefaultConfig.UpgradedLoyalty = new int?(9);
			cardDefaultConfig.PassiveCost = new int?(0);
			cardDefaultConfig.UpgradedPassiveCost = new int?(0);
			cardDefaultConfig.ActiveCost = new int?(-3);
			cardDefaultConfig.UpgradedActiveCost = new int?(-3);
			cardDefaultConfig.UltimateCost = new int?(-9);
			cardDefaultConfig.UpgradedUltimateCost = new int?(-9);
			cardDefaultConfig.Value1 = new int?(1);
			cardDefaultConfig.UpgradedValue1 = new int?(2);
			cardDefaultConfig.Value2 = new int?(1);
			cardDefaultConfig.UpgradedValue2 = new int?(3);
			cardDefaultConfig.RelativeEffects = new List<string> { "Vulnerable", "LockedOn", "Graze", "Invincible", "GuangxueMicai" };
			cardDefaultConfig.UpgradedRelativeEffects = new List<string> { "Vulnerable", "LockedOn", "Graze", "Invincible", "GuangxueMicai" };
			cardDefaultConfig.Illustrator = "Saevin";
			cardDefaultConfig.Index = CardIndexGenerator.GetUniqueIndex(cardDefaultConfig);
			return cardDefaultConfig;
		}
	}
}
