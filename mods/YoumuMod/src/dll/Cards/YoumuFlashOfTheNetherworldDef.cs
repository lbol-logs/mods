using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using YoumuCharacterMod.Cards.Template;
using YoumuCharacterMod.Illustrator;

namespace YoumuCharacterMod.Cards
{
	public sealed class YoumuFlashOfTheNetherworldDef : YoumuCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.IsPooled = true;
			cardDefaultConfig.Index = 3950;
			cardDefaultConfig.Colors = new List<ManaColor>
			{
				ManaColor.White,
				ManaColor.Green
			};
			cardDefaultConfig.Cost = new ManaGroup
			{
				Any = 3,
				Green = 1,
				White = 1
			};
			cardDefaultConfig.UpgradedCost = new ManaGroup?(new ManaGroup
			{
				Any = 2,
				Green = 1,
				White = 1
			});
			cardDefaultConfig.Rarity = Rarity.Rare;
			cardDefaultConfig.Owner = this.OwnerName;
			cardDefaultConfig.Type = CardType.Ability;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.Nobody);
			cardDefaultConfig.Value1 = new int?(5);
			cardDefaultConfig.UpgradedValue1 = new int?(8);
			cardDefaultConfig.Mana = new ManaGroup?(new ManaGroup
			{
				Any = 1
			});
			cardDefaultConfig.Keywords = Keyword.None;
			cardDefaultConfig.RelativeEffects = new List<string> { "TimeIsLimited" };
			cardDefaultConfig.UpgradedRelativeEffects = new List<string> { "TimeIsLimited" };
			cardDefaultConfig.Illustrator = YoumuIllustrator.FlashOfTheNetherworld;
			return cardDefaultConfig;
		}
	}
}
