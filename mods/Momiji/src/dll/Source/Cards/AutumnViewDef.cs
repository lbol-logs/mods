using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;

namespace Momiji.Source.Cards
{
	public sealed class AutumnViewDef : SampleCharacterCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.Colors = new List<ManaColor>
			{
				ManaColor.White,
				ManaColor.Red
			};
			cardDefaultConfig.Cost = default(ManaGroup);
			cardDefaultConfig.UpgradedCost = new ManaGroup?(default(ManaGroup));
			cardDefaultConfig.Rarity = Rarity.Rare;
			cardDefaultConfig.Type = CardType.Skill;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.Nobody);
			cardDefaultConfig.Value1 = new int?(12);
			cardDefaultConfig.UpgradedValue1 = new int?(12);
			cardDefaultConfig.UpgradedValue2 = new int?(1);
			cardDefaultConfig.Keywords = Keyword.Block | Keyword.Forbidden | Keyword.Replenish | Keyword.AutoExile;
			cardDefaultConfig.UpgradedKeywords = Keyword.Shield | Keyword.Forbidden | Keyword.Replenish | Keyword.AutoExile;
			cardDefaultConfig.Illustrator = "半节";
			cardDefaultConfig.Index = CardIndexGenerator.GetUniqueIndex(cardDefaultConfig);
			return cardDefaultConfig;
		}
	}
}
