using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using Sanae_Kochiya.Cards.Template;
using Sanae_Kochiya.GunName;

namespace Sanae_Kochiya.Source.Cards.Starter
{
	public sealed class SanaeStarterUDef : SampleCharacterCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.GunName = GunNameID.GetGunFromId(810);
			cardDefaultConfig.Colors = new List<ManaColor>
			{
				ManaColor.Blue,
				ManaColor.Green
			};
			cardDefaultConfig.Cost = new ManaGroup
			{
				Blue = 1,
				Hybrid = 1,
				HybridColor = 6
			};
			cardDefaultConfig.Rarity = Rarity.Common;
			cardDefaultConfig.Type = CardType.Attack;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.SingleEnemy);
			cardDefaultConfig.Damage = new int?(8);
			cardDefaultConfig.Value1 = new int?(2);
			cardDefaultConfig.UpgradedValue1 = new int?(3);
			cardDefaultConfig.Value2 = new int?(4);
			cardDefaultConfig.RelativeKeyword = Keyword.Power;
			cardDefaultConfig.UpgradedRelativeKeyword = Keyword.Power;
			cardDefaultConfig.Illustrator = "";
			cardDefaultConfig.Index = CardIndexGenerator.Initial_offset + 92102;
			return cardDefaultConfig;
		}
	}
}
