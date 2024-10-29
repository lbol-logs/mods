using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using Sanae_Kochiya.Cards.Template;
using Sanae_Kochiya.GunName;

namespace Sanae_Kochiya.Source.Cards.Starter
{
	public sealed class SanaeStarterWDef : SampleCharacterCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.GunName = GunNameID.GetGunFromId(11230);
			cardDefaultConfig.Colors = new List<ManaColor>
			{
				ManaColor.White,
				ManaColor.Green
			};
			cardDefaultConfig.Cost = new ManaGroup
			{
				White = 1,
				Hybrid = 1,
				HybridColor = 3
			};
			cardDefaultConfig.Rarity = Rarity.Common;
			cardDefaultConfig.Type = CardType.Attack;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.SingleEnemy);
			cardDefaultConfig.Damage = new int?(11);
			cardDefaultConfig.UpgradedDamage = new int?(16);
			cardDefaultConfig.Value1 = new int?(9);
			cardDefaultConfig.UpgradedValue1 = new int?(13);
			cardDefaultConfig.Value2 = new int?(2);
			cardDefaultConfig.RelativeCards = new List<string> { "Xuanguang" };
			cardDefaultConfig.UpgradedRelativeCards = new List<string> { "Xuanguang" };
			cardDefaultConfig.Illustrator = "";
			cardDefaultConfig.Index = CardIndexGenerator.Initial_offset + 92101;
			return cardDefaultConfig;
		}
	}
}
