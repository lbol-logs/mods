using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using Sanae_Kochiya.Cards.Template;

namespace Sanae_Kochiya.Source.Cards.Rare
{
	public sealed class SanaeExilePowerDef : SampleCharacterCardTemplate
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
				Blue = 1,
				Green = 1
			};
			cardDefaultConfig.IsXCost = true;
			cardDefaultConfig.Rarity = Rarity.Rare;
			cardDefaultConfig.Type = CardType.Defense;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.Self);
			cardDefaultConfig.Shield = new int?(12);
			cardDefaultConfig.UpgradedShield = new int?(16);
			cardDefaultConfig.Value1 = new int?(2);
			cardDefaultConfig.Keywords = Keyword.Exile;
			cardDefaultConfig.UpgradedKeywords = Keyword.Exile;
			cardDefaultConfig.RelativeKeyword = Keyword.Shield;
			cardDefaultConfig.UpgradedRelativeKeyword = Keyword.Shield;
			cardDefaultConfig.UpgradedRelativeCards = new List<string> { "SanaeStatus" };
			cardDefaultConfig.Illustrator = "";
			cardDefaultConfig.Index = CardIndexGenerator.Initial_offset + 389201;
			return cardDefaultConfig;
		}
	}
}
