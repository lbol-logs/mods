using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using ReimuUnifierMod.Cards.Template;

namespace ReimuUnifierMod.Cards
{
	public sealed class ReimuUnifierSubterraneanAdventureDef : ReimuUnifierCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.Colors = new List<ManaColor> { ManaColor.White };
			cardDefaultConfig.Cost = new ManaGroup
			{
				White = 2
			};
			cardDefaultConfig.UpgradedCost = new ManaGroup?(new ManaGroup
			{
				Any = 0
			});
			cardDefaultConfig.Rarity = Rarity.Rare;
			cardDefaultConfig.Type = CardType.Ability;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.Nobody);
			cardDefaultConfig.Value1 = new int?(1);
			cardDefaultConfig.UpgradedValue1 = new int?(1);
			cardDefaultConfig.Mana = new ManaGroup?(ManaGroup.Anys(0));
			cardDefaultConfig.RelativeEffects = new List<string> { "TeamUpSe" };
			cardDefaultConfig.UpgradedRelativeEffects = new List<string> { "TeamUpSe" };
			cardDefaultConfig.RelativeKeyword = Keyword.Ethereal | Keyword.Friend;
			cardDefaultConfig.UpgradedRelativeKeyword = Keyword.Ethereal | Keyword.Friend;
			cardDefaultConfig.RelativeCards = new List<string> { "ReimuUnifierCommunicatorOrbToken", "ReimuUnifierPurpleReproach", "ReimuUnifierFierceGodWillOWisp", "ReimuUnifierDeepRain" };
			cardDefaultConfig.UpgradedRelativeCards = new List<string> { "ReimuUnifierCommunicatorOrbToken", "ReimuUnifierPurpleReproach", "ReimuUnifierFierceGodWillOWisp", "ReimuUnifierDeepRain" };
			cardDefaultConfig.Illustrator = "";
			cardDefaultConfig.Index = CardIndexGenerator.GetUniqueIndex(cardDefaultConfig);
			return cardDefaultConfig;
		}
	}
}
