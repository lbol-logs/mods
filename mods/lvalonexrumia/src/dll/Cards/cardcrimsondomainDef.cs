using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using lvalonexrumia.Cards.Template;

namespace lvalonexrumia.Cards
{
	public sealed class cardcrimsondomainDef : lvalonexrumiaCardTemplate
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
			cardDefaultConfig.Type = CardType.Skill;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.AllEnemies);
			cardDefaultConfig.Value1 = new int?(1);
			cardDefaultConfig.Keywords = Keyword.Exile;
			cardDefaultConfig.UpgradedKeywords = Keyword.Exile | Keyword.Echo;
			cardDefaultConfig.RelativeEffects = new List<string> { "sebleed", "sebloodmark", "sedeepbleed" };
			cardDefaultConfig.UpgradedRelativeEffects = new List<string> { "sebleed", "sebloodmark", "sedeepbleed" };
			cardDefaultConfig.RelativeCards = new List<string> { "cardbloodstorm" };
			cardDefaultConfig.UpgradedRelativeCards = new List<string> { "cardbloodstorm" };
			cardDefaultConfig.Illustrator = "宇佐见二狗";
			cardDefaultConfig.Index = CardIndexGenerator.GetUniqueIndex(cardDefaultConfig);
			return cardDefaultConfig;
		}
	}
}
