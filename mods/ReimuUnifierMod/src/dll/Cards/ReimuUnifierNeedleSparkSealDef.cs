using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using ReimuUnifierMod.Cards.Template;

namespace ReimuUnifierMod.Cards
{
	public sealed class ReimuUnifierNeedleSparkSealDef : ReimuUnifierCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.Colors = new List<ManaColor> { ManaColor.Red };
			cardDefaultConfig.Cost = new ManaGroup
			{
				Red = 2,
				Any = 1
			};
			cardDefaultConfig.UpgradedCost = new ManaGroup?(new ManaGroup
			{
				Red = 1,
				Any = 1
			});
			cardDefaultConfig.Rarity = Rarity.Rare;
			cardDefaultConfig.Type = CardType.Ability;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.Nobody);
			cardDefaultConfig.RelativeEffects = new List<string> { "TeamUpSe", "LockedOn" };
			cardDefaultConfig.UpgradedRelativeEffects = new List<string> { "TeamUpSe", "LockedOn" };
			cardDefaultConfig.RelativeKeyword = Keyword.Friend;
			cardDefaultConfig.UpgradedRelativeKeyword = Keyword.Friend;
			cardDefaultConfig.RelativeCards = new List<string> { "ReimuUnifierYoukaiForgedNeedle" };
			cardDefaultConfig.UpgradedRelativeCards = new List<string> { "ReimuUnifierYoukaiForgedNeedle" };
			cardDefaultConfig.Illustrator = "";
			cardDefaultConfig.Index = CardIndexGenerator.GetUniqueIndex(cardDefaultConfig);
			return cardDefaultConfig;
		}
	}
}
