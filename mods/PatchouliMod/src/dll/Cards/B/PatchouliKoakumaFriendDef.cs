using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using PatchouliCharacterMod.Cards.Template;
using PatchouliCharacterMod.Illustrator;

namespace PatchouliCharacterMod.Cards.B
{
	public sealed class PatchouliKoakumaFriendDef : PatchouliCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.IsPooled = true;
			cardDefaultConfig.Index = 6100;
			cardDefaultConfig.Colors = new List<ManaColor>
			{
				ManaColor.Black,
				ManaColor.Red
			};
			cardDefaultConfig.Cost = new ManaGroup
			{
				Black = 1,
				Red = 1
			};
			cardDefaultConfig.Rarity = Rarity.Uncommon;
			cardDefaultConfig.Owner = this.OwnerName;
			cardDefaultConfig.Type = CardType.Friend;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.Nobody);
			cardDefaultConfig.Loyalty = new int?(4);
			cardDefaultConfig.UpgradedLoyalty = new int?(4);
			cardDefaultConfig.PassiveCost = new int?(1);
			cardDefaultConfig.UpgradedPassiveCost = new int?(2);
			cardDefaultConfig.ActiveCost = new int?(-4);
			cardDefaultConfig.UpgradedActiveCost = new int?(-4);
			cardDefaultConfig.UltimateCost = new int?(-8);
			cardDefaultConfig.UpgradedUltimateCost = new int?(-8);
			cardDefaultConfig.Value1 = new int?(1);
			cardDefaultConfig.Value2 = new int?(1);
			cardDefaultConfig.RelativeCards = new List<string> { "BManaCard" };
			cardDefaultConfig.UpgradedRelativeCards = new List<string> { "PManaCard" };
			cardDefaultConfig.RelativeEffects = new List<string> { "PatchouliSignKeywordSe", "PatchouliFireSignSe" };
			cardDefaultConfig.UpgradedRelativeEffects = new List<string> { "PatchouliSignKeywordSe", "PatchouliFireSignSe" };
			cardDefaultConfig.Illustrator = PatchouliIllustrator.PatchouliKoakumaFriend;
			return cardDefaultConfig;
		}
	}
}
