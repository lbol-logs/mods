using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using YoumuCharacterMod.Cards.Template;
using YoumuCharacterMod.Illustrator;

namespace YoumuCharacterMod.Cards
{
	public sealed class YoumuDivineSeveringDef : YoumuCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.IsPooled = true;
			cardDefaultConfig.Index = 3750;
			cardDefaultConfig.Colors = new List<ManaColor> { ManaColor.White };
			cardDefaultConfig.Cost = new ManaGroup
			{
				Any = 2,
				White = 3
			};
			cardDefaultConfig.Rarity = Rarity.Rare;
			cardDefaultConfig.Owner = this.OwnerName;
			cardDefaultConfig.Type = CardType.Ability;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.Nobody);
			cardDefaultConfig.Value1 = new int?(3);
			cardDefaultConfig.Value2 = new int?(1);
			cardDefaultConfig.UpgradedValue2 = new int?(2);
			cardDefaultConfig.Keywords = Keyword.None;
			cardDefaultConfig.RelativeCards = new List<string> { "YoumuSlashOfPresent" };
			cardDefaultConfig.UpgradedRelativeCards = new List<string> { "YoumuSlashOfPresent" };
			cardDefaultConfig.RelativeEffects = new List<string> { "YoumuUnsheatheSe" };
			cardDefaultConfig.UpgradedRelativeEffects = new List<string> { "YoumuUnsheatheSe" };
			cardDefaultConfig.Illustrator = YoumuIllustrator.DivineSevering;
			return cardDefaultConfig;
		}
	}
}
