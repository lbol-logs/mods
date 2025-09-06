using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using lvalonexrumia.Cards.Template;

namespace lvalonexrumia.Cards
{
	public sealed class cardmixedbloodDef : lvalonexrumiaCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.Colors = new List<ManaColor>
			{
				ManaColor.Black,
				ManaColor.Red
			};
			cardDefaultConfig.Cost = new ManaGroup
			{
				Any = 1,
				Black = 1,
				Red = 1
			};
			cardDefaultConfig.Rarity = Rarity.Rare;
			cardDefaultConfig.Type = CardType.Skill;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.Self);
			cardDefaultConfig.Value1 = new int?(1);
			cardDefaultConfig.RelativeEffects = new List<string> { "sedarkblood" };
			cardDefaultConfig.UpgradedRelativeEffects = new List<string> { "sedarkblood" };
			cardDefaultConfig.RelativeCards = new List<string> { "carddarkblood", "cardredblood" };
			cardDefaultConfig.UpgradedRelativeCards = new List<string> { "carddarkblood", "cardredblood" };
			cardDefaultConfig.Illustrator = "万休(万事休す)";
			cardDefaultConfig.Index = CardIndexGenerator.GetUniqueIndex(cardDefaultConfig);
			return cardDefaultConfig;
		}
	}
}
