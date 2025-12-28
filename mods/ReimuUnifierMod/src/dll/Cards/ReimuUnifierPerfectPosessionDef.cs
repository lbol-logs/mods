using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using ReimuUnifierMod.Cards.Template;

namespace ReimuUnifierMod.Cards
{
	public sealed class ReimuUnifierPerfectPosessionDef : ReimuUnifierCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.IsPooled = true;
			cardDefaultConfig.Colors = new List<ManaColor> { ManaColor.Blue };
			cardDefaultConfig.Cost = new ManaGroup
			{
				Any = 2,
				Blue = 1
			};
			cardDefaultConfig.UpgradedCost = new ManaGroup?(new ManaGroup
			{
				Blue = 1
			});
			cardDefaultConfig.Rarity = Rarity.Rare;
			cardDefaultConfig.Type = CardType.Skill;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.Nobody);
			cardDefaultConfig.Value1 = new int?(3);
			cardDefaultConfig.UpgradedValue1 = new int?(3);
			cardDefaultConfig.Mana = new ManaGroup?(ManaGroup.Single(ManaColor.Blue));
			cardDefaultConfig.Illustrator = "Saevin";
			cardDefaultConfig.Keywords = Keyword.Exile;
			cardDefaultConfig.UpgradedKeywords = Keyword.Exile;
			cardDefaultConfig.RelativeKeyword = Keyword.Shield | Keyword.Friend;
			cardDefaultConfig.UpgradedRelativeKeyword = Keyword.Shield | Keyword.Friend;
			cardDefaultConfig.Index = CardIndexGenerator.GetUniqueIndex(cardDefaultConfig);
			return cardDefaultConfig;
		}
	}
}
