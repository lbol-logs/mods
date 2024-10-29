using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using Sanae_Kochiya.Cards.Template;
using Sanae_Kochiya.GunName;

namespace Sanae_Kochiya.Source.Cards.Uncommon
{
	public sealed class SanaeAttackCopyDef : SampleCharacterCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.GunName = GunNameID.GetGunFromId(4712);
			cardDefaultConfig.Colors = new List<ManaColor> { ManaColor.Blue };
			cardDefaultConfig.Cost = default(ManaGroup);
			cardDefaultConfig.Rarity = Rarity.Uncommon;
			cardDefaultConfig.Type = CardType.Attack;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.SingleEnemy);
			cardDefaultConfig.Damage = new int?(6);
			cardDefaultConfig.UpgradedDamage = new int?(8);
			cardDefaultConfig.Keywords = Keyword.AutoExile;
			cardDefaultConfig.UpgradedKeywords = Keyword.Replenish | Keyword.AutoExile;
			cardDefaultConfig.RelativeKeyword = Keyword.Exile | Keyword.CopyHint;
			cardDefaultConfig.UpgradedRelativeKeyword = Keyword.Exile | Keyword.CopyHint;
			cardDefaultConfig.Illustrator = "";
			cardDefaultConfig.Index = CardIndexGenerator.GetUniqueIndex(cardDefaultConfig);
			return cardDefaultConfig;
		}
	}
}
