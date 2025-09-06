using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using lvalonexrumia.Cards.Template;

namespace lvalonexrumia.Cards
{
	public sealed class cardidliveDef : lvalonexrumiaCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.Colors = new List<ManaColor> { ManaColor.Colorless };
			cardDefaultConfig.Cost = new ManaGroup
			{
				Any = 2,
				Colorless = 1
			};
			cardDefaultConfig.Rarity = Rarity.Uncommon;
			cardDefaultConfig.Type = CardType.Skill;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.Nobody);
			cardDefaultConfig.Value1 = new int?(1);
			cardDefaultConfig.Keywords = Keyword.Exile;
			cardDefaultConfig.UpgradedKeywords = Keyword.Exile | Keyword.Retain;
			cardDefaultConfig.RelativeEffects = new List<string> { "sequickrestore" };
			cardDefaultConfig.UpgradedRelativeEffects = new List<string> { "sequickrestore" };
			cardDefaultConfig.Illustrator = "ｼﾞｮﾝﾃﾞｨｰ";
			cardDefaultConfig.Index = CardIndexGenerator.GetUniqueIndex(cardDefaultConfig);
			return cardDefaultConfig;
		}
	}
}
