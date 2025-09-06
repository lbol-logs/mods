using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using lvalonexrumia.Cards.Template;

namespace lvalonexrumia.Cards
{
	public sealed class cardhakureimikoDef : lvalonexrumiaCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.Colors = new List<ManaColor>
			{
				ManaColor.White,
				ManaColor.Black,
				ManaColor.Red
			};
			cardDefaultConfig.Cost = new ManaGroup
			{
				Any = 1,
				White = 1,
				Red = 1,
				Black = 1,
				Hybrid = 1,
				HybridColor = 7
			};
			cardDefaultConfig.Rarity = Rarity.Rare;
			cardDefaultConfig.Type = CardType.Friend;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.Self);
			cardDefaultConfig.Value1 = new int?(10);
			cardDefaultConfig.PassiveCost = new int?(1);
			cardDefaultConfig.ActiveCost = new int?(-2);
			cardDefaultConfig.UltimateCost = new int?(-9);
			cardDefaultConfig.Loyalty = new int?(7);
			cardDefaultConfig.UpgradedLoyalty = new int?(9);
			cardDefaultConfig.RelativeEffects = new List<string> { "seincrease" };
			cardDefaultConfig.UpgradedRelativeEffects = new List<string> { "seincrease" };
			cardDefaultConfig.Illustrator = "草津太";
			cardDefaultConfig.Index = CardIndexGenerator.GetUniqueIndex(cardDefaultConfig);
			return cardDefaultConfig;
		}
	}
}
