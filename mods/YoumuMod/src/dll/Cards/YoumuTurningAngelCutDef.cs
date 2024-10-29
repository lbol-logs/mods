using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using YoumuCharacterMod.Cards.Template;
using YoumuCharacterMod.Illustrator;

namespace YoumuCharacterMod.Cards
{
	public sealed class YoumuTurningAngelCutDef : YoumuCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.Index = 3990;
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
			cardDefaultConfig.Rarity = Rarity.Rare;
			cardDefaultConfig.IsXCost = true;
			cardDefaultConfig.Owner = this.OwnerName;
			cardDefaultConfig.Type = CardType.Skill;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.SingleEnemy);
			cardDefaultConfig.Value1 = new int?(1);
			cardDefaultConfig.Value2 = new int?(2);
			cardDefaultConfig.UpgradedValue2 = new int?(3);
			cardDefaultConfig.Mana = new ManaGroup?(new ManaGroup
			{
				White = 2
			});
			cardDefaultConfig.Keywords = Keyword.None;
			cardDefaultConfig.RelativeCards = new List<string> { "YoumuSlashOfPresent" };
			cardDefaultConfig.UpgradedRelativeCards = new List<string> { "YoumuSlashOfPresent" };
			cardDefaultConfig.RelativeEffects = new List<string> { "LockedOn" };
			cardDefaultConfig.UpgradedRelativeEffects = new List<string> { "LockedOn" };
			cardDefaultConfig.Illustrator = YoumuIllustrator.TurningAngelCut;
			return cardDefaultConfig;
		}
	}
}
