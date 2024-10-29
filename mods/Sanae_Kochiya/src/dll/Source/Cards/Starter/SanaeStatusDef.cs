using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using Sanae_Kochiya.Cards.Template;

namespace Sanae_Kochiya.Source.Cards.Starter
{
	public sealed class SanaeStatusDef : SampleCharacterCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.IsPooled = false;
			cardDefaultConfig.IsUpgradable = false;
			cardDefaultConfig.Colors = new List<ManaColor>
			{
				ManaColor.White,
				ManaColor.Blue
			};
			cardDefaultConfig.Cost = new ManaGroup
			{
				Any = 2
			};
			cardDefaultConfig.Rarity = Rarity.Uncommon;
			cardDefaultConfig.Type = CardType.Status;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.Self);
			cardDefaultConfig.Block = new int?(3);
			cardDefaultConfig.Shield = new int?(3);
			cardDefaultConfig.Keywords = Keyword.Forbidden | Keyword.Replenish | Keyword.AutoExile;
			cardDefaultConfig.RelativeKeyword = Keyword.Block | Keyword.Shield;
			cardDefaultConfig.Illustrator = "Xeno";
			cardDefaultConfig.Index = CardIndexGenerator.Initial_offset + 99701;
			return cardDefaultConfig;
		}
	}
}
