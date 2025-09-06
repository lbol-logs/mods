using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using lvalonexrumia.Cards.Template;

namespace lvalonexrumia.Cards
{
	public sealed class cardbefallenDef : lvalonexrumiaCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.Colors = new List<ManaColor> { ManaColor.Black };
			cardDefaultConfig.Cost = new ManaGroup
			{
				Black = 1
			};
			cardDefaultConfig.UpgradedCost = new ManaGroup?(new ManaGroup
			{
				Any = 0
			});
			cardDefaultConfig.Rarity = Rarity.Common;
			cardDefaultConfig.Type = CardType.Skill;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.Self);
			cardDefaultConfig.Value1 = new int?(5);
			cardDefaultConfig.Value2 = new int?(3);
			cardDefaultConfig.RelativeEffects = new List<string> { "sedecrease", "sedarkblood" };
			cardDefaultConfig.UpgradedRelativeEffects = new List<string> { "sedecrease", "sedarkblood" };
			cardDefaultConfig.RelativeCards = new List<string> { "carddarkblood", "Shadow" };
			cardDefaultConfig.UpgradedRelativeCards = new List<string> { "carddarkblood", "Shadow" };
			cardDefaultConfig.Illustrator = "蜂鳥 あかり";
			cardDefaultConfig.Index = CardIndexGenerator.GetUniqueIndex(cardDefaultConfig);
			return cardDefaultConfig;
		}
	}
}
