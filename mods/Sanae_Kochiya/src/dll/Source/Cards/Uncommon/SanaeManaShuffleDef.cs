using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using Sanae_Kochiya.Cards.Template;

namespace Sanae_Kochiya.Source.Cards.Uncommon
{
	public sealed class SanaeManaShuffleDef : SampleCharacterCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.Colors = new List<ManaColor>
			{
				ManaColor.White,
				ManaColor.Blue
			};
			cardDefaultConfig.Cost = new ManaGroup
			{
				Any = 2
			};
			cardDefaultConfig.Rarity = Rarity.Uncommon;
			cardDefaultConfig.Type = CardType.Skill;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.Self);
			cardDefaultConfig.Mana = new ManaGroup?(new ManaGroup
			{
				White = 1,
				Colorless = 1
			});
			cardDefaultConfig.UpgradedMana = new ManaGroup?(new ManaGroup
			{
				White = 1,
				Blue = 1,
				Philosophy = 1
			});
			cardDefaultConfig.Keywords = Keyword.Forbidden | Keyword.AutoExile;
			cardDefaultConfig.UpgradedKeywords = Keyword.Forbidden | Keyword.AutoExile;
			cardDefaultConfig.UpgradedRelativeKeyword = Keyword.Philosophy;
			cardDefaultConfig.Illustrator = "";
			cardDefaultConfig.Index = CardIndexGenerator.Initial_offset + 290301;
			return cardDefaultConfig;
		}
	}
}
