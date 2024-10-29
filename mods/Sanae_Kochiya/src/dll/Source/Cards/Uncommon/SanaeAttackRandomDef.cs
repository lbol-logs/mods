using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using Sanae_Kochiya.Cards.Template;
using Sanae_Kochiya.GunName;

namespace Sanae_Kochiya.Source.Cards.Uncommon
{
	public sealed class SanaeAttackRandomDef : SampleCharacterCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.GunName = GunNameID.GetGunFromId(14070);
			cardDefaultConfig.GunNameBurst = GunNameID.GetGunFromId(14071);
			cardDefaultConfig.Colors = new List<ManaColor> { ManaColor.White };
			cardDefaultConfig.Cost = new ManaGroup
			{
				Any = 2,
				White = 1
			};
			cardDefaultConfig.Rarity = Rarity.Uncommon;
			cardDefaultConfig.Type = CardType.Attack;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.RandomEnemy);
			cardDefaultConfig.Damage = new int?(12);
			cardDefaultConfig.UpgradedDamage = new int?(10);
			cardDefaultConfig.Value1 = new int?(2);
			cardDefaultConfig.UpgradedValue1 = new int?(3);
			cardDefaultConfig.Value2 = new int?(2);
			cardDefaultConfig.Mana = new ManaGroup?(new ManaGroup
			{
				White = 2,
				Philosophy = 1
			});
			cardDefaultConfig.UpgradedMana = new ManaGroup?(new ManaGroup
			{
				Philosophy = 3
			});
			cardDefaultConfig.RelativeKeyword = Keyword.Philosophy;
			cardDefaultConfig.UpgradedRelativeKeyword = Keyword.Philosophy;
			cardDefaultConfig.RelativeCards = new List<string> { "Chunguang" };
			cardDefaultConfig.UpgradedRelativeCards = new List<string> { "Chunguang" };
			cardDefaultConfig.Illustrator = "";
			cardDefaultConfig.Index = CardIndexGenerator.GetUniqueIndex(cardDefaultConfig);
			return cardDefaultConfig;
		}
	}
}
