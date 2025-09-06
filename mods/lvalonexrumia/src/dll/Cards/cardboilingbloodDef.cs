using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using lvalonexrumia.Cards.Template;
using lvalonexrumia.GunName;

namespace lvalonexrumia.Cards
{
	public sealed class cardboilingbloodDef : lvalonexrumiaCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.Colors = new List<ManaColor> { ManaColor.Red };
			cardDefaultConfig.Cost = new ManaGroup
			{
				Red = 1
			};
			cardDefaultConfig.Rarity = Rarity.Common;
			cardDefaultConfig.Type = CardType.Attack;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.All);
			cardDefaultConfig.GunName = GunNameID.GetGunFromId(23051);
			cardDefaultConfig.GunNameBurst = GunNameID.GetGunFromId(23052);
			cardDefaultConfig.Damage = new int?(5);
			cardDefaultConfig.Value1 = new int?(5);
			cardDefaultConfig.Value2 = new int?(30);
			cardDefaultConfig.UpgradedValue2 = new int?(40);
			cardDefaultConfig.RelativeEffects = new List<string> { "sedecrease", "sebleed", "seatkincrease" };
			cardDefaultConfig.UpgradedRelativeEffects = new List<string> { "sedecrease", "sebleed", "seatkincrease" };
			cardDefaultConfig.Illustrator = "Yuki Nanami";
			cardDefaultConfig.Index = CardIndexGenerator.GetUniqueIndex(cardDefaultConfig);
			return cardDefaultConfig;
		}
	}
}
