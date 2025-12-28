using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using ReimuUnifierMod.Cards.Template;

namespace ReimuUnifierMod.Cards
{
	public sealed class ReimuUnifierShionImpoverishedDeityFriendDef : ReimuUnifierCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.Colors = new List<ManaColor> { ManaColor.Black };
			cardDefaultConfig.Cost = new ManaGroup
			{
				Any = 2,
				Black = 1
			};
			cardDefaultConfig.UpgradedCost = new ManaGroup?(new ManaGroup
			{
				Any = 1,
				Black = 1
			});
			cardDefaultConfig.Rarity = Rarity.Rare;
			cardDefaultConfig.GunName = "陷入贫困";
			cardDefaultConfig.IsPooled = true;
			cardDefaultConfig.Type = CardType.Friend;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.Nobody);
			cardDefaultConfig.Loyalty = new int?(4);
			cardDefaultConfig.UpgradedLoyalty = new int?(5);
			cardDefaultConfig.PassiveCost = new int?(1);
			cardDefaultConfig.UpgradedPassiveCost = new int?(1);
			cardDefaultConfig.ActiveCost = new int?(-3);
			cardDefaultConfig.UpgradedActiveCost = new int?(-3);
			cardDefaultConfig.UltimateCost = new int?(-7);
			cardDefaultConfig.UpgradedUltimateCost = new int?(-7);
			cardDefaultConfig.Damage = new int?(10);
			cardDefaultConfig.UpgradedDamage = new int?(13);
			cardDefaultConfig.RelativeKeyword = Keyword.Accuracy;
			cardDefaultConfig.UpgradedRelativeKeyword = Keyword.Accuracy;
			cardDefaultConfig.RelativeEffects = new List<string> { "Graze" };
			cardDefaultConfig.UpgradedRelativeEffects = new List<string> { "Graze" };
			cardDefaultConfig.RelativeCards = new List<string> { "BuyPeace" };
			cardDefaultConfig.UpgradedRelativeCards = new List<string> { "BuyPeace" };
			cardDefaultConfig.Illustrator = "Saevin";
			cardDefaultConfig.Index = CardIndexGenerator.GetUniqueIndex(cardDefaultConfig);
			return cardDefaultConfig;
		}
	}
}
