using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using PatchouliCharacterMod.Cards.Template;
using PatchouliCharacterMod.Illustrator;

namespace PatchouliCharacterMod.Cards
{
	public sealed class PatchouliSpellCreationDrawDef : PatchouliCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.Index = 5711;
			cardDefaultConfig.HideMesuem = true;
			cardDefaultConfig.IsPooled = false;
			cardDefaultConfig.Colors = new List<ManaColor>
			{
				ManaColor.Blue,
				ManaColor.Green
			};
			cardDefaultConfig.Cost = default(ManaGroup);
			cardDefaultConfig.Rarity = Rarity.Common;
			cardDefaultConfig.Owner = this.OwnerName;
			cardDefaultConfig.Type = CardType.Skill;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.Self);
			cardDefaultConfig.Value1 = new int?(1);
			cardDefaultConfig.RelativeEffects = new List<string> { "PatchouliBoostSe" };
			cardDefaultConfig.UpgradedRelativeEffects = new List<string> { "PatchouliBoostSe" };
			cardDefaultConfig.Illustrator = PatchouliIllustrator.PatchouliSpellCreationDraw;
			return cardDefaultConfig;
		}
	}
}
