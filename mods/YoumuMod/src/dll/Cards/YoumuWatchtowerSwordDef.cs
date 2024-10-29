using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using YoumuCharacterMod.Cards.Template;
using YoumuCharacterMod.Illustrator;

namespace YoumuCharacterMod.Cards
{
	public sealed class YoumuWatchtowerSwordDef : YoumuCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.IsPooled = true;
			cardDefaultConfig.Index = 3533;
			cardDefaultConfig.Colors = new List<ManaColor> { ManaColor.Green };
			cardDefaultConfig.Cost = new ManaGroup
			{
				Any = 2,
				Green = 1
			};
			cardDefaultConfig.UpgradedCost = new ManaGroup?(new ManaGroup
			{
				Any = 1,
				Green = 1
			});
			cardDefaultConfig.Rarity = Rarity.Uncommon;
			cardDefaultConfig.Owner = this.OwnerName;
			cardDefaultConfig.Type = CardType.Ability;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.Nobody);
			cardDefaultConfig.Value1 = new int?(1);
			cardDefaultConfig.Keywords = Keyword.None;
			cardDefaultConfig.UpgradedKeywords = Keyword.Initial;
			cardDefaultConfig.RelativeEffects = new List<string> { "LockedOn" };
			cardDefaultConfig.UpgradedRelativeEffects = new List<string> { "LockedOn" };
			cardDefaultConfig.Illustrator = YoumuIllustrator.WatchtowerSword;
			return cardDefaultConfig;
		}
	}
}
