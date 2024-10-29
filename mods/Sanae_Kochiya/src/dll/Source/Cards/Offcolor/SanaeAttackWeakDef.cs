using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using Sanae_Kochiya.Cards.Template;
using Sanae_Kochiya.GunName;

namespace Sanae_Kochiya.Source.Cards.Offcolor
{
	public sealed class SanaeAttackWeakDef : SampleCharacterCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.GunName = GunNameID.GetGunFromId(20041);
			cardDefaultConfig.Colors = new List<ManaColor>
			{
				ManaColor.Blue,
				ManaColor.Red
			};
			cardDefaultConfig.Cost = new ManaGroup
			{
				Blue = 1,
				Red = 1
			};
			cardDefaultConfig.Rarity = Rarity.Uncommon;
			cardDefaultConfig.Type = CardType.Attack;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.SingleEnemy);
			cardDefaultConfig.Damage = new int?(25);
			cardDefaultConfig.UpgradedDamage = new int?(36);
			cardDefaultConfig.Value1 = new int?(2);
			cardDefaultConfig.UpgradedValue1 = new int?(3);
			cardDefaultConfig.RelativeEffects = new List<string> { "Weak" };
			cardDefaultConfig.UpgradedRelativeEffects = new List<string> { "Weak" };
			cardDefaultConfig.Illustrator = "";
			cardDefaultConfig.Index = CardIndexGenerator.Initial_offset + 482101;
			return cardDefaultConfig;
		}
	}
}
