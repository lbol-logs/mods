using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using lvalonexrumia.Cards.Template;

namespace lvalonexrumia.Cards
{
	public sealed class cardtearmedoDef : lvalonexrumiaCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.Colors = new List<ManaColor> { ManaColor.Red };
			cardDefaultConfig.Cost = new ManaGroup
			{
				Any = 1,
				Red = 1
			};
			cardDefaultConfig.Rarity = Rarity.Rare;
			cardDefaultConfig.Type = CardType.Ability;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.Self);
			cardDefaultConfig.Value1 = new int?(1);
			cardDefaultConfig.Value2 = new int?(5);
			cardDefaultConfig.UpgradedKeywords = Keyword.Initial | Keyword.Replenish;
			cardDefaultConfig.RelativeEffects = new List<string> { "sebloodstorm", "seatkincrease" };
			cardDefaultConfig.UpgradedRelativeEffects = new List<string> { "sebloodstorm", "seatkincrease" };
			cardDefaultConfig.RelativeCards = new List<string> { "cardbloodstorm" };
			cardDefaultConfig.UpgradedRelativeCards = new List<string> { "cardbloodstorm" };
			cardDefaultConfig.Illustrator = "黒夢";
			cardDefaultConfig.Index = CardIndexGenerator.GetUniqueIndex(cardDefaultConfig);
			return cardDefaultConfig;
		}
	}
}
