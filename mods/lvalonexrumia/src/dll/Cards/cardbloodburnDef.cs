using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using lvalonexrumia.Cards.Template;

namespace lvalonexrumia.Cards
{
	public sealed class cardbloodburnDef : lvalonexrumiaCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.Colors = new List<ManaColor> { ManaColor.Black };
			cardDefaultConfig.Cost = new ManaGroup
			{
				Black = 1
			};
			cardDefaultConfig.Rarity = Rarity.Uncommon;
			cardDefaultConfig.Type = CardType.Skill;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.Self);
			cardDefaultConfig.Value1 = new int?(10);
			cardDefaultConfig.Mana = new ManaGroup?(new ManaGroup
			{
				Black = 2,
				Red = 2
			});
			cardDefaultConfig.UpgradedMana = new ManaGroup?(new ManaGroup
			{
				Philosophy = 2,
				Red = 2
			});
			cardDefaultConfig.Keywords = Keyword.Ethereal;
			cardDefaultConfig.UpgradedKeywords = Keyword.Ethereal;
			cardDefaultConfig.RelativeEffects = new List<string> { "sedecrease" };
			cardDefaultConfig.UpgradedRelativeEffects = new List<string> { "sedecrease" };
			cardDefaultConfig.Illustrator = "OMGitsANeevee";
			cardDefaultConfig.Index = CardIndexGenerator.GetUniqueIndex(cardDefaultConfig);
			return cardDefaultConfig;
		}
	}
}
