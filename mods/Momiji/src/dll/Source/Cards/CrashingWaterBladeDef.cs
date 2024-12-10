using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using Momiji.Source.GunName;

namespace Momiji.Source.Cards
{
	public sealed class CrashingWaterBladeDef : SampleCharacterCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.GunName = GunNameID.GetGunFromId(400);
			cardDefaultConfig.Colors = new List<ManaColor> { ManaColor.Blue };
			cardDefaultConfig.Cost = new ManaGroup
			{
				Any = 2,
				Blue = 1
			};
			cardDefaultConfig.UpgradedCost = new ManaGroup?(new ManaGroup
			{
				Any = 1,
				Blue = 1
			});
			cardDefaultConfig.Rarity = Rarity.Uncommon;
			cardDefaultConfig.Type = CardType.Attack;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.SingleEnemy);
			cardDefaultConfig.Damage = new int?(15);
			cardDefaultConfig.UpgradedDamage = new int?(15);
			cardDefaultConfig.Value1 = new int?(10);
			cardDefaultConfig.UpgradedValue1 = new int?(8);
			cardDefaultConfig.RelativeEffects = new List<string> { "Reflect" };
			cardDefaultConfig.UpgradedRelativeEffects = new List<string> { "Reflect" };
			cardDefaultConfig.Illustrator = "ASMODEUS";
			cardDefaultConfig.Index = CardIndexGenerator.GetUniqueIndex(cardDefaultConfig);
			return cardDefaultConfig;
		}
	}
}
