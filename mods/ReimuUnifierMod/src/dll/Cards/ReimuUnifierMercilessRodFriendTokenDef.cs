using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using ReimuUnifierMod.Cards.Template;

namespace ReimuUnifierMod.Cards
{
	public sealed class ReimuUnifierMercilessRodFriendTokenDef : ReimuUnifierCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.Colors = new List<ManaColor> { ManaColor.Colorless };
			cardDefaultConfig.Cost = default(ManaGroup);
			cardDefaultConfig.Rarity = Rarity.Common;
			cardDefaultConfig.GunName = "时间悖论";
			cardDefaultConfig.IsPooled = false;
			cardDefaultConfig.Type = CardType.Friend;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.Nobody);
			cardDefaultConfig.Loyalty = new int?(1);
			cardDefaultConfig.UpgradedLoyalty = new int?(1);
			cardDefaultConfig.PassiveCost = new int?(1);
			cardDefaultConfig.UpgradedPassiveCost = new int?(1);
			cardDefaultConfig.UltimateCost = new int?(-5);
			cardDefaultConfig.UpgradedUltimateCost = new int?(-5);
			cardDefaultConfig.Damage = new int?(5);
			cardDefaultConfig.UpgradedDamage = new int?(8);
			cardDefaultConfig.Value1 = new int?(1);
			cardDefaultConfig.UpgradedValue1 = new int?(1);
			cardDefaultConfig.RelativeEffects = new List<string> { "Firepower", "TempFirepower" };
			cardDefaultConfig.UpgradedRelativeEffects = new List<string> { "Firepower", "TempFirepower" };
			cardDefaultConfig.Illustrator = "Saevin";
			cardDefaultConfig.Index = CardIndexGenerator.GetUniqueIndex(cardDefaultConfig);
			return cardDefaultConfig;
		}
	}
}
