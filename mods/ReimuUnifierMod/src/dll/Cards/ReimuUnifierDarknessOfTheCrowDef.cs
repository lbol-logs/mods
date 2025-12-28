using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using ReimuUnifierMod.Cards.Template;

namespace ReimuUnifierMod.Cards
{
	public sealed class ReimuUnifierDarknessOfTheCrowDef : ReimuUnifierCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.IsPooled = true;
			cardDefaultConfig.Colors = new List<ManaColor>
			{
				ManaColor.Red,
				ManaColor.Green
			};
			cardDefaultConfig.Cost = new ManaGroup
			{
				Any = 1,
				Red = 1,
				Green = 1
			};
			cardDefaultConfig.UpgradedCost = new ManaGroup?(new ManaGroup
			{
				Any = 1,
				Red = 1,
				Green = 1
			});
			cardDefaultConfig.Rarity = Rarity.Uncommon;
			cardDefaultConfig.Type = CardType.Ability;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.Nobody);
			cardDefaultConfig.Value1 = new int?(10);
			cardDefaultConfig.UpgradedValue1 = new int?(14);
			cardDefaultConfig.Value2 = new int?(1);
			cardDefaultConfig.UpgradedValue2 = new int?(2);
			cardDefaultConfig.RelativeEffects = new List<string> { "TeamUpSe", "Graze" };
			cardDefaultConfig.UpgradedRelativeEffects = new List<string> { "TeamUpSe", "Graze" };
			cardDefaultConfig.RelativeKeyword = Keyword.Friend;
			cardDefaultConfig.UpgradedRelativeKeyword = Keyword.Friend;
			cardDefaultConfig.Illustrator = "Saevin";
			cardDefaultConfig.Index = CardIndexGenerator.GetUniqueIndex(cardDefaultConfig);
			return cardDefaultConfig;
		}
	}
}
