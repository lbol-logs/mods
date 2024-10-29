using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using YoumuCharacterMod.Cards.Template;
using YoumuCharacterMod.Illustrator;

namespace YoumuCharacterMod.Cards
{
	public sealed class YoumuBuddhahoodOfFloraDef : YoumuCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.IsPooled = true;
			cardDefaultConfig.Index = 3622;
			cardDefaultConfig.Colors = new List<ManaColor>
			{
				ManaColor.White,
				ManaColor.Green
			};
			cardDefaultConfig.Cost = new ManaGroup
			{
				White = 1,
				Green = 1
			};
			cardDefaultConfig.Rarity = Rarity.Uncommon;
			cardDefaultConfig.Owner = this.OwnerName;
			cardDefaultConfig.Type = CardType.Skill;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.Self);
			cardDefaultConfig.Value1 = new int?(1);
			cardDefaultConfig.UpgradedValue1 = new int?(2);
			cardDefaultConfig.Keywords = Keyword.None;
			cardDefaultConfig.RelativeCards = new List<string> { "YoumuSlashOfPresent" };
			cardDefaultConfig.UpgradedRelativeCards = new List<string> { "YoumuSlashOfPresent" };
			cardDefaultConfig.RelativeEffects = new List<string> { "Graze", "YoumuUnsheatheSe" };
			cardDefaultConfig.UpgradedRelativeEffects = new List<string> { "Graze", "YoumuUnsheatheSe" };
			cardDefaultConfig.Illustrator = YoumuIllustrator.BuddhahoodOfFlora;
			return cardDefaultConfig;
		}
	}
}
