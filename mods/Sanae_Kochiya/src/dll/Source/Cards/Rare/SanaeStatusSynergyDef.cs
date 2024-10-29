using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using Sanae_Kochiya.Cards.Template;

namespace Sanae_Kochiya.Source.Cards.Rare
{
	public sealed class SanaeStatusSynergyDef : SampleCharacterCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.Colors = new List<ManaColor> { ManaColor.White };
			cardDefaultConfig.Cost = new ManaGroup
			{
				White = 2
			};
			cardDefaultConfig.Rarity = Rarity.Rare;
			cardDefaultConfig.Type = CardType.Ability;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.Self);
			cardDefaultConfig.Value1 = new int?(5);
			cardDefaultConfig.Value2 = new int?(3);
			cardDefaultConfig.UpgradedValue2 = new int?(5);
			cardDefaultConfig.Mana = new ManaGroup?(new ManaGroup
			{
				Philosophy = 2
			});
			cardDefaultConfig.UpgradedMana = new ManaGroup?(new ManaGroup
			{
				Philosophy = 5
			});
			cardDefaultConfig.RelativeKeyword = Keyword.Philosophy;
			cardDefaultConfig.UpgradedRelativeKeyword = Keyword.Philosophy;
			cardDefaultConfig.RelativeEffects = new List<string> { "Firepower" };
			cardDefaultConfig.UpgradedRelativeEffects = new List<string> { "Firepower" };
			cardDefaultConfig.RelativeCards = new List<string> { "Riguang" };
			cardDefaultConfig.UpgradedRelativeCards = new List<string> { "Riguang" };
			cardDefaultConfig.Illustrator = "";
			cardDefaultConfig.Index = CardIndexGenerator.GetUniqueIndex(cardDefaultConfig);
			return cardDefaultConfig;
		}
	}
}
