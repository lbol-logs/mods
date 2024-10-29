using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using PatchouliCharacterMod.Cards.Template;
using PatchouliCharacterMod.Illustrator;

namespace PatchouliCharacterMod.Cards.B
{
	public sealed class PatchouliSakuyaFriendDef : PatchouliCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.HideMesuem = true;
			cardDefaultConfig.IsPooled = false;
			cardDefaultConfig.Index = 6010;
			cardDefaultConfig.Colors = new List<ManaColor>
			{
				ManaColor.White,
				ManaColor.Blue,
				ManaColor.Black
			};
			cardDefaultConfig.Cost = new ManaGroup
			{
				White = 1,
				Blue = 1,
				Black = 1
			};
			cardDefaultConfig.Rarity = Rarity.Rare;
			cardDefaultConfig.Owner = this.OwnerName;
			cardDefaultConfig.Type = CardType.Friend;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.Nobody);
			cardDefaultConfig.Loyalty = new int?(3);
			cardDefaultConfig.UpgradedLoyalty = new int?(3);
			cardDefaultConfig.PassiveCost = new int?(1);
			cardDefaultConfig.UpgradedPassiveCost = new int?(2);
			cardDefaultConfig.ActiveCost = new int?(-3);
			cardDefaultConfig.UpgradedActiveCost = new int?(-3);
			cardDefaultConfig.UltimateCost = new int?(-7);
			cardDefaultConfig.UpgradedUltimateCost = new int?(-7);
			cardDefaultConfig.Value1 = new int?(1);
			cardDefaultConfig.Value2 = new int?(1);
			cardDefaultConfig.RelativeCards = new List<string> { "Knife" };
			cardDefaultConfig.UpgradedRelativeCards = new List<string> { "Knife" };
			cardDefaultConfig.RelativeEffects = new List<string> { "Graze" };
			cardDefaultConfig.UpgradedRelativeEffects = new List<string> { "Graze" };
			cardDefaultConfig.Illustrator = PatchouliIllustrator.PatchouliSakuyaFriend;
			return cardDefaultConfig;
		}
	}
}
