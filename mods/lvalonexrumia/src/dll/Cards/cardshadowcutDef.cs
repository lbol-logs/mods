using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using lvalonexrumia.Cards.Template;
using lvalonexrumia.GunName;

namespace lvalonexrumia.Cards
{
	public sealed class cardshadowcutDef : lvalonexrumiaCardTemplate
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
				Any = 3,
				Black = 1,
				Red = 1
			};
			cardDefaultConfig.Rarity = Rarity.Uncommon;
			cardDefaultConfig.Type = CardType.Attack;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.AllEnemies);
			cardDefaultConfig.Damage = new int?(5);
			cardDefaultConfig.Value1 = new int?(5);
			cardDefaultConfig.Value2 = new int?(5);
			cardDefaultConfig.GunName = GunNameID.GetGunFromId(7161);
			cardDefaultConfig.GunNameBurst = GunNameID.GetGunFromId(7161);
			cardDefaultConfig.Keywords = Keyword.Accuracy | Keyword.Exile | Keyword.Ethereal;
			cardDefaultConfig.UpgradedKeywords = Keyword.Accuracy | Keyword.Exile | Keyword.Retain;
			cardDefaultConfig.RelativeEffects = new List<string> { "ExtraTurn" };
			cardDefaultConfig.UpgradedRelativeEffects = new List<string> { "ExtraTurn" };
			cardDefaultConfig.Illustrator = "初屋";
			cardDefaultConfig.Index = CardIndexGenerator.GetUniqueIndex(cardDefaultConfig);
			return cardDefaultConfig;
		}
	}
}
