using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using lvalonexrumia.Cards.Template;

namespace lvalonexrumia.Cards
{
	public sealed class cardbloodspeedDef : lvalonexrumiaCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.Colors = new List<ManaColor> { ManaColor.Black };
			cardDefaultConfig.Cost = new ManaGroup
			{
				Black = 1
			};
			cardDefaultConfig.Rarity = Rarity.Uncommon;
			cardDefaultConfig.Type = CardType.Skill;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.Self);
			cardDefaultConfig.Value1 = new int?(5);
			cardDefaultConfig.Value2 = new int?(2);
			cardDefaultConfig.UpgradedValue2 = new int?(4);
			cardDefaultConfig.RelativeEffects = new List<string> { "sedecrease", "seaccel" };
			cardDefaultConfig.UpgradedRelativeEffects = new List<string> { "sedecrease", "seaccel" };
			cardDefaultConfig.Illustrator = "えんご";
			cardDefaultConfig.Index = CardIndexGenerator.GetUniqueIndex(cardDefaultConfig);
			return cardDefaultConfig;
		}
	}
}
