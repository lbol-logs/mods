using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using ReimuUnifierMod.Cards.Template;

namespace ReimuUnifierMod.Cards
{
	public sealed class ReimuUnifierCombinationStrikeCoordinatedPursuitDef : ReimuUnifierCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.Colors = new List<ManaColor>
			{
				ManaColor.Red,
				ManaColor.White
			};
			cardDefaultConfig.Cost = new ManaGroup
			{
				Any = 3,
				Red = 1,
				White = 1
			};
			cardDefaultConfig.UpgradedCost = new ManaGroup?(new ManaGroup
			{
				Any = 2,
				Red = 1,
				White = 1
			});
			cardDefaultConfig.Rarity = Rarity.Rare;
			cardDefaultConfig.Type = CardType.Ability;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.Nobody);
			cardDefaultConfig.Mana = new ManaGroup?(ManaGroup.Empty);
			cardDefaultConfig.RelativeEffects = new List<string> { "TeamUpSe" };
			cardDefaultConfig.UpgradedRelativeEffects = new List<string> { "TeamUpSe" };
			cardDefaultConfig.RelativeKeyword = Keyword.Friend;
			cardDefaultConfig.UpgradedRelativeKeyword = Keyword.Friend;
			cardDefaultConfig.Illustrator = "";
			cardDefaultConfig.Index = CardIndexGenerator.GetUniqueIndex(cardDefaultConfig);
			return cardDefaultConfig;
		}
	}
}
