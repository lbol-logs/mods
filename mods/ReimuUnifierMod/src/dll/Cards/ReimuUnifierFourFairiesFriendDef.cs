using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using LBoLEntitySideloader.Resource;
using ReimuUnifierMod.Cards.Template;

namespace ReimuUnifierMod.Cards
{
	public sealed class ReimuUnifierFourFairiesFriendDef : ReimuUnifierCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.Colors = new List<ManaColor> { ManaColor.White };
			cardDefaultConfig.Cost = new ManaGroup
			{
				Any = 2,
				White = 1
			};
			cardDefaultConfig.Rarity = Rarity.Uncommon;
			cardDefaultConfig.GunName = "ShootR";
			cardDefaultConfig.IsPooled = true;
			cardDefaultConfig.Type = CardType.Friend;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.Nobody);
			cardDefaultConfig.Loyalty = new int?(1);
			cardDefaultConfig.UpgradedLoyalty = new int?(2);
			cardDefaultConfig.PassiveCost = new int?(1);
			cardDefaultConfig.UpgradedPassiveCost = new int?(1);
			cardDefaultConfig.ActiveCost = new int?(-3);
			cardDefaultConfig.UpgradedActiveCost = new int?(-3);
			cardDefaultConfig.UltimateCost = new int?(-8);
			cardDefaultConfig.UpgradedUltimateCost = new int?(-8);
			cardDefaultConfig.Damage = new int?(3);
			cardDefaultConfig.UpgradedDamage = new int?(3);
			cardDefaultConfig.Value1 = new int?(3);
			cardDefaultConfig.UpgradedValue1 = new int?(4);
			cardDefaultConfig.RelativeCards = new List<string> { "LunaFriend", "StarFriend", "SunnyFriend" };
			cardDefaultConfig.UpgradedRelativeCards = new List<string> { "LunaFriend", "StarFriend", "SunnyFriend", "ClownpieceFriend" };
			cardDefaultConfig.ImageId = "ReimuUnifierFourFairiesFriend";
			cardDefaultConfig.UpgradeImageId = "ReimuUnifierFourFairiesFriend" + "Upgrade";
			cardDefaultConfig.Illustrator = "Saevin";
			cardDefaultConfig.Index = CardIndexGenerator.GetUniqueIndex(cardDefaultConfig);
			return cardDefaultConfig;
		}

		public override CardImages LoadCardImages()
		{
			CardImages cardImages = new CardImages(BepinexPlugin.embeddedSource);
			cardImages.AutoLoad(this, ".png", "", true);
			return cardImages;
		}
	}
}
