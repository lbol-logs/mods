using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Intentions;
using LBoL.EntityLib.StatusEffects.Basic;
using LBoLEntitySideloader.Attributes;
using PatchouliCharacterMod.Cards.Template;

namespace PatchouliCharacterMod.Cards
{
	[EntityLogic(typeof(PatchouliCountersquallDef))]
	public sealed class PatchouliCountersquall : PatchouliCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			bool flag = PatchouliCounterUtils.EnemyIntendsToAttack(selector.SelectedEnemy);
			if (flag)
			{
				yield return base.AttackAction(selector, base.GunName);
				yield return base.DefenseAction(true);
			}
			bool flag2 = PatchouliCounterUtils.EnemyHasIntent<NegativeEffectIntention>(selector.SelectedEnemy);
			if (flag2)
			{
				yield return base.BuffAction<Amulet>(base.Value1, 0, 0, 0, 0.2f);
			}
			yield break;
		}
	}
}
