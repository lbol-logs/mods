using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using ReimuUnifierMod.Cards.Template;

namespace ReimuUnifierMod.Cards
{
	public sealed class ReimuUnifierSuikaGourdOniFriendDef : ReimuUnifierCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.Colors = new List<ManaColor> { ManaColor.Red };
			cardDefaultConfig.Cost = new ManaGroup
			{
				Any = 1,
				Red = 2
			};
			cardDefaultConfig.UpgradedCost = new ManaGroup?(new ManaGroup
			{
				Any = 1,
				Red = 1
			});
			cardDefaultConfig.Rarity = Rarity.Uncommon;
			cardDefaultConfig.GunName = "ShootR";
			cardDefaultConfig.IsPooled = true;
			cardDefaultConfig.Type = CardType.Friend;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.Nobody);
			cardDefaultConfig.Loyalty = new int?(4);
			cardDefaultConfig.UpgradedLoyalty = new int?(4);
			cardDefaultConfig.PassiveCost = new int?(2);
			cardDefaultConfig.UpgradedPassiveCost = new int?(2);
			cardDefaultConfig.ActiveCost = new int?(-6);
			cardDefaultConfig.UpgradedActiveCost = new int?(-6);
			cardDefaultConfig.UltimateCost = new int?(-8);
			cardDefaultConfig.UpgradedUltimateCost = new int?(-8);
			cardDefaultConfig.Value1 = new int?(1);
			cardDefaultConfig.UpgradedValue1 = new int?(1);
			cardDefaultConfig.Value2 = new int?(5);
			cardDefaultConfig.UpgradedValue2 = new int?(5);
			cardDefaultConfig.Keywords = Keyword.None;
			cardDefaultConfig.RelativeKeyword = Keyword.Exile | Keyword.Ethereal;
			cardDefaultConfig.UpgradedRelativeKeyword = Keyword.Exile | Keyword.Ethereal;
			cardDefaultConfig.RelativeEffects = new List<string> { "Invincible", "TempFirepower" };
			cardDefaultConfig.UpgradedRelativeEffects = new List<string> { "Invincible", "TempFirepower" };
			cardDefaultConfig.RelativeCards = new List<string> { "Xiaozhuo" };
			cardDefaultConfig.UpgradedRelativeCards = new List<string> { "Xiaozhuo" };
			cardDefaultConfig.Illustrator = "Saevin";
			cardDefaultConfig.Index = CardIndexGenerator.GetUniqueIndex(cardDefaultConfig);
			return cardDefaultConfig;
		}
	}
}
