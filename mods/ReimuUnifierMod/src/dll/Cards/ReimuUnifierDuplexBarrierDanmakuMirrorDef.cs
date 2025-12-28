using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using ReimuUnifierMod.Cards.Template;

namespace ReimuUnifierMod.Cards
{
	public sealed class ReimuUnifierDuplexBarrierDanmakuMirrorDef : ReimuUnifierCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.Colors = new List<ManaColor>
			{
				ManaColor.White,
				ManaColor.Red
			};
			cardDefaultConfig.Cost = new ManaGroup
			{
				Hybrid = 1,
				HybridColor = 2,
				Red = 2,
				White = 2
			};
			cardDefaultConfig.UpgradedCost = new ManaGroup?(new ManaGroup
			{
				Hybrid = 1,
				HybridColor = 2,
				Red = 2,
				White = 2
			});
			cardDefaultConfig.Rarity = Rarity.Rare;
			cardDefaultConfig.Type = CardType.Ability;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.Nobody);
			cardDefaultConfig.Mana = new ManaGroup?(ManaGroup.Empty);
			cardDefaultConfig.Keywords = Keyword.Ethereal;
			cardDefaultConfig.UpgradedKeywords = Keyword.Initial | Keyword.Retain;
			cardDefaultConfig.RelativeKeyword = Keyword.Ethereal | Keyword.Friend | Keyword.Loyalty;
			cardDefaultConfig.UpgradedRelativeKeyword = Keyword.Ethereal | Keyword.Friend | Keyword.Loyalty;
			cardDefaultConfig.Illustrator = "";
			cardDefaultConfig.Index = CardIndexGenerator.GetUniqueIndex(cardDefaultConfig);
			return cardDefaultConfig;
		}
	}
}
