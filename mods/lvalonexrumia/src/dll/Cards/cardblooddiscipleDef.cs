using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using lvalonexrumia.Cards.Template;

namespace lvalonexrumia.Cards
{
	public sealed class cardblooddiscipleDef : lvalonexrumiaCardTemplate
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
			cardDefaultConfig.Rarity = Rarity.Uncommon;
			cardDefaultConfig.Type = CardType.Skill;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.Self);
			cardDefaultConfig.Value1 = new int?(5);
			cardDefaultConfig.Value2 = new int?(2);
			cardDefaultConfig.Keywords = Keyword.Exile;
			cardDefaultConfig.UpgradedKeywords = Keyword.Exile | Keyword.Echo;
			cardDefaultConfig.RelativeEffects = new List<string> { "sedecrease", "sebloodclot" };
			cardDefaultConfig.UpgradedRelativeEffects = new List<string> { "sedecrease", "sebloodclot" };
			cardDefaultConfig.RelativeCards = new List<string> { "cardredblood" };
			cardDefaultConfig.UpgradedRelativeCards = new List<string> { "cardredblood" };
			cardDefaultConfig.Illustrator = "くーげる";
			cardDefaultConfig.Index = CardIndexGenerator.GetUniqueIndex(cardDefaultConfig);
			return cardDefaultConfig;
		}
	}
}
