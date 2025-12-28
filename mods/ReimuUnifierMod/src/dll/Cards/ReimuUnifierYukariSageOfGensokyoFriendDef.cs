using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using ReimuUnifierMod.Cards.Template;

namespace ReimuUnifierMod.Cards
{
	public sealed class ReimuUnifierYukariSageOfGensokyoFriendDef : ReimuUnifierCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.Colors = new List<ManaColor> { ManaColor.White };
			cardDefaultConfig.Cost = new ManaGroup
			{
				Any = 2,
				White = 3
			};
			cardDefaultConfig.Rarity = Rarity.Rare;
			cardDefaultConfig.GunName = "扩散结界";
			cardDefaultConfig.Type = CardType.Friend;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.Nobody);
			cardDefaultConfig.Damage = new int?(8);
			cardDefaultConfig.UpgradedDamage = new int?(10);
			cardDefaultConfig.Value2 = new int?(8);
			cardDefaultConfig.UpgradedValue2 = new int?(10);
			cardDefaultConfig.Loyalty = new int?(5);
			cardDefaultConfig.UpgradedLoyalty = new int?(5);
			cardDefaultConfig.PassiveCost = new int?(1);
			cardDefaultConfig.UpgradedPassiveCost = new int?(1);
			cardDefaultConfig.ActiveCost = new int?(-5);
			cardDefaultConfig.UpgradedActiveCost = new int?(-4);
			cardDefaultConfig.UltimateCost = new int?(-9);
			cardDefaultConfig.UpgradedUltimateCost = new int?(-9);
			cardDefaultConfig.Value1 = new int?(15);
			cardDefaultConfig.UpgradedValue1 = new int?(20);
			cardDefaultConfig.RelativeKeyword = Keyword.Block | Keyword.Shield;
			cardDefaultConfig.UpgradedRelativeKeyword = Keyword.Block | Keyword.Shield;
			cardDefaultConfig.Illustrator = "Saevin";
			cardDefaultConfig.Index = CardIndexGenerator.GetUniqueIndex(cardDefaultConfig);
			return cardDefaultConfig;
		}
	}
}
