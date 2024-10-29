using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Intentions;
using LBoL.Core.Units;
using LBoL.EntityLib.StatusEffects.Basic;
using LBoLEntitySideloader.Attributes;
using Sanae_Kochiya.Cards.Template;

namespace Sanae_Kochiya.Source.Cards.Uncommon
{
	[EntityLogic(typeof(SanaeAttackRebuffDef))]
	public sealed class SanaeAttackRebuff : SampleCharacterCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			bool rebuff = false;
			EnemyUnit[] enemies = selector.GetEnemies(base.Battle);
			foreach (EnemyUnit enemy in enemies)
			{
				foreach (Intention i in enemy.Intentions)
				{
					bool flag = i is NegativeEffectIntention;
					if (flag)
					{
						rebuff = true;
					}
					i = null;
				}
				List<Intention>.Enumerator enumerator = default(List<Intention>.Enumerator);
				enemy = null;
			}
			EnemyUnit[] array = null;
			yield return base.AttackAction(selector, null);
			bool flag2 = rebuff;
			if (flag2)
			{
				yield return base.BuffAction<Amulet>(base.Value1, 0, 0, 0, 0.2f);
			}
			yield break;
		}
	}
}
