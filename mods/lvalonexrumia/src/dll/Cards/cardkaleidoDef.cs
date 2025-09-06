using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using lvalonexrumia.Cards.Template;

namespace lvalonexrumia.Cards
{
	public sealed class cardkaleidoDef : lvalonexrumiaCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.Colors = new List<ManaColor>
			{
				ManaColor.Blue,
				ManaColor.Black
			};
			cardDefaultConfig.Cost = new ManaGroup
			{
				Blue = 1,
				Black = 1
			};
			cardDefaultConfig.Rarity = Rarity.Rare;
			cardDefaultConfig.IsXCost = true;
			cardDefaultConfig.Type = CardType.Attack;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.All);
			cardDefaultConfig.Value1 = new int?(5);
			cardDefaultConfig.Value2 = new int?(5);
			cardDefaultConfig.Keywords = Keyword.Synergy | Keyword.Expel;
			cardDefaultConfig.UpgradedKeywords = Keyword.Retain | Keyword.Replenish | Keyword.Synergy | Keyword.Expel;
			cardDefaultConfig.RelativeEffects = new List<string> { "sedecrease" };
			cardDefaultConfig.UpgradedRelativeEffects = new List<string> { "sedecrease" };
			cardDefaultConfig.Illustrator = "ツェぺシュ";
			cardDefaultConfig.Index = CardIndexGenerator.GetUniqueIndex(cardDefaultConfig);
			return cardDefaultConfig;
		}
	}
}
