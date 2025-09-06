using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using lvalonexrumia.Cards.Template;

namespace lvalonexrumia.Cards
{
	public sealed class cardlowtideDef : lvalonexrumiaCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.Colors = new List<ManaColor>
			{
				ManaColor.Black,
				ManaColor.Blue
			};
			cardDefaultConfig.Cost = new ManaGroup
			{
				Any = 2,
				Black = 1,
				Blue = 1
			};
			cardDefaultConfig.UpgradedCost = new ManaGroup?(new ManaGroup
			{
				Any = 1,
				Hybrid = 2,
				HybridColor = 4
			});
			cardDefaultConfig.Rarity = Rarity.Uncommon;
			cardDefaultConfig.Type = CardType.Skill;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.Self);
			cardDefaultConfig.Value1 = new int?(5);
			cardDefaultConfig.Value2 = new int?(1);
			cardDefaultConfig.RelativeEffects = new List<string> { "sedecrease" };
			cardDefaultConfig.UpgradedRelativeEffects = new List<string> { "sedecrease" };
			cardDefaultConfig.Illustrator = "あらき\u3000ﾟ ∀ ﾟ)。彡\u309c";
			cardDefaultConfig.Index = CardIndexGenerator.GetUniqueIndex(cardDefaultConfig);
			return cardDefaultConfig;
		}
	}
}
