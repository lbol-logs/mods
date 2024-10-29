using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using Sanae_Kochiya.Cards.Template;

namespace Sanae_Kochiya.Source.Cards.Rare
{
	public sealed class SanaeExileDamageDef : SampleCharacterCardTemplate
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
				White = 1,
				Blue = 1
			};
			cardDefaultConfig.Rarity = Rarity.Rare;
			cardDefaultConfig.Type = CardType.Ability;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.Self);
			cardDefaultConfig.Value1 = new int?(7);
			cardDefaultConfig.UpgradedValue1 = new int?(9);
			cardDefaultConfig.Value2 = new int?(2);
			cardDefaultConfig.RelativeKeyword = Keyword.AutoExile;
			cardDefaultConfig.UpgradedRelativeKeyword = Keyword.AutoExile;
			cardDefaultConfig.RelativeEffects = new List<string> { "AmuletForCard" };
			cardDefaultConfig.UpgradedRelativeEffects = new List<string> { "AmuletForCard" };
			cardDefaultConfig.UpgradedRelativeCards = new List<string> { "SanaeStatus" };
			cardDefaultConfig.Illustrator = "";
			cardDefaultConfig.Index = CardIndexGenerator.Initial_offset + 392401;
			return cardDefaultConfig;
		}
	}
}
