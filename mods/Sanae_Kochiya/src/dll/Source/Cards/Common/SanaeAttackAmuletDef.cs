using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using Sanae_Kochiya.Cards.Template;
using Sanae_Kochiya.GunName;

namespace Sanae_Kochiya.Source.Cards.Common
{
	public sealed class SanaeAttackAmuletDef : SampleCharacterCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.GunName = GunNameID.GetGunFromId(22010);
			cardDefaultConfig.GunNameBurst = GunNameID.GetGunFromId(22011);
			cardDefaultConfig.Colors = new List<ManaColor>
			{
				ManaColor.Blue,
				ManaColor.Green
			};
			cardDefaultConfig.Cost = new ManaGroup
			{
				Any = 1,
				Hybrid = 1,
				HybridColor = 6
			};
			cardDefaultConfig.Rarity = Rarity.Common;
			cardDefaultConfig.Type = CardType.Attack;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.SingleEnemy);
			cardDefaultConfig.Damage = new int?(13);
			cardDefaultConfig.UpgradedDamage = new int?(18);
			cardDefaultConfig.Value1 = new int?(1);
			cardDefaultConfig.UpgradedKeywords = Keyword.Accuracy;
			cardDefaultConfig.RelativeEffects = new List<string> { "Amulet" };
			cardDefaultConfig.UpgradedRelativeEffects = new List<string> { "Amulet" };
			cardDefaultConfig.Illustrator = "";
			cardDefaultConfig.Index = CardIndexGenerator.Initial_offset + 182101;
			return cardDefaultConfig;
		}
	}
}
