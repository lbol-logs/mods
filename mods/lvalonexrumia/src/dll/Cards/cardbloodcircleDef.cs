using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using lvalonexrumia.Cards.Template;

namespace lvalonexrumia.Cards
{
	public sealed class cardbloodcircleDef : lvalonexrumiaCardTemplate
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
				Any = 2,
				Black = 1,
				Red = 1,
				Hybrid = 1,
				HybridColor = 7
			};
			cardDefaultConfig.UpgradedCost = new ManaGroup?(new ManaGroup
			{
				Any = 1,
				Black = 1,
				Red = 1
			});
			cardDefaultConfig.Rarity = Rarity.Rare;
			cardDefaultConfig.Type = CardType.Ability;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.Self);
			cardDefaultConfig.Value1 = new int?(5);
			cardDefaultConfig.Value2 = new int?(1);
			cardDefaultConfig.RelativeCards = new List<string> { "carddarkblood", "cardredblood" };
			cardDefaultConfig.UpgradedRelativeCards = new List<string> { "carddarkblood", "cardredblood" };
			cardDefaultConfig.Illustrator = "retishia";
			cardDefaultConfig.Index = CardIndexGenerator.GetUniqueIndex(cardDefaultConfig);
			return cardDefaultConfig;
		}
	}
}
