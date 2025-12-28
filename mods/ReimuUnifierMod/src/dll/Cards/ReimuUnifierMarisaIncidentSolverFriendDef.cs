using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using ReimuUnifierMod.Cards.Template;

namespace ReimuUnifierMod.Cards
{
	public sealed class ReimuUnifierMarisaIncidentSolverFriendDef : ReimuUnifierCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.Colors = new List<ManaColor> { ManaColor.Red };
			cardDefaultConfig.Cost = new ManaGroup
			{
				Any = 2,
				Red = 3
			};
			cardDefaultConfig.Rarity = Rarity.Rare;
			cardDefaultConfig.GunName = "赤星炸裂";
			cardDefaultConfig.Type = CardType.Friend;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.Nobody);
			cardDefaultConfig.Damage = new int?(18);
			cardDefaultConfig.UpgradedDamage = new int?(24);
			cardDefaultConfig.Loyalty = new int?(4);
			cardDefaultConfig.UpgradedLoyalty = new int?(4);
			cardDefaultConfig.PassiveCost = new int?(1);
			cardDefaultConfig.UpgradedPassiveCost = new int?(1);
			cardDefaultConfig.ActiveCost = new int?(-5);
			cardDefaultConfig.UpgradedActiveCost = new int?(-5);
			cardDefaultConfig.UltimateCost = new int?(-9);
			cardDefaultConfig.UpgradedUltimateCost = new int?(-9);
			cardDefaultConfig.Value1 = new int?(30);
			cardDefaultConfig.UpgradedValue1 = new int?(40);
			cardDefaultConfig.Value2 = new int?(40);
			cardDefaultConfig.UpgradedValue2 = new int?(50);
			cardDefaultConfig.RelativeKeyword = Keyword.Accuracy;
			cardDefaultConfig.UpgradedRelativeKeyword = Keyword.Accuracy;
			cardDefaultConfig.RelativeEffects = new List<string> { "Burst" };
			cardDefaultConfig.UpgradedRelativeEffects = new List<string> { "Burst" };
			cardDefaultConfig.Illustrator = "Saevin";
			cardDefaultConfig.Index = CardIndexGenerator.GetUniqueIndex(cardDefaultConfig);
			return cardDefaultConfig;
		}
	}
}
