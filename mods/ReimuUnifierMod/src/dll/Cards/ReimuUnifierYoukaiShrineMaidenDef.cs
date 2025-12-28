using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using ReimuUnifierMod.Cards.Template;

namespace ReimuUnifierMod.Cards
{
	public sealed class ReimuUnifierYoukaiShrineMaidenDef : ReimuUnifierCardTemplate
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
			cardDefaultConfig.Rarity = Rarity.Uncommon;
			cardDefaultConfig.Type = CardType.Skill;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.Self);
			cardDefaultConfig.Keywords = Keyword.Exile;
			cardDefaultConfig.UpgradedKeywords = Keyword.Exile;
			cardDefaultConfig.RelativeEffects = new List<string> { "TeamUpSe" };
			cardDefaultConfig.UpgradedRelativeEffects = new List<string> { "TeamUpSe" };
			cardDefaultConfig.RelativeKeyword = Keyword.Misfortune | Keyword.Friend;
			cardDefaultConfig.UpgradedRelativeKeyword = Keyword.Misfortune | Keyword.Friend;
			cardDefaultConfig.Mana = new ManaGroup?(new ManaGroup
			{
				Philosophy = 3
			});
			cardDefaultConfig.Value1 = new int?(3);
			cardDefaultConfig.UpgradedValue1 = new int?(5);
			cardDefaultConfig.Illustrator = "";
			cardDefaultConfig.Index = CardIndexGenerator.GetUniqueIndex(cardDefaultConfig);
			return cardDefaultConfig;
		}
	}
}
