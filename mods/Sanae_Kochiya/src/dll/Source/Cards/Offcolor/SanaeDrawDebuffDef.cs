using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using Sanae_Kochiya.Cards.Template;

namespace Sanae_Kochiya.Source.Cards.Offcolor
{
	public sealed class SanaeDrawDebuffDef : SampleCharacterCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.Colors = new List<ManaColor> { ManaColor.Red };
			cardDefaultConfig.Cost = new ManaGroup
			{
				Any = 3
			};
			cardDefaultConfig.Rarity = Rarity.Uncommon;
			cardDefaultConfig.Type = CardType.Skill;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.Self);
			cardDefaultConfig.Value1 = new int?(1);
			cardDefaultConfig.Value2 = new int?(5);
			cardDefaultConfig.UpgradedValue2 = new int?(2);
			cardDefaultConfig.Mana = new ManaGroup?(new ManaGroup
			{
				Colorless = 1
			});
			cardDefaultConfig.Keywords = Keyword.Forbidden | Keyword.AutoExile;
			cardDefaultConfig.UpgradedKeywords = Keyword.Forbidden | Keyword.AutoExile;
			cardDefaultConfig.Illustrator = "";
			cardDefaultConfig.Index = CardIndexGenerator.Initial_offset + 450301;
			return cardDefaultConfig;
		}
	}
}
