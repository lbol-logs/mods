using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using lvalonexrumia.Cards.Template;

namespace lvalonexrumia.Cards
{
	public sealed class cardfurnaceDef : lvalonexrumiaCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.Colors = new List<ManaColor> { ManaColor.Red };
			cardDefaultConfig.Cost = new ManaGroup
			{
				Red = 2
			};
			cardDefaultConfig.Rarity = Rarity.Uncommon;
			cardDefaultConfig.Type = CardType.Skill;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.Self);
			cardDefaultConfig.Value1 = new int?(5);
			cardDefaultConfig.Value2 = new int?(1);
			cardDefaultConfig.UpgradedValue2 = new int?(2);
			cardDefaultConfig.RelativeEffects = new List<string> { "sedecrease", "seatkincrease" };
			cardDefaultConfig.UpgradedRelativeEffects = new List<string> { "sedecrease", "seatkincrease" };
			cardDefaultConfig.RelativeCards = new List<string> { "cardredblood" };
			cardDefaultConfig.UpgradedRelativeCards = new List<string> { "cardredblood" };
			cardDefaultConfig.Illustrator = "ラシャ";
			cardDefaultConfig.Index = CardIndexGenerator.GetUniqueIndex(cardDefaultConfig);
			return cardDefaultConfig;
		}
	}
}
