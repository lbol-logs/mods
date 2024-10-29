using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.EntityLib.StatusEffects.Basic;
using LBoLEntitySideloader.Attributes;
using PatchouliCharacterMod.Cards.Template;

namespace PatchouliCharacterMod.Cards
{
	[EntityLogic(typeof(PatchouliAutumnBladeDef))]
	public sealed class PatchouliAutumnBlade : PatchouliBoostCard
	{
		protected override bool HasTreshold { get; set; } = true;

		protected override int BoostThreshold1 { get; set; } = 3;

		protected override int BoostThreshold2 { get; set; } = 5;

		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			yield return base.AttackAction(selector, base.GunName);
			bool flag = base.Boost >= this.BoostThreshold2 && !base.Battle.BattleShouldEnd;
			if (flag)
			{
				yield return base.BuffAction<Amulet>(base.Value2, 0, 0, 0, 0.2f);
			}
			bool flag2 = base.Boost >= this.BoostThreshold1 && !base.Battle.BattleShouldEnd;
			if (flag2)
			{
				yield return base.BuffAction<AmuletForCard>(base.Value1, 0, 0, 0, 0.2f);
				base.ResetBoost();
			}
			yield break;
		}
	}
}
