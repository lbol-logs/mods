using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using YoumuCharacterMod.Cards.Template;
using YoumuCharacterMod.Illustrator;

namespace YoumuCharacterMod.Cards
{
	public sealed class YoumuSpringWindDef : YoumuCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.IsPooled = true;
			cardDefaultConfig.Index = 3221;
			cardDefaultConfig.Colors = new List<ManaColor> { ManaColor.Green };
			cardDefaultConfig.Cost = new ManaGroup
			{
				Any = 1,
				Green = 1
			};
			cardDefaultConfig.UpgradedCost = new ManaGroup?(new ManaGroup
			{
				Any = 1
			});
			cardDefaultConfig.Rarity = Rarity.Common;
			cardDefaultConfig.Owner = this.OwnerName;
			cardDefaultConfig.Type = CardType.Skill;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.AllEnemies);
			cardDefaultConfig.Value1 = new int?(2);
			cardDefaultConfig.Value2 = new int?(3);
			cardDefaultConfig.Keywords = Keyword.None;
			cardDefaultConfig.RelativeEffects = new List<string> { "LockedOn" };
			cardDefaultConfig.UpgradedRelativeEffects = new List<string> { "LockedOn" };
			cardDefaultConfig.Illustrator = YoumuIllustrator.SpringWind;
			return cardDefaultConfig;
		}
	}
}
