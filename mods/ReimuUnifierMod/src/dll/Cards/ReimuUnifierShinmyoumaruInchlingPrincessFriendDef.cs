using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using ReimuUnifierMod.Cards.Template;

namespace ReimuUnifierMod.Cards
{
	public sealed class ReimuUnifierShinmyoumaruInchlingPrincessFriendDef : ReimuUnifierCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.Colors = new List<ManaColor> { ManaColor.Colorless };
			cardDefaultConfig.Cost = new ManaGroup
			{
				Any = 2,
				Colorless = 2
			};
			cardDefaultConfig.Rarity = Rarity.Rare;
			cardDefaultConfig.GunName = "封魔针";
			cardDefaultConfig.IsPooled = true;
			cardDefaultConfig.Type = CardType.Friend;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.Nobody);
			cardDefaultConfig.Loyalty = new int?(1);
			cardDefaultConfig.UpgradedLoyalty = new int?(1);
			cardDefaultConfig.ActiveCost = new int?(-3);
			cardDefaultConfig.UpgradedActiveCost = new int?(-3);
			cardDefaultConfig.ActiveCost2 = new int?(-6);
			cardDefaultConfig.UpgradedActiveCost2 = new int?(-6);
			cardDefaultConfig.UltimateCost = new int?(-9);
			cardDefaultConfig.UpgradedUltimateCost = new int?(-9);
			cardDefaultConfig.Mana = new ManaGroup?(ManaGroup.Colorlesses(2));
			cardDefaultConfig.UpgradedMana = new ManaGroup?(ManaGroup.Colorlesses(3));
			cardDefaultConfig.Value1 = new int?(2);
			cardDefaultConfig.UpgradedValue1 = new int?(3);
			cardDefaultConfig.RelativeCards = new List<string> { "ReimuUnifierMercilessRodFriendToken" };
			cardDefaultConfig.UpgradedRelativeCards = new List<string> { "ReimuUnifierMercilessRodFriendToken+" };
			cardDefaultConfig.RelativeEffects = new List<string> { "Firepower" };
			cardDefaultConfig.UpgradedRelativeEffects = new List<string> { "Firepower" };
			cardDefaultConfig.Illustrator = "Saevin";
			cardDefaultConfig.Index = CardIndexGenerator.GetUniqueIndex(cardDefaultConfig);
			return cardDefaultConfig;
		}
	}
}
