using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using ReimuUnifierMod.Cards.Template;

namespace ReimuUnifierMod.Cards
{
	public sealed class ReimuUnifierKogasaYoukaiBlacksmithFriendDef : ReimuUnifierCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.Colors = new List<ManaColor> { ManaColor.White };
			cardDefaultConfig.Cost = new ManaGroup
			{
				White = 2
			};
			cardDefaultConfig.Rarity = Rarity.Common;
			cardDefaultConfig.GunName = "ShootR";
			cardDefaultConfig.IsPooled = true;
			cardDefaultConfig.Type = CardType.Friend;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.Nobody);
			cardDefaultConfig.Loyalty = new int?(2);
			cardDefaultConfig.UpgradedLoyalty = new int?(3);
			cardDefaultConfig.PassiveCost = new int?(1);
			cardDefaultConfig.UpgradedPassiveCost = new int?(1);
			cardDefaultConfig.ActiveCost = new int?(-3);
			cardDefaultConfig.UpgradedActiveCost = new int?(-3);
			cardDefaultConfig.UltimateCost = new int?(-7);
			cardDefaultConfig.UpgradedUltimateCost = new int?(-7);
			cardDefaultConfig.Damage = new int?(4);
			cardDefaultConfig.UpgradedDamage = new int?(5);
			cardDefaultConfig.Value1 = new int?(1);
			cardDefaultConfig.UpgradedValue1 = new int?(2);
			cardDefaultConfig.Keywords = Keyword.Upgrade;
			cardDefaultConfig.UpgradedKeywords = Keyword.Upgrade;
			cardDefaultConfig.RelativeEffects = new List<string>();
			cardDefaultConfig.UpgradedRelativeEffects = new List<string>();
			cardDefaultConfig.RelativeCards = new List<string> { "ReimuUnifierYoukaiForgedNeedle" };
			cardDefaultConfig.UpgradedRelativeCards = new List<string> { "ReimuUnifierYoukaiForgedNeedle+" };
			cardDefaultConfig.Illustrator = "Saevin";
			cardDefaultConfig.Index = CardIndexGenerator.GetUniqueIndex(cardDefaultConfig);
			return cardDefaultConfig;
		}
	}
}
