using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using lvalonexrumia.Cards.Template;

namespace lvalonexrumia.Cards
{
	public sealed class cardworldburnDef : lvalonexrumiaCardTemplate
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
				Black = 2,
				Red = 2
			};
			cardDefaultConfig.Rarity = Rarity.Rare;
			cardDefaultConfig.Type = CardType.Ability;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.All);
			cardDefaultConfig.Value1 = new int?(1);
			cardDefaultConfig.Keywords = Keyword.Retain;
			cardDefaultConfig.UpgradedKeywords = Keyword.Retain;
			cardDefaultConfig.RelativeEffects = new List<string> { "sebloodmark", "sebleed" };
			cardDefaultConfig.UpgradedRelativeEffects = new List<string> { "sebloodmark", "sebleed" };
			cardDefaultConfig.Illustrator = "shinekalta";
			cardDefaultConfig.Index = CardIndexGenerator.GetUniqueIndex(cardDefaultConfig);
			return cardDefaultConfig;
		}
	}
}
