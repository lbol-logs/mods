using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using Sanae_Kochiya.Cards.Template;
using Sanae_Kochiya.GunName;

namespace Sanae_Kochiya.Source.Cards.Offcolor
{
	public sealed class SanaeKanakoFriendDef : SampleCharacterCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.GunName = GunNameID.GetGunFromId(7340);
			cardDefaultConfig.GunNameBurst = GunNameID.GetGunFromId(7341);
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
			cardDefaultConfig.TargetType = new TargetType?(TargetType.Self);
			cardDefaultConfig.Damage = new int?(10);
			cardDefaultConfig.UpgradedDamage = new int?(14);
			cardDefaultConfig.Shield = new int?(12);
			cardDefaultConfig.Value1 = new int?(2);
			cardDefaultConfig.Value2 = new int?(25);
			cardDefaultConfig.UpgradedValue2 = new int?(30);
			cardDefaultConfig.Loyalty = new int?(2);
			cardDefaultConfig.PassiveCost = new int?(1);
			cardDefaultConfig.UpgradedPassiveCost = new int?(2);
			cardDefaultConfig.ActiveCost = new int?(-3);
			cardDefaultConfig.UltimateCost = new int?(-8);
			cardDefaultConfig.RelativeKeyword = Keyword.Shield | Keyword.Power;
			cardDefaultConfig.UpgradedRelativeKeyword = Keyword.Shield | Keyword.Power;
			cardDefaultConfig.RelativeEffects = new List<string> { "Graze", "Firepower" };
			cardDefaultConfig.UpgradedRelativeEffects = new List<string> { "Graze", "Firepower" };
			cardDefaultConfig.Illustrator = "";
			cardDefaultConfig.Index = CardIndexGenerator.Initial_offset + 494501;
			return cardDefaultConfig;
		}
	}
}
