using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using lvalonexrumia.Cards.Template;

namespace lvalonexrumia.Cards
{
	public sealed class cardheartacheDef : lvalonexrumiaCardTemplate
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
			cardDefaultConfig.Rarity = Rarity.Common;
			cardDefaultConfig.Type = CardType.Defense;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.Self);
			cardDefaultConfig.Block = new int?(22);
			cardDefaultConfig.UpgradedBlock = new int?(28);
			cardDefaultConfig.Value1 = new int?(5);
			cardDefaultConfig.UpgradedKeywords = Keyword.Replenish;
			cardDefaultConfig.RelativeEffects = new List<string> { "sedecrease" };
			cardDefaultConfig.UpgradedRelativeEffects = new List<string> { "sedecrease" };
			cardDefaultConfig.Illustrator = "you";
			cardDefaultConfig.Index = CardIndexGenerator.GetUniqueIndex(cardDefaultConfig);
			return cardDefaultConfig;
		}
	}
}
