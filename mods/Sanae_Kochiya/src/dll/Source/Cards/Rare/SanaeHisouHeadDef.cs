using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using Sanae_Kochiya.Cards.Template;

namespace Sanae_Kochiya.Source.Cards.Rare
{
	public sealed class SanaeHisouHeadDef : SampleCharacterCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.Colors = new List<ManaColor>
			{
				ManaColor.Blue,
				ManaColor.Green
			};
			cardDefaultConfig.Cost = new ManaGroup
			{
				Any = 5,
				Blue = 1,
				Green = 1
			};
			cardDefaultConfig.Rarity = Rarity.Rare;
			cardDefaultConfig.Type = CardType.Skill;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.Self);
			cardDefaultConfig.Value1 = new int?(4);
			cardDefaultConfig.Mana = new ManaGroup?(new ManaGroup
			{
				Colorless = 1
			});
			cardDefaultConfig.Keywords = Keyword.Plentiful;
			cardDefaultConfig.UpgradedKeywords = Keyword.Plentiful;
			cardDefaultConfig.RelativeCards = new List<string> { "SanaeHisouRightArm", "SanaeHisouLeftArm", "SanaeHisouRightLeg", "SanaeHisouLeftLeg" };
			cardDefaultConfig.UpgradedRelativeCards = new List<string> { "SanaeHisouRightArm", "SanaeHisouLeftArm", "SanaeHisouRightLeg", "SanaeHisouLeftLeg" };
			cardDefaultConfig.Illustrator = "";
			cardDefaultConfig.Index = CardIndexGenerator.Initial_offset + 387301;
			return cardDefaultConfig;
		}
	}
}
