using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using lvalonexrumia.Cards.Template;

namespace lvalonexrumia.Cards
{
	public sealed class cardtornDef : lvalonexrumiaCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.Colors = new List<ManaColor>
			{
				ManaColor.Black,
				ManaColor.Red
			};
			cardDefaultConfig.Cost = new ManaGroup
			{
				Any = 1,
				Black = 2,
				Red = 2
			};
			cardDefaultConfig.Rarity = Rarity.Rare;
			cardDefaultConfig.Type = CardType.Ability;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.Self);
			cardDefaultConfig.Value1 = new int?(10);
			cardDefaultConfig.Value2 = new int?(2);
			cardDefaultConfig.UpgradedValue2 = new int?(4);
			cardDefaultConfig.RelativeEffects = new List<string> { "Graze", "seatkincrease", "seincrease" };
			cardDefaultConfig.UpgradedRelativeEffects = new List<string> { "Graze", "seatkincrease", "seincrease" };
			cardDefaultConfig.Keywords = Keyword.Retain;
			cardDefaultConfig.UpgradedKeywords = Keyword.Initial | Keyword.Retain;
			cardDefaultConfig.Illustrator = "cato";
			cardDefaultConfig.Index = CardIndexGenerator.GetUniqueIndex(cardDefaultConfig);
			return cardDefaultConfig;
		}
	}
}
