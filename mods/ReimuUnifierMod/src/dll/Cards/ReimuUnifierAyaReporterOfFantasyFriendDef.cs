using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using ReimuUnifierMod.Cards.Template;

namespace ReimuUnifierMod.Cards
{
	public sealed class ReimuUnifierAyaReporterOfFantasyFriendDef : ReimuUnifierCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.Colors = new List<ManaColor>
			{
				ManaColor.Red,
				ManaColor.Green
			};
			cardDefaultConfig.Cost = new ManaGroup
			{
				Any = 2,
				Red = 1,
				Green = 1
			};
			cardDefaultConfig.Rarity = Rarity.Rare;
			cardDefaultConfig.Type = CardType.Friend;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.Nobody);
			cardDefaultConfig.Loyalty = new int?(2);
			cardDefaultConfig.UpgradedLoyalty = new int?(3);
			cardDefaultConfig.PassiveCost = new int?(1);
			cardDefaultConfig.UpgradedPassiveCost = new int?(1);
			cardDefaultConfig.ActiveCost = new int?(-3);
			cardDefaultConfig.UpgradedActiveCost = new int?(-3);
			cardDefaultConfig.UltimateCost = new int?(-9);
			cardDefaultConfig.UpgradedUltimateCost = new int?(-9);
			cardDefaultConfig.Value1 = new int?(1);
			cardDefaultConfig.UpgradedValue1 = new int?(2);
			cardDefaultConfig.Value2 = new int?(10);
			cardDefaultConfig.UpgradedValue2 = new int?(15);
			cardDefaultConfig.Mana = new ManaGroup?(ManaGroup.Anys(1));
			cardDefaultConfig.UpgradedMana = new ManaGroup?(ManaGroup.Anys(2));
			cardDefaultConfig.RelativeKeyword = Keyword.Exile | Keyword.Replenish | Keyword.AutoExile;
			cardDefaultConfig.UpgradedRelativeKeyword = Keyword.Exile | Keyword.Replenish | Keyword.AutoExile;
			cardDefaultConfig.RelativeEffects = new List<string> { "Graze" };
			cardDefaultConfig.UpgradedRelativeEffects = new List<string> { "Graze" };
			cardDefaultConfig.RelativeCards = new List<string> { "AyaNews" };
			cardDefaultConfig.UpgradedRelativeCards = new List<string> { "AyaNews" };
			cardDefaultConfig.Illustrator = "Saevin";
			cardDefaultConfig.Index = CardIndexGenerator.GetUniqueIndex(cardDefaultConfig);
			return cardDefaultConfig;
		}
	}
}
