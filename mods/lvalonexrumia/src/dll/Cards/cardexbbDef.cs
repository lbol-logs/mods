using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using lvalonexrumia.Cards.Template;

namespace lvalonexrumia.Cards
{
	public sealed class cardexbbDef : lvalonexrumiaCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.IsPooled = false;
			cardDefaultConfig.Colors = new List<ManaColor> { ManaColor.Black };
			cardDefaultConfig.Cost = new ManaGroup
			{
				Any = 1,
				Black = 1
			};
			cardDefaultConfig.UpgradedCost = new ManaGroup?(new ManaGroup
			{
				Any = 2
			});
			cardDefaultConfig.Rarity = Rarity.Common;
			cardDefaultConfig.Type = CardType.Defense;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.Self);
			cardDefaultConfig.Block = new int?(10);
			cardDefaultConfig.UpgradedBlock = new int?(13);
			cardDefaultConfig.Keywords = Keyword.Basic;
			cardDefaultConfig.UpgradedKeywords = Keyword.Basic;
			cardDefaultConfig.RelativeKeyword = Keyword.Block;
			cardDefaultConfig.UpgradedRelativeKeyword = Keyword.Block;
			cardDefaultConfig.Illustrator = "녕안";
			cardDefaultConfig.Index = CardIndexGenerator.GetUniqueIndex(cardDefaultConfig);
			return cardDefaultConfig;
		}
	}
}
