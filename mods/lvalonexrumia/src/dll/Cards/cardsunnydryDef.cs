using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using lvalonexrumia.Cards.Template;

namespace lvalonexrumia.Cards
{
	public sealed class cardsunnydryDef : lvalonexrumiaCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.Colors = new List<ManaColor> { ManaColor.Red };
			cardDefaultConfig.Cost = new ManaGroup
			{
				Red = 2
			};
			cardDefaultConfig.UpgradedCost = new ManaGroup?(new ManaGroup
			{
				Any = 1,
				Red = 1
			});
			cardDefaultConfig.Rarity = Rarity.Uncommon;
			cardDefaultConfig.Type = CardType.Skill;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.Self);
			cardDefaultConfig.Value1 = new int?(5);
			cardDefaultConfig.Value2 = new int?(4);
			cardDefaultConfig.UpgradedValue2 = new int?(6);
			cardDefaultConfig.UpgradedKeywords = Keyword.Replenish;
			cardDefaultConfig.Mana = new ManaGroup?(new ManaGroup
			{
				Red = 3,
				Philosophy = 1
			});
			cardDefaultConfig.UpgradedMana = new ManaGroup?(new ManaGroup
			{
				Red = 2,
				Philosophy = 2
			});
			cardDefaultConfig.RelativeEffects = new List<string> { "sedecrease", "sebloodclot" };
			cardDefaultConfig.UpgradedRelativeEffects = new List<string> { "sedecrease", "sebloodclot" };
			cardDefaultConfig.RelativeCards = new List<string> { "Riguang" };
			cardDefaultConfig.UpgradedRelativeCards = new List<string> { "Riguang" };
			cardDefaultConfig.Illustrator = "六合ダイスケ";
			cardDefaultConfig.Index = CardIndexGenerator.GetUniqueIndex(cardDefaultConfig);
			return cardDefaultConfig;
		}
	}
}
