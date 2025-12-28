using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using ReimuUnifierMod.Cards.Template;

namespace ReimuUnifierMod.Cards
{
	public sealed class ReimuUnifierFriendOfAFriendDef : ReimuUnifierCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.IsPooled = true;
			cardDefaultConfig.Colors = new List<ManaColor> { ManaColor.White };
			cardDefaultConfig.Cost = new ManaGroup
			{
				Any = 1,
				White = 2
			};
			cardDefaultConfig.UpgradedCost = new ManaGroup?(new ManaGroup
			{
				Any = 1,
				White = 2
			});
			cardDefaultConfig.Rarity = Rarity.Rare;
			cardDefaultConfig.Type = CardType.Skill;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.Nobody);
			cardDefaultConfig.Value1 = new int?(1);
			cardDefaultConfig.UpgradedValue1 = new int?(2);
			cardDefaultConfig.Value2 = new int?(3);
			cardDefaultConfig.UpgradedValue2 = new int?(5);
			cardDefaultConfig.Mana = new ManaGroup?(ManaGroup.Empty);
			cardDefaultConfig.RelativeKeyword = Keyword.Ethereal | Keyword.Friend;
			cardDefaultConfig.UpgradedRelativeKeyword = Keyword.Ethereal | Keyword.Friend;
			cardDefaultConfig.Keywords = Keyword.Exile;
			cardDefaultConfig.UpgradedKeywords = Keyword.Exile;
			cardDefaultConfig.Illustrator = "";
			cardDefaultConfig.Index = CardIndexGenerator.GetUniqueIndex(cardDefaultConfig);
			return cardDefaultConfig;
		}
	}
}
