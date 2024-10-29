using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using Sanae_Kochiya.Cards.Template;

namespace Sanae_Kochiya.Source.Cards.Uncommon
{
	public sealed class SanaeUpgradeWardDef : SampleCharacterCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.Colors = new List<ManaColor> { ManaColor.White };
			cardDefaultConfig.Cost = new ManaGroup
			{
				Any = 1,
				White = 1
			};
			cardDefaultConfig.Rarity = Rarity.Uncommon;
			cardDefaultConfig.Type = CardType.Skill;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.Self);
			cardDefaultConfig.Value1 = new int?(3);
			cardDefaultConfig.UpgradedValue1 = new int?(5);
			cardDefaultConfig.Value2 = new int?(5);
			cardDefaultConfig.UpgradedValue2 = new int?(7);
			cardDefaultConfig.Mana = new ManaGroup?(new ManaGroup
			{
				White = 1
			});
			cardDefaultConfig.Keywords = Keyword.Plentiful;
			cardDefaultConfig.UpgradedKeywords = Keyword.Plentiful;
			cardDefaultConfig.RelativeKeyword = Keyword.Upgrade;
			cardDefaultConfig.UpgradedRelativeKeyword = Keyword.Upgrade;
			cardDefaultConfig.RelativeEffects = new List<string> { "AmuletForCard" };
			cardDefaultConfig.UpgradedRelativeEffects = new List<string> { "AmuletForCard" };
			cardDefaultConfig.Illustrator = "";
			cardDefaultConfig.Index = CardIndexGenerator.GetUniqueIndex(cardDefaultConfig);
			return cardDefaultConfig;
		}
	}
}
