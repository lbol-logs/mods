using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using ReimuUnifierMod.Cards.Template;

namespace ReimuUnifierMod.Cards
{
	public sealed class ReimuUnifierKasenWildhornFriendDef : ReimuUnifierCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.Colors = new List<ManaColor> { ManaColor.Red };
			cardDefaultConfig.Cost = new ManaGroup
			{
				Any = 2,
				Red = 2
			};
			cardDefaultConfig.UpgradedCost = new ManaGroup?(new ManaGroup
			{
				Any = 2,
				Red = 2
			});
			cardDefaultConfig.Rarity = Rarity.Uncommon;
			cardDefaultConfig.GunName = "电击";
			cardDefaultConfig.IsPooled = true;
			cardDefaultConfig.Mana = new ManaGroup?(ManaGroup.Empty);
			cardDefaultConfig.Type = CardType.Friend;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.Nobody);
			cardDefaultConfig.Loyalty = new int?(2);
			cardDefaultConfig.UpgradedLoyalty = new int?(2);
			cardDefaultConfig.PassiveCost = new int?(1);
			cardDefaultConfig.UpgradedPassiveCost = new int?(1);
			cardDefaultConfig.ActiveCost = new int?(-4);
			cardDefaultConfig.UpgradedActiveCost = new int?(-4);
			cardDefaultConfig.UltimateCost = new int?(-8);
			cardDefaultConfig.UpgradedUltimateCost = new int?(-7);
			cardDefaultConfig.Damage = new int?(7);
			cardDefaultConfig.UpgradedDamage = new int?(7);
			cardDefaultConfig.Value1 = new int?(3);
			cardDefaultConfig.UpgradedValue1 = new int?(4);
			cardDefaultConfig.Value2 = new int?(2);
			cardDefaultConfig.UpgradedValue2 = new int?(2);
			cardDefaultConfig.Keywords = Keyword.None;
			cardDefaultConfig.UpgradedKeywords = Keyword.None;
			cardDefaultConfig.RelativeEffects = new List<string> { "Firepower", "Spirit" };
			cardDefaultConfig.UpgradedRelativeEffects = new List<string> { "Firepower", "Spirit", "Graze" };
			cardDefaultConfig.Illustrator = "Saevin";
			cardDefaultConfig.Index = CardIndexGenerator.GetUniqueIndex(cardDefaultConfig);
			return cardDefaultConfig;
		}
	}
}
