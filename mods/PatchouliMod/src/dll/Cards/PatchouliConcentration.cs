using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoLEntitySideloader.Attributes;
using PatchouliCharacterMod.BattleActions;
using PatchouliCharacterMod.Cards.Template;

namespace PatchouliCharacterMod.Cards
{
	[EntityLogic(typeof(PatchouliConcentrationDef))]
	public sealed class PatchouliConcentration : PatchouliBoostCard
	{
		protected override bool HasTreshold { get; set; } = true;

		protected override int BoostThreshold1 { get; set; } = 3;

		protected override int BoostThreshold2 { get; set; } = 5;

		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			yield return new DrawManyCardAction(base.Value1);
			bool flag = base.Boost >= this.BoostThreshold1;
			if (flag)
			{
				int defense = base.Value2 + ((base.Boost >= this.BoostThreshold2) ? base.Value2 : 0);
				yield return new CastBlockShieldAction(base.Battle.Player, new BlockInfo(defense, BlockShieldType.Direct), false);
				base.ResetBoost();
			}
			yield return new BoostAllInHandAction(1);
			yield break;
		}
	}
}
