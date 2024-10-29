using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using Sanae_Kochiya.Cards.Template;

namespace Sanae_Kochiya.Source.Cards.Offcolor
{
	public sealed class SanaeSuwakoFriendDef : SampleCharacterCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.Colors = new List<ManaColor>
			{
				ManaColor.Black,
				ManaColor.Green
			};
			cardDefaultConfig.Cost = new ManaGroup
			{
				Any = 2,
				Black = 1,
				Green = 1
			};
			cardDefaultConfig.UpgradedCost = new ManaGroup?(new ManaGroup
			{
				Any = 1,
				Black = 1,
				Green = 1
			});
			cardDefaultConfig.Rarity = Rarity.Rare;
			cardDefaultConfig.Type = CardType.Friend;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.Self);
			cardDefaultConfig.Value1 = new int?(2);
			cardDefaultConfig.Mana = new ManaGroup?(default(ManaGroup));
			cardDefaultConfig.Loyalty = new int?(2);
			cardDefaultConfig.PassiveCost = new int?(3);
			cardDefaultConfig.UpgradedPassiveCost = new int?(5);
			cardDefaultConfig.ActiveCost = new int?(0);
			cardDefaultConfig.UltimateCost = new int?(-4);
			cardDefaultConfig.RelativeKeyword = Keyword.Ability;
			cardDefaultConfig.UpgradedRelativeKeyword = Keyword.Ability;
			cardDefaultConfig.RelativeEffects = new List<string> { "Weak" };
			cardDefaultConfig.UpgradedRelativeEffects = new List<string> { "Weak" };
			cardDefaultConfig.RelativeCards = new List<string> { "BlackResidue" };
			cardDefaultConfig.UpgradedRelativeCards = new List<string> { "BlackResidue" };
			cardDefaultConfig.Illustrator = "";
			cardDefaultConfig.Index = CardIndexGenerator.Initial_offset + 444501;
			return cardDefaultConfig;
		}
	}
}
