using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using Momiji.Source.GunName;

namespace Momiji.Source
{
	public sealed class MapleLeafDef : SampleCharacterCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.GunName = GunNameID.GetGunFromId(400);
			cardDefaultConfig.IsPooled = false;
			cardDefaultConfig.Colors = new List<ManaColor> { ManaColor.Colorless };
			cardDefaultConfig.Cost = new ManaGroup
			{
				Any = 0
			};
			cardDefaultConfig.UpgradedCost = new ManaGroup?(new ManaGroup
			{
				Any = 0
			});
			cardDefaultConfig.Rarity = Rarity.Common;
			cardDefaultConfig.Type = CardType.Skill;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.Nobody);
			cardDefaultConfig.Mana = new ManaGroup?(new ManaGroup
			{
				Philosophy = 1
			});
			cardDefaultConfig.UpgradedMana = new ManaGroup?(new ManaGroup
			{
				Philosophy = 2
			});
			cardDefaultConfig.Value1 = new int?(1);
			cardDefaultConfig.Keywords = Keyword.Exile | Keyword.Retain;
			cardDefaultConfig.UpgradedKeywords = Keyword.Exile | Keyword.Retain;
			cardDefaultConfig.Illustrator = "ramudayajirushi";
			cardDefaultConfig.Index = CardIndexGenerator.GetUniqueIndex(cardDefaultConfig);
			return cardDefaultConfig;
		}
	}
}
