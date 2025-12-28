using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using ReimuUnifierMod.Cards.Template;

namespace ReimuUnifierMod.Cards
{
	public sealed class ReimuUnifierCombatRoleAssignmentDef : ReimuUnifierCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.IsPooled = true;
			cardDefaultConfig.GunName = "博丽一拳";
			cardDefaultConfig.Colors = new List<ManaColor>
			{
				ManaColor.White,
				ManaColor.Red
			};
			cardDefaultConfig.Cost = new ManaGroup
			{
				White = 1,
				Red = 1
			};
			cardDefaultConfig.UpgradedCost = new ManaGroup?(new ManaGroup
			{
				Hybrid = 1,
				HybridColor = 2
			});
			cardDefaultConfig.Rarity = Rarity.Uncommon;
			cardDefaultConfig.Type = CardType.Skill;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.Nobody);
			cardDefaultConfig.Damage = new int?(6);
			cardDefaultConfig.UpgradedDamage = new int?(6);
			cardDefaultConfig.Block = new int?(6);
			cardDefaultConfig.UpgradedBlock = new int?(6);
			cardDefaultConfig.RelativeEffects = new List<string> { "TeamUpSe" };
			cardDefaultConfig.UpgradedRelativeEffects = new List<string> { "TeamUpSe" };
			cardDefaultConfig.RelativeKeyword = Keyword.Block | Keyword.Friend;
			cardDefaultConfig.UpgradedRelativeKeyword = Keyword.Block | Keyword.Friend;
			cardDefaultConfig.Illustrator = "Saevin";
			cardDefaultConfig.Index = CardIndexGenerator.GetUniqueIndex(cardDefaultConfig);
			return cardDefaultConfig;
		}
	}
}
