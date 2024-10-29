using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using PatchouliCharacterMod.Cards.Template;
using PatchouliCharacterMod.Illustrator;

namespace PatchouliCharacterMod.Cards
{
	public sealed class PatchouliCountersquallDef : PatchouliCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.Index = 5910;
			cardDefaultConfig.GunName = PatchouliIllustrator.PatchouliCountersquall;
			cardDefaultConfig.HideMesuem = true;
			cardDefaultConfig.IsPooled = false;
			cardDefaultConfig.Colors = new List<ManaColor>
			{
				ManaColor.Blue,
				ManaColor.Black
			};
			cardDefaultConfig.Cost = new ManaGroup
			{
				Blue = 1,
				Black = 1
			};
			cardDefaultConfig.Rarity = Rarity.Rare;
			cardDefaultConfig.Owner = this.OwnerName;
			cardDefaultConfig.Type = CardType.Skill;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.SingleEnemy);
			cardDefaultConfig.Damage = new int?(7);
			cardDefaultConfig.UpgradedDamage = new int?(9);
			cardDefaultConfig.Block = new int?(7);
			cardDefaultConfig.UpgradedBlock = new int?(9);
			cardDefaultConfig.Value1 = new int?(1);
			cardDefaultConfig.Keywords = Keyword.Exile;
			cardDefaultConfig.UpgradedKeywords = Keyword.Exile;
			cardDefaultConfig.RelativeEffects = new List<string> { "PatchouliCounterSe" };
			cardDefaultConfig.UpgradedRelativeEffects = new List<string> { "PatchouliCounterSe" };
			cardDefaultConfig.Illustrator = PatchouliIllustrator.PatchouliCountersquall;
			return cardDefaultConfig;
		}
	}
}
