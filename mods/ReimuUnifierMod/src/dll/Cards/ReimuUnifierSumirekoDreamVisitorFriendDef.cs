using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using ReimuUnifierMod.Cards.Template;

namespace ReimuUnifierMod.Cards
{
	public sealed class ReimuUnifierSumirekoDreamVisitorFriendDef : ReimuUnifierCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.Colors = new List<ManaColor> { ManaColor.Blue };
			cardDefaultConfig.Cost = new ManaGroup
			{
				Any = 2,
				Blue = 1
			};
			cardDefaultConfig.UpgradedCost = new ManaGroup?(new ManaGroup
			{
				Any = 2,
				Blue = 1
			});
			cardDefaultConfig.Rarity = Rarity.Uncommon;
			cardDefaultConfig.Type = CardType.Friend;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.Nobody);
			cardDefaultConfig.Damage = new int?(10);
			cardDefaultConfig.UpgradedDamage = new int?(14);
			cardDefaultConfig.Mana = new ManaGroup?(ManaGroup.Blacks(1));
			cardDefaultConfig.Loyalty = new int?(9);
			cardDefaultConfig.UpgradedLoyalty = new int?(9);
			cardDefaultConfig.PassiveCost = new int?(0);
			cardDefaultConfig.UpgradedPassiveCost = new int?(0);
			cardDefaultConfig.ActiveCost = new int?(-3);
			cardDefaultConfig.UpgradedActiveCost = new int?(-3);
			cardDefaultConfig.ActiveCost2 = new int?(-6);
			cardDefaultConfig.UpgradedActiveCost2 = new int?(-6);
			cardDefaultConfig.UltimateCost = new int?(0);
			cardDefaultConfig.UpgradedUltimateCost = new int?(0);
			cardDefaultConfig.Value1 = new int?(1);
			cardDefaultConfig.UpgradedValue1 = new int?(1);
			cardDefaultConfig.Value2 = new int?(5);
			cardDefaultConfig.UpgradedValue2 = new int?(5);
			cardDefaultConfig.Keywords = Keyword.None;
			cardDefaultConfig.RelativeEffects = new List<string>();
			cardDefaultConfig.Illustrator = "Saevin";
			cardDefaultConfig.Index = CardIndexGenerator.GetUniqueIndex(cardDefaultConfig);
			return cardDefaultConfig;
		}
	}
}
