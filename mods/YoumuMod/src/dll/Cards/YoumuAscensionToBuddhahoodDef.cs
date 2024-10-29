using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using YoumuCharacterMod.Cards.Template;
using YoumuCharacterMod.Illustrator;

namespace YoumuCharacterMod.Cards
{
	public sealed class YoumuAscensionToBuddhahoodDef : YoumuCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.IsPooled = true;
			cardDefaultConfig.Index = 3851;
			cardDefaultConfig.Colors = new List<ManaColor> { ManaColor.Green };
			cardDefaultConfig.Cost = new ManaGroup
			{
				Any = 2,
				Green = 3
			};
			cardDefaultConfig.Rarity = Rarity.Rare;
			cardDefaultConfig.Owner = this.OwnerName;
			cardDefaultConfig.Type = CardType.Ability;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.Nobody);
			cardDefaultConfig.Value1 = new int?(1);
			cardDefaultConfig.Value2 = new int?(1);
			cardDefaultConfig.RelativeKeyword = Keyword.Echo;
			cardDefaultConfig.UpgradedRelativeKeyword = Keyword.Echo;
			cardDefaultConfig.Keywords = Keyword.Plentiful;
			cardDefaultConfig.UpgradedKeywords = Keyword.Plentiful;
			cardDefaultConfig.Mana = new ManaGroup?(new ManaGroup
			{
				Green = 1
			});
			cardDefaultConfig.UpgradedMana = new ManaGroup?(new ManaGroup
			{
				Green = 1,
				Philosophy = 1
			});
			cardDefaultConfig.RelativeEffects = new List<string> { "YoumuRiposteSe" };
			cardDefaultConfig.UpgradedRelativeEffects = new List<string> { "YoumuRiposteSe" };
			cardDefaultConfig.Illustrator = YoumuIllustrator.AscensionToBuddhahood;
			return cardDefaultConfig;
		}
	}
}
