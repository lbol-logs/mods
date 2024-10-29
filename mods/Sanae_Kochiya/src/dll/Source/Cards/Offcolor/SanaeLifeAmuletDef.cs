using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using Sanae_Kochiya.Cards.Template;

namespace Sanae_Kochiya.Source.Cards.Offcolor
{
	public sealed class SanaeLifeAmuletDef : SampleCharacterCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.Colors = new List<ManaColor> { ManaColor.Black };
			cardDefaultConfig.Cost = new ManaGroup
			{
				Any = 1,
				Black = 1
			};
			cardDefaultConfig.Rarity = Rarity.Uncommon;
			cardDefaultConfig.Type = CardType.Defense;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.Self);
			cardDefaultConfig.Shield = new int?(15);
			cardDefaultConfig.UpgradedShield = new int?(25);
			cardDefaultConfig.Value1 = new int?(3);
			cardDefaultConfig.UpgradedValue1 = new int?(2);
			cardDefaultConfig.Value2 = new int?(1);
			cardDefaultConfig.RelativeKeyword = Keyword.Shield;
			cardDefaultConfig.UpgradedRelativeKeyword = Keyword.Shield;
			cardDefaultConfig.RelativeEffects = new List<string> { "Amulet" };
			cardDefaultConfig.UpgradedRelativeEffects = new List<string> { "Amulet" };
			cardDefaultConfig.Illustrator = "";
			cardDefaultConfig.Index = CardIndexGenerator.Initial_offset + 402201;
			return cardDefaultConfig;
		}
	}
}
