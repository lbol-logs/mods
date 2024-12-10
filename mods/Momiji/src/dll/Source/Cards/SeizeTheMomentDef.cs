using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;

namespace Momiji.Source.Cards
{
	public sealed class SeizeTheMomentDef : SampleCharacterCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.Colors = new List<ManaColor> { ManaColor.White };
			cardDefaultConfig.Cost = new ManaGroup
			{
				Any = 1,
				White = 2
			};
			cardDefaultConfig.UpgradedCost = new ManaGroup?(new ManaGroup
			{
				Any = 1,
				White = 1
			});
			cardDefaultConfig.Rarity = Rarity.Rare;
			cardDefaultConfig.Type = CardType.Attack;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.SingleEnemy);
			cardDefaultConfig.Damage = new int?(16);
			cardDefaultConfig.UpgradedDamage = new int?(16);
			cardDefaultConfig.Value1 = new int?(3);
			cardDefaultConfig.UpgradedValue1 = new int?(4);
			cardDefaultConfig.Value2 = new int?(1);
			cardDefaultConfig.UpgradedValue2 = new int?(2);
			cardDefaultConfig.Keywords = Keyword.Exile;
			cardDefaultConfig.UpgradedKeywords = Keyword.Accuracy | Keyword.Exile;
			cardDefaultConfig.RelativeEffects = new List<string> { "TempFirepowerNegative", "Vulnerable", "SpiritNegative", "OffensiveIntention", "DefensiveIntention", "SpecialIntention" };
			cardDefaultConfig.UpgradedRelativeEffects = new List<string> { "TempFirepowerNegative", "Vulnerable", "SpiritNegative", "OffensiveIntention", "DefensiveIntention", "SpecialIntention" };
			cardDefaultConfig.Illustrator = "かなめや";
			cardDefaultConfig.Index = CardIndexGenerator.GetUniqueIndex(cardDefaultConfig);
			return cardDefaultConfig;
		}
	}
}
