using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using Momiji.Source.GunName;

namespace Momiji.Source.Cards
{
	public sealed class EyeforanEyeDef : SampleCharacterCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.GunName = GunNameID.GetGunFromId(400);
			cardDefaultConfig.Colors = new List<ManaColor> { ManaColor.White };
			cardDefaultConfig.Cost = new ManaGroup
			{
				White = 1
			};
			cardDefaultConfig.UpgradedCost = new ManaGroup?(new ManaGroup
			{
				Any = 1
			});
			cardDefaultConfig.Rarity = Rarity.Common;
			cardDefaultConfig.Type = CardType.Attack;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.SingleEnemy);
			cardDefaultConfig.Damage = new int?(8);
			cardDefaultConfig.UpgradedDamage = new int?(10);
			cardDefaultConfig.Value1 = new int?(4);
			cardDefaultConfig.UpgradedValue1 = new int?(2);
			cardDefaultConfig.Illustrator = "銀朱";
			cardDefaultConfig.Index = CardIndexGenerator.GetUniqueIndex(cardDefaultConfig);
			return cardDefaultConfig;
		}
	}
}
