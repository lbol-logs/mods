using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using lvalonexrumia.Cards.Template;

namespace lvalonexrumia.Cards
{
	public sealed class cardbloodyinyangDef : lvalonexrumiaCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.Colors = new List<ManaColor>
			{
				ManaColor.Black,
				ManaColor.Red
			};
			cardDefaultConfig.Cost = new ManaGroup
			{
				Red = 1,
				Black = 1,
				Hybrid = 2,
				HybridColor = 7
			};
			cardDefaultConfig.Rarity = Rarity.Rare;
			cardDefaultConfig.Type = CardType.Skill;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.Nobody);
			cardDefaultConfig.Keywords = Keyword.Exile | Keyword.Retain;
			cardDefaultConfig.UpgradedKeywords = Keyword.Exile | Keyword.Echo | Keyword.Retain;
			cardDefaultConfig.Value1 = new int?(2);
			cardDefaultConfig.Illustrator = "Koissa";
			cardDefaultConfig.Index = CardIndexGenerator.GetUniqueIndex(cardDefaultConfig);
			return cardDefaultConfig;
		}
	}
}
