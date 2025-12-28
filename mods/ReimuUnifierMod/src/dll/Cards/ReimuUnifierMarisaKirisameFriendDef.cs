using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using ReimuUnifierMod.Cards.Template;

namespace ReimuUnifierMod.Cards
{
	public sealed class ReimuUnifierMarisaKirisameFriendDef : ReimuUnifierCardTemplate
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
			cardDefaultConfig.Rarity = Rarity.Common;
			cardDefaultConfig.GunName = "ShootR";
			cardDefaultConfig.IsPooled = true;
			cardDefaultConfig.Type = CardType.Friend;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.Nobody);
			cardDefaultConfig.Damage = new int?(5);
			cardDefaultConfig.UpgradedDamage = new int?(8);
			cardDefaultConfig.Loyalty = new int?(2);
			cardDefaultConfig.UpgradedLoyalty = new int?(3);
			cardDefaultConfig.PassiveCost = new int?(1);
			cardDefaultConfig.UpgradedPassiveCost = new int?(1);
			cardDefaultConfig.ActiveCost = new int?(-4);
			cardDefaultConfig.UpgradedActiveCost = new int?(-4);
			cardDefaultConfig.UltimateCost = new int?(-9);
			cardDefaultConfig.UpgradedUltimateCost = new int?(-9);
			cardDefaultConfig.Value1 = new int?(14);
			cardDefaultConfig.UpgradedValue1 = new int?(12);
			cardDefaultConfig.Value2 = new int?(25);
			cardDefaultConfig.UpgradedValue2 = new int?(32);
			cardDefaultConfig.Keywords = Keyword.None;
			cardDefaultConfig.UpgradedKeywords = Keyword.None;
			cardDefaultConfig.RelativeEffects = new List<string> { "Vulnerable", "Charging" };
			cardDefaultConfig.UpgradedRelativeEffects = new List<string> { "Vulnerable", "Charging" };
			cardDefaultConfig.RelativeCards = new List<string>();
			cardDefaultConfig.UpgradedRelativeCards = new List<string>();
			cardDefaultConfig.Illustrator = "Saevin";
			cardDefaultConfig.Index = CardIndexGenerator.GetUniqueIndex(cardDefaultConfig);
			return cardDefaultConfig;
		}
	}
}
