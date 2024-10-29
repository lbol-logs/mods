using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using PatchouliCharacterMod.Cards.Template;
using PatchouliCharacterMod.GunName;
using PatchouliCharacterMod.Illustrator;

namespace PatchouliCharacterMod.Cards
{
	public sealed class PatchouliObservatoryDef : PatchouliCardTemplate
	{
		public override CardConfig MakeConfig()
		{
			CardConfig cardDefaultConfig = base.GetCardDefaultConfig();
			cardDefaultConfig.Index = 5120;
			cardDefaultConfig.GunName = PatchouliGunName.PatchouliObservatory;
			cardDefaultConfig.Colors = new List<ManaColor> { ManaColor.Blue };
			cardDefaultConfig.Cost = new ManaGroup
			{
				Any = 1,
				Blue = 1
			};
			cardDefaultConfig.Rarity = Rarity.Common;
			cardDefaultConfig.Owner = this.OwnerName;
			cardDefaultConfig.Type = CardType.Attack;
			cardDefaultConfig.TargetType = new TargetType?(TargetType.SingleEnemy);
			cardDefaultConfig.Damage = new int?(14);
			cardDefaultConfig.UpgradedDamage = new int?(18);
			cardDefaultConfig.Value1 = new int?(1);
			cardDefaultConfig.Value2 = new int?(1);
			cardDefaultConfig.RelativeCards = new List<string> { "PatchouliAstronomy" };
			cardDefaultConfig.UpgradedRelativeCards = new List<string> { "PatchouliAstronomy" };
			cardDefaultConfig.Illustrator = PatchouliIllustrator.PatchouliObservatory;
			return cardDefaultConfig;
		}
	}
}
