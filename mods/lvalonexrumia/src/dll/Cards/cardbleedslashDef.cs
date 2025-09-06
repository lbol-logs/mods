using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using lvalonexrumia.Cards.Template;

namespace lvalonexrumia.Cards
{
	public sealed class cardbleedslashDef : lvalonexrumiaCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.Colors = new List<ManaColor> { ManaColor.Black };
			cardDefaultConfig.Cost = new ManaGroup
			{
				Black = 2
			};
			cardDefaultConfig.UpgradedCost = new ManaGroup?(new ManaGroup
			{
				Any = 0
			});
			cardDefaultConfig.Rarity = Rarity.Uncommon;
			cardDefaultConfig.Type = CardType.Ability;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.Self);
			cardDefaultConfig.Value1 = new int?(1);
			cardDefaultConfig.Value2 = new int?(2);
			cardDefaultConfig.RelativeEffects = new List<string> { "sebloodsword" };
			cardDefaultConfig.UpgradedRelativeEffects = new List<string> { "sebloodsword" };
			cardDefaultConfig.RelativeCards = new List<string> { "cardbloodsword" };
			cardDefaultConfig.UpgradedRelativeCards = new List<string> { "cardbloodsword" };
			cardDefaultConfig.Illustrator = "tadano shiroko";
			cardDefaultConfig.Index = CardIndexGenerator.GetUniqueIndex(cardDefaultConfig);
			return cardDefaultConfig;
		}
	}
}
