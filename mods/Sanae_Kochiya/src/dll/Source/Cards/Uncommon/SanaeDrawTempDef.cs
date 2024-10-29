using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using Sanae_Kochiya.Cards.Template;

namespace Sanae_Kochiya.Source.Cards.Uncommon
{
	public sealed class SanaeDrawTempDef : SampleCharacterCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.Colors = new List<ManaColor> { ManaColor.Blue };
			cardDefaultConfig.Cost = new ManaGroup
			{
				Blue = 2
			};
			cardDefaultConfig.Rarity = Rarity.Uncommon;
			cardDefaultConfig.Type = CardType.Ability;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.Self);
			cardDefaultConfig.Value1 = new int?(2);
			cardDefaultConfig.Keywords = Keyword.None;
			cardDefaultConfig.UpgradedKeywords = Keyword.Initial;
			cardDefaultConfig.Illustrator = "";
			cardDefaultConfig.Index = CardIndexGenerator.GetUniqueIndex(cardDefaultConfig);
			return cardDefaultConfig;
		}
	}
}
