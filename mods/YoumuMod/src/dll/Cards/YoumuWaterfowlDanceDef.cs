using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using YoumuCharacterMod.Cards.Template;
using YoumuCharacterMod.GunName;
using YoumuCharacterMod.Illustrator;

namespace YoumuCharacterMod.Cards
{
	public sealed class YoumuWaterfowlDanceDef : YoumuCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.GunName = YoumuGunName.WaterfowlDance;
			cardDefaultConfig.IsPooled = true;
			cardDefaultConfig.Index = 4004;
			cardDefaultConfig.Colors = new List<ManaColor>
			{
				ManaColor.White,
				ManaColor.Blue
			};
			cardDefaultConfig.Cost = new ManaGroup
			{
				White = 1,
				Blue = 1
			};
			cardDefaultConfig.Rarity = Rarity.Rare;
			cardDefaultConfig.Owner = this.OwnerName;
			cardDefaultConfig.Type = CardType.Attack;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.SingleEnemy);
			cardDefaultConfig.Damage = new int?(8);
			cardDefaultConfig.UpgradedDamage = new int?(10);
			cardDefaultConfig.Value1 = new int?(2);
			cardDefaultConfig.Value2 = new int?(3);
			cardDefaultConfig.UpgradedValue2 = new int?(4);
			cardDefaultConfig.Mana = new ManaGroup?(new ManaGroup
			{
				White = 1,
				Blue = 1,
				Colorless = 1
			});
			cardDefaultConfig.UpgradedMana = new ManaGroup?(new ManaGroup
			{
				White = 1,
				Blue = 1,
				Philosophy = 1
			});
			cardDefaultConfig.RelativeEffects = new List<string> { "YoumuUnsheatheSe", "LockedOn" };
			cardDefaultConfig.UpgradedRelativeEffects = new List<string> { "YoumuUnsheatheSe", "LockedOn" };
			cardDefaultConfig.Illustrator = YoumuIllustrator.WaterfowlDance;
			return cardDefaultConfig;
		}
	}
}
