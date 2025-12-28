using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using ReimuUnifierMod.Cards.Template;

namespace ReimuUnifierMod.Cards
{
	public sealed class ReimuUnifierWisdomOfHumanityDef : ReimuUnifierCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.IsPooled = true;
			cardDefaultConfig.Colors = new List<ManaColor> { ManaColor.Blue };
			cardDefaultConfig.Cost = new ManaGroup
			{
				Blue = 1,
				Any = 1
			};
			cardDefaultConfig.UpgradedCost = new ManaGroup?(new ManaGroup
			{
				Blue = 1,
				Any = 1
			});
			cardDefaultConfig.Rarity = Rarity.Uncommon;
			cardDefaultConfig.Type = CardType.Skill;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.Nobody);
			cardDefaultConfig.Block = new int?(3);
			cardDefaultConfig.UpgradedBlock = new int?(0);
			cardDefaultConfig.Shield = new int?(0);
			cardDefaultConfig.UpgradedShield = new int?(3);
			cardDefaultConfig.Illustrator = "Saevin";
			cardDefaultConfig.Keywords = Keyword.Exile;
			cardDefaultConfig.UpgradedKeywords = Keyword.Exile;
			cardDefaultConfig.RelativeKeyword = Keyword.Block | Keyword.Friend;
			cardDefaultConfig.UpgradedRelativeKeyword = Keyword.Shield | Keyword.Friend;
			cardDefaultConfig.RelativeEffects = new List<string> { "TeamUpSe" };
			cardDefaultConfig.UpgradedRelativeEffects = new List<string> { "TeamUpSe" };
			cardDefaultConfig.Index = CardIndexGenerator.GetUniqueIndex(cardDefaultConfig);
			return cardDefaultConfig;
		}
	}
}
