using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using lvalonexrumia.Cards.Template;

namespace lvalonexrumia.Cards
{
	public sealed class cardinfuseddarknessDef : lvalonexrumiaCardTemplate
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
			cardDefaultConfig.UpgradedCost = new ManaGroup?(new ManaGroup
			{
				Black = 1
			});
			cardDefaultConfig.Rarity = Rarity.Rare;
			cardDefaultConfig.Type = CardType.Skill;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.Self);
			cardDefaultConfig.Value1 = new int?(1);
			cardDefaultConfig.Value2 = new int?(1);
			cardDefaultConfig.Mana = new ManaGroup?(new ManaGroup
			{
				Philosophy = 1
			});
			cardDefaultConfig.RelativeCards = new List<string> { "carddarkblood" };
			cardDefaultConfig.UpgradedRelativeCards = new List<string> { "carddarkblood" };
			cardDefaultConfig.Illustrator = "shukusuri";
			cardDefaultConfig.Index = CardIndexGenerator.GetUniqueIndex(cardDefaultConfig);
			return cardDefaultConfig;
		}
	}
}
