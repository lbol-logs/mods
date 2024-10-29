using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using YoumuCharacterMod.Cards.Template;
using YoumuCharacterMod.Illustrator;

namespace YoumuCharacterMod.Cards
{
	public sealed class YoumuHalfBodyDistillationDef : YoumuCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.IsPooled = true;
			cardDefaultConfig.Index = 3620;
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
			cardDefaultConfig.Type = CardType.Defense;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.Nobody);
			cardDefaultConfig.Block = new int?(14);
			cardDefaultConfig.UpgradedBlock = new int?(18);
			cardDefaultConfig.Value1 = new int?(1);
			cardDefaultConfig.UpgradedValue1 = new int?(2);
			cardDefaultConfig.RelativeKeyword = Keyword.Block | Keyword.Ethereal;
			cardDefaultConfig.UpgradedRelativeKeyword = Keyword.Block | Keyword.Ethereal;
			cardDefaultConfig.Illustrator = YoumuIllustrator.HalfBodyDistillation;
			return cardDefaultConfig;
		}
	}
}
