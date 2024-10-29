using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using Sanae_Kochiya.Cards.Template;

namespace Sanae_Kochiya.Source.Cards.Uncommon
{
	public sealed class SanaeBlockRebuffDef : SampleCharacterCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.Colors = new List<ManaColor> { ManaColor.Blue };
			cardDefaultConfig.Cost = new ManaGroup
			{
				Any = 3,
				Blue = 1
			};
			cardDefaultConfig.Rarity = Rarity.Uncommon;
			cardDefaultConfig.Type = CardType.Defense;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.Self);
			cardDefaultConfig.Block = new int?(11);
			cardDefaultConfig.UpgradedBlock = new int?(16);
			cardDefaultConfig.Shield = new int?(11);
			cardDefaultConfig.UpgradedShield = new int?(16);
			cardDefaultConfig.Value1 = new int?(1);
			cardDefaultConfig.Value2 = new int?(2);
			cardDefaultConfig.RelativeKeyword = Keyword.Block | Keyword.Shield;
			cardDefaultConfig.UpgradedRelativeKeyword = Keyword.Block | Keyword.Shield;
			cardDefaultConfig.RelativeEffects = new List<string> { "Amulet", "Weak" };
			cardDefaultConfig.UpgradedRelativeEffects = new List<string> { "Amulet", "Weak" };
			cardDefaultConfig.Illustrator = "";
			cardDefaultConfig.Index = CardIndexGenerator.GetUniqueIndex(cardDefaultConfig);
			return cardDefaultConfig;
		}
	}
}
