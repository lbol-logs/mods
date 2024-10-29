using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using Sanae_Kochiya.Cards.Template;

namespace Sanae_Kochiya.Source.Cards.Rare
{
	public sealed class SanaeAmuletDebuffDef : SampleCharacterCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.Colors = new List<ManaColor> { ManaColor.White };
			cardDefaultConfig.Cost = new ManaGroup
			{
				White = 3
			};
			cardDefaultConfig.UpgradedCost = new ManaGroup?(new ManaGroup
			{
				White = 1
			});
			cardDefaultConfig.Rarity = Rarity.Rare;
			cardDefaultConfig.Type = CardType.Ability;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.Self);
			cardDefaultConfig.Value1 = new int?(3);
			cardDefaultConfig.RelativeCards = new List<string> { "SanaeAmuletDebuffWeak", "SanaeAmuletDebuffFrail", "SanaeAmuletDebuffVuln" };
			cardDefaultConfig.UpgradedRelativeCards = new List<string> { "SanaeAmuletDebuffWeak", "SanaeAmuletDebuffFrail", "SanaeAmuletDebuffVuln" };
			cardDefaultConfig.Illustrator = "";
			cardDefaultConfig.Index = CardIndexGenerator.GetUniqueIndex(cardDefaultConfig);
			return cardDefaultConfig;
		}
	}
}
