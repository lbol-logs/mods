using System;
using System.Collections.Generic;
using System.Linq;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Intentions;
using LBoL.Core.Units;
using LBoL.EntityLib.StatusEffects.Basic;
using LBoLEntitySideloader.Attributes;

namespace Momiji.Source.Cards
{
	[EntityLogic(typeof(FarSightDef))]
	public sealed class FarSight : SampleCharacterCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			int attackCount = 0;
			EnemyUnit[] enemies = selector.GetEnemies(base.Battle);
			attackCount = enemies.Count((EnemyUnit enemy) => enemy.Intentions.Any(delegate(Intention i)
			{
				bool flag3 = !(i is AttackIntention);
				if (flag3)
				{
					SpellCardIntention spellCardIntention = i as SpellCardIntention;
					bool flag4 = spellCardIntention == null || spellCardIntention.Damage == null;
					if (flag4)
					{
						return false;
					}
				}
				return true;
			}));
			yield return new ApplyStatusEffectAction<Reflect>(base.Battle.Player, new int?(base.Value1), new int?(0), new int?(0), new int?(0), 0.2f, true);
			bool flag = base.Battle.Player.HasStatusEffect<Reflect>();
			if (flag)
			{
				base.Battle.Player.GetStatusEffect<Reflect>().Gun = (this.IsUpgraded ? "心抄斩B" : "心抄斩");
			}
			bool flag2 = attackCount > 0;
			if (flag2)
			{
				yield return base.DefenseAction(true);
			}
			yield break;
		}
	}
}
