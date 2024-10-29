using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using YoumuCharacterMod.Cards.Template;
using YoumuCharacterMod.Illustrator;

namespace YoumuCharacterMod.Cards
{
	public sealed class YoumuYuyukoFriendDef : YoumuCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.IsPooled = true;
			cardDefaultConfig.Index = 4500;
			cardDefaultConfig.Colors = new List<ManaColor>
			{
				ManaColor.Green,
				ManaColor.White,
				ManaColor.Black
			};
			cardDefaultConfig.Cost = new ManaGroup
			{
				White = 1,
				Black = 1,
				Green = 1
			};
			cardDefaultConfig.Rarity = Rarity.Rare;
			cardDefaultConfig.Owner = this.OwnerName;
			cardDefaultConfig.Type = CardType.Friend;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.Nobody);
			cardDefaultConfig.Loyalty = new int?(4);
			cardDefaultConfig.UpgradedLoyalty = new int?(4);
			cardDefaultConfig.PassiveCost = new int?(2);
			cardDefaultConfig.UpgradedPassiveCost = new int?(2);
			cardDefaultConfig.ActiveCost = new int?(-3);
			cardDefaultConfig.UpgradedActiveCost = new int?(-3);
			cardDefaultConfig.UltimateCost = new int?(-8);
			cardDefaultConfig.UpgradedUltimateCost = new int?(-8);
			cardDefaultConfig.Value1 = new int?(6);
			cardDefaultConfig.UpgradedValue1 = new int?(8);
			cardDefaultConfig.Value2 = new int?(3);
			cardDefaultConfig.Mana = new ManaGroup?(new ManaGroup
			{
				Green = 1,
				Black = 1
			});
			cardDefaultConfig.Keywords = Keyword.None;
			cardDefaultConfig.RelativeEffects = new List<string>();
			cardDefaultConfig.RelativeCards = new List<string>();
			cardDefaultConfig.UpgradedRelativeCards = new List<string>();
			cardDefaultConfig.RelativeEffects = new List<string> { "Weak", "Vulnerable", "YoumuYuyukoDeathSe" };
			cardDefaultConfig.UpgradedRelativeEffects = new List<string> { "Weak", "Vulnerable", "YoumuYuyukoDeathSe" };
			cardDefaultConfig.Illustrator = YoumuIllustrator.YuyukoFriend;
			return cardDefaultConfig;
		}
	}
}
