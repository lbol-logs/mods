using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using Sanae_Kochiya.Cards.Template;
using Sanae_Kochiya.GunName;

namespace Sanae_Kochiya.Source.Cards.Uncommon
{
	public sealed class SanaeAttackExpelDef : SampleCharacterCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.GunName = GunNameID.GetGunFromId(12210);
			cardDefaultConfig.GunNameBurst = GunNameID.GetGunFromId(12211);
			cardDefaultConfig.Colors = new List<ManaColor>
			{
				ManaColor.Blue,
				ManaColor.Green
			};
			cardDefaultConfig.Cost = new ManaGroup
			{
				Any = 2,
				Blue = 1,
				Green = 1
			};
			cardDefaultConfig.Rarity = Rarity.Uncommon;
			cardDefaultConfig.Type = CardType.Attack;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.AllEnemies);
			cardDefaultConfig.Damage = new int?(19);
			cardDefaultConfig.UpgradedDamage = new int?(25);
			cardDefaultConfig.Value1 = new int?(12);
			cardDefaultConfig.UpgradedValue1 = new int?(15);
			cardDefaultConfig.Keywords = Keyword.Accuracy;
			cardDefaultConfig.UpgradedKeywords = Keyword.Accuracy;
			cardDefaultConfig.RelativeKeyword = Keyword.Power | Keyword.Expel;
			cardDefaultConfig.UpgradedRelativeKeyword = Keyword.Power | Keyword.Expel;
			cardDefaultConfig.Illustrator = "";
			cardDefaultConfig.Index = CardIndexGenerator.Initial_offset + 284101;
			return cardDefaultConfig;
		}
	}
}
