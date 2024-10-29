using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using Sanae_Kochiya.Cards.Template;

namespace Sanae_Kochiya.Source.Cards.Offcolor
{
	public sealed class SanaePowerOmikujiDef : SampleCharacterCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.Colors = new List<ManaColor> { ManaColor.Red };
			cardDefaultConfig.Cost = new ManaGroup
			{
				Red = 1
			};
			cardDefaultConfig.Rarity = Rarity.Rare;
			cardDefaultConfig.Type = CardType.Skill;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.Self);
			cardDefaultConfig.Value1 = new int?(20);
			cardDefaultConfig.UpgradedValue1 = new int?(10);
			cardDefaultConfig.Value2 = new int?(20);
			cardDefaultConfig.RelativeKeyword = Keyword.Power;
			cardDefaultConfig.UpgradedRelativeKeyword = Keyword.Power;
			cardDefaultConfig.Illustrator = "";
			cardDefaultConfig.Index = CardIndexGenerator.Initial_offset + 463301;
			return cardDefaultConfig;
		}
	}
}
