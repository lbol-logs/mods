using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using lvalonexrumia.Cards.Template;

namespace lvalonexrumia.Cards
{
	public sealed class cardmutualdepletionDef : lvalonexrumiaCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.Colors = new List<ManaColor> { ManaColor.Colorless };
			cardDefaultConfig.Cost = new ManaGroup
			{
				Any = 4,
				Colorless = 1
			};
			cardDefaultConfig.UpgradedCost = new ManaGroup?(new ManaGroup
			{
				Any = 3,
				Colorless = 1
			});
			cardDefaultConfig.Rarity = Rarity.Rare;
			cardDefaultConfig.Type = CardType.Ability;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.Nobody);
			cardDefaultConfig.Value1 = new int?(1);
			cardDefaultConfig.RelativeEffects = new List<string> { "sedecrease" };
			cardDefaultConfig.UpgradedRelativeEffects = new List<string> { "sedecrease" };
			cardDefaultConfig.Illustrator = "にしこー@くるま屋さん";
			cardDefaultConfig.Index = CardIndexGenerator.GetUniqueIndex(cardDefaultConfig);
			return cardDefaultConfig;
		}
	}
}
