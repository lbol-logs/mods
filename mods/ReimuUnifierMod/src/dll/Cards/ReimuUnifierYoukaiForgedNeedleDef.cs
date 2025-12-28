using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using ReimuUnifierMod.Cards.Template;

namespace ReimuUnifierMod.Cards
{
	public sealed class ReimuUnifierYoukaiForgedNeedleDef : ReimuUnifierCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.GunName = "封魔针";
			cardDefaultConfig.IsPooled = false;
			cardDefaultConfig.Colors = new List<ManaColor> { ManaColor.Red };
			cardDefaultConfig.Cost = new ManaGroup
			{
				Any = 1
			};
			cardDefaultConfig.UpgradedCost = new ManaGroup?(new ManaGroup
			{
				Any = 1
			});
			cardDefaultConfig.Rarity = Rarity.Common;
			cardDefaultConfig.Mana = new ManaGroup?(ManaGroup.Empty);
			cardDefaultConfig.Type = CardType.Attack;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.SingleEnemy);
			cardDefaultConfig.Keywords = Keyword.Exile | Keyword.Retain;
			cardDefaultConfig.UpgradedKeywords = Keyword.Exile | Keyword.Retain;
			cardDefaultConfig.RelativeKeyword = Keyword.Friend;
			cardDefaultConfig.UpgradedRelativeKeyword = Keyword.Friend;
			cardDefaultConfig.UpgradedRelativeEffects = new List<string> { "LockedOn" };
			cardDefaultConfig.Damage = new int?(7);
			cardDefaultConfig.UpgradedDamage = new int?(9);
			cardDefaultConfig.Value1 = new int?(1);
			cardDefaultConfig.Illustrator = "Saevin";
			cardDefaultConfig.Index = CardIndexGenerator.GetUniqueIndex(cardDefaultConfig);
			return cardDefaultConfig;
		}
	}
}
