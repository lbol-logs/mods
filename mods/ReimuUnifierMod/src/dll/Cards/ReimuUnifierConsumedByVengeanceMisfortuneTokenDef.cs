using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using ReimuUnifierMod.Cards.Template;

namespace ReimuUnifierMod.Cards
{
	public sealed class ReimuUnifierConsumedByVengeanceMisfortuneTokenDef : ReimuUnifierCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.IsPooled = false;
			cardDefaultConfig.Type = CardType.Misfortune;
			cardDefaultConfig.Colors = new List<ManaColor> { ManaColor.Colorless };
			cardDefaultConfig.Cost = new ManaGroup
			{
				Any = 2
			};
			cardDefaultConfig.Rarity = Rarity.Uncommon;
			cardDefaultConfig.IsUpgradable = false;
			cardDefaultConfig.Keywords = Keyword.Unremovable | Keyword.Forbidden;
			cardDefaultConfig.UpgradedKeywords = Keyword.Unremovable | Keyword.Forbidden;
			cardDefaultConfig.Illustrator = "Saevin";
			cardDefaultConfig.Index = CardIndexGenerator.GetUniqueIndex(cardDefaultConfig);
			return cardDefaultConfig;
		}
	}
}
