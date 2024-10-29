using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using YoumuCharacterMod.Cards.Template;
using YoumuCharacterMod.Illustrator;

namespace YoumuCharacterMod.Cards
{
	public sealed class YoumuWickedSoulDef : YoumuCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.IsPooled = true;
			cardDefaultConfig.Index = 3820;
			cardDefaultConfig.Colors = new List<ManaColor> { ManaColor.Green };
			cardDefaultConfig.Cost = new ManaGroup
			{
				Green = 1,
				Any = 1
			};
			cardDefaultConfig.Rarity = Rarity.Rare;
			cardDefaultConfig.Owner = this.OwnerName;
			cardDefaultConfig.Type = CardType.Skill;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.SingleEnemy);
			cardDefaultConfig.Value1 = new int?(3);
			cardDefaultConfig.UpgradedValue1 = new int?(4);
			cardDefaultConfig.Value2 = new int?(2);
			cardDefaultConfig.UpgradedValue2 = new int?(3);
			cardDefaultConfig.Keywords = Keyword.Exile;
			cardDefaultConfig.UpgradedKeywords = Keyword.Exile;
			cardDefaultConfig.RelativeEffects = new List<string> { "LockedOn", "FirepowerNegative" };
			cardDefaultConfig.UpgradedRelativeEffects = new List<string> { "LockedOn", "FirepowerNegative" };
			cardDefaultConfig.Illustrator = YoumuIllustrator.WickedSoul;
			return cardDefaultConfig;
		}
	}
}
