using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using lvalonexrumia.Cards.Template;

namespace lvalonexrumia.Cards
{
	public sealed class cardcrossoutDef : lvalonexrumiaCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.Colors = new List<ManaColor> { ManaColor.Black };
			cardDefaultConfig.Cost = new ManaGroup
			{
				Black = 1
			};
			cardDefaultConfig.IsXCost = true;
			cardDefaultConfig.Rarity = Rarity.Common;
			cardDefaultConfig.Type = CardType.Defense;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.Self);
			cardDefaultConfig.Block = new int?(5);
			cardDefaultConfig.Value1 = new int?(1);
			cardDefaultConfig.UpgradedValue1 = new int?(2);
			cardDefaultConfig.Mana = new ManaGroup?(new ManaGroup
			{
				Any = 1
			});
			cardDefaultConfig.RelativeKeyword = (Keyword)int.MinValue;
			cardDefaultConfig.UpgradedRelativeKeyword = (Keyword)int.MinValue;
			cardDefaultConfig.RelativeEffects = new List<string> { "sebloodclot" };
			cardDefaultConfig.UpgradedRelativeEffects = new List<string> { "sebloodclot" };
			cardDefaultConfig.Illustrator = "Yu-Gi-Oh!";
			cardDefaultConfig.Index = CardIndexGenerator.GetUniqueIndex(cardDefaultConfig);
			return cardDefaultConfig;
		}
	}
}
