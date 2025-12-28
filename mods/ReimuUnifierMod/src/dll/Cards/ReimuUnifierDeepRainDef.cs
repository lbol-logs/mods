using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using ReimuUnifierMod.Cards.Template;

namespace ReimuUnifierMod.Cards
{
	public sealed class ReimuUnifierDeepRainDef : ReimuUnifierCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.IsPooled = true;
			cardDefaultConfig.Colors = new List<ManaColor> { ManaColor.Red };
			cardDefaultConfig.Cost = new ManaGroup
			{
				Red = 1,
				Any = 1
			};
			cardDefaultConfig.UpgradedCost = new ManaGroup?(new ManaGroup
			{
				Red = 1,
				Any = 1
			});
			cardDefaultConfig.Rarity = Rarity.Common;
			cardDefaultConfig.Type = CardType.Skill;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.Nobody);
			cardDefaultConfig.Value1 = new int?(1);
			cardDefaultConfig.UpgradedValue1 = new int?(2);
			cardDefaultConfig.Value2 = new int?(1);
			cardDefaultConfig.UpgradedValue2 = new int?(2);
			cardDefaultConfig.RelativeKeyword = Keyword.Accuracy;
			cardDefaultConfig.UpgradedRelativeKeyword = Keyword.Accuracy;
			cardDefaultConfig.RelativeEffects = new List<string> { "Graze" };
			cardDefaultConfig.UpgradedRelativeEffects = new List<string> { "Graze" };
			cardDefaultConfig.Illustrator = "Saevin";
			cardDefaultConfig.Index = CardIndexGenerator.GetUniqueIndex(cardDefaultConfig);
			return cardDefaultConfig;
		}
	}
}
