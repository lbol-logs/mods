using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using lvalonexrumia.Cards.Template;
using lvalonexrumia.GunName;

namespace lvalonexrumia.Cards
{
	public sealed class cardtenshadedDef : lvalonexrumiaCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.Colors = new List<ManaColor> { ManaColor.Black };
			cardDefaultConfig.Cost = new ManaGroup
			{
				Any = 3,
				Black = 2
			};
			cardDefaultConfig.UpgradedCost = new ManaGroup?(new ManaGroup
			{
				Any = 2,
				Black = 2
			});
			cardDefaultConfig.Rarity = Rarity.Uncommon;
			cardDefaultConfig.Type = CardType.Attack;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.RandomEnemy);
			cardDefaultConfig.GunName = GunNameID.GetGunFromId(520);
			cardDefaultConfig.GunNameBurst = GunNameID.GetGunFromId(520);
			cardDefaultConfig.Damage = new int?(1);
			cardDefaultConfig.Value1 = new int?(5);
			cardDefaultConfig.Value2 = new int?(10);
			cardDefaultConfig.RelativeEffects = new List<string> { "sedecrease" };
			cardDefaultConfig.UpgradedRelativeEffects = new List<string> { "sedecrease", "sebloodmark" };
			cardDefaultConfig.RelativeCards = new List<string> { "Shadow" };
			cardDefaultConfig.UpgradedRelativeCards = new List<string> { "Shadow" };
			cardDefaultConfig.Illustrator = "それ";
			cardDefaultConfig.Index = CardIndexGenerator.GetUniqueIndex(cardDefaultConfig);
			return cardDefaultConfig;
		}
	}
}
