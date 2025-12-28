using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using ReimuUnifierMod.Cards.Template;

namespace ReimuUnifierMod.Cards
{
	public sealed class ReimuUnifierNitoriBusinessPartnerFriendDef : ReimuUnifierCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.Colors = new List<ManaColor> { ManaColor.Blue };
			cardDefaultConfig.Cost = new ManaGroup
			{
				Blue = 1
			};
			cardDefaultConfig.UpgradedCost = new ManaGroup?(new ManaGroup
			{
				Blue = 1
			});
			cardDefaultConfig.Rarity = Rarity.Uncommon;
			cardDefaultConfig.GunName = "黄瓜导弹";
			cardDefaultConfig.GunNameBurst = "黄瓜导弹B";
			cardDefaultConfig.IsPooled = true;
			cardDefaultConfig.Type = CardType.Friend;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.Nobody);
			cardDefaultConfig.Loyalty = new int?(3);
			cardDefaultConfig.UpgradedLoyalty = new int?(3);
			cardDefaultConfig.ActiveCost = new int?(-3);
			cardDefaultConfig.UpgradedActiveCost = new int?(-3);
			cardDefaultConfig.ActiveCost2 = new int?(-3);
			cardDefaultConfig.UpgradedActiveCost2 = new int?(-3);
			cardDefaultConfig.UltimateCost = new int?(-9);
			cardDefaultConfig.UpgradedUltimateCost = new int?(-9);
			cardDefaultConfig.Damage = new int?(5);
			cardDefaultConfig.Value1 = new int?(2);
			cardDefaultConfig.UpgradedValue1 = new int?(3);
			cardDefaultConfig.Value2 = new int?(5);
			cardDefaultConfig.UpgradedValue2 = new int?(8);
			cardDefaultConfig.RelativeEffects = new List<string> { "Vulnerable", "Weak" };
			cardDefaultConfig.UpgradedRelativeEffects = new List<string> { "Vulnerable", "Weak", "LockedOn", "Fragil" };
			cardDefaultConfig.Illustrator = "Saevin";
			cardDefaultConfig.Index = CardIndexGenerator.GetUniqueIndex(cardDefaultConfig);
			return cardDefaultConfig;
		}
	}
}
