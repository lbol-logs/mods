using System;
using System.Collections.Generic;
using System.Linq;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoLEntitySideloader.Attributes;
using Sanae_Kochiya.Cards.Template;

namespace Sanae_Kochiya.Source.Cards.Offcolor
{
	[EntityLogic(typeof(SanaeAttackWeakDef))]
	public sealed class SanaeAttackWeak : SampleCharacterCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			EnemyUnit target = selector.GetEnemy(base.Battle);
			yield return base.DebuffAction<Weak>(target, 0, base.Value1, 0, 0, true, 0.2f);
			List<Unit> list = base.Battle.EnemyGroup.Alives.Where((EnemyUnit enemy) => enemy != target).Cast<Unit>().ToList<Unit>();
			bool flag = list.Count > 0;
			if (flag)
			{
				yield return base.AttackAction(list);
			}
			yield break;
		}
	}
}
