using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Intentions;
using LBoL.Core.StatusEffects;
using LBoLEntitySideloader.Attributes;
using PatchouliCharacterMod.Cards.Template;

namespace PatchouliCharacterMod.Cards
{
	[EntityLogic(typeof(PatchouliCounterspellDef))]
	public sealed class PatchouliCounterspell : PatchouliCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			bool flag = PatchouliCounterUtils.EnemyIntendsToAttack(selector.SelectedEnemy);
			if (flag)
			{
				yield return base.BuffAction<Graze>(base.Value1, 0, 0, 0, 0.2f);
			}
			bool flag2 = PatchouliCounterUtils.EnemyIntendsToAccurateAttack(selector.SelectedEnemy);
			if (flag2)
			{
				yield return new CastBlockShieldAction(base.Battle.Player, this.Block.Block, 0, BlockShieldType.Normal, true);
			}
			bool flag3 = PatchouliCounterUtils.EnemyHasIntent<SpellCardIntention>(selector.SelectedEnemy);
			if (flag3)
			{
				yield return new CastBlockShieldAction(base.Battle.Player, 0, base.Shield.Shield, BlockShieldType.Normal, true);
			}
			yield break;
		}
	}
}
