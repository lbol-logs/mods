using System;
using System.Collections.Generic;
using System.Linq;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Intentions;
using LBoL.Core.Units;
using LBoLEntitySideloader.Attributes;

namespace Momiji.Source.Cards
{
	[EntityLogic(typeof(DoubleDownDef))]
	public sealed class DoubleDown : SampleCharacterCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			bool notAttacking = false;
			EnemyUnit selectedEnemy = selector.SelectedEnemy;
			notAttacking = selectedEnemy.Intentions.Any(delegate(Intention i)
			{
				bool flag2 = i is AttackIntention;
				bool flag3;
				if (flag2)
				{
					flag3 = false;
				}
				else
				{
					SpellCardIntention spellCardIntention = i as SpellCardIntention;
					bool flag4 = spellCardIntention != null && spellCardIntention.Damage != null;
					flag3 = !flag4;
				}
				return flag3;
			});
			yield return base.AttackAction(selector, base.GunName);
			bool flag = notAttacking;
			if (!flag)
			{
				yield break;
			}
			bool isUpgraded = this.IsUpgraded;
			if (isUpgraded)
			{
				yield return base.AttackAction(selector, base.GunName);
				yield return base.AttackAction(selector, base.GunName);
				yield break;
			}
			yield return base.AttackAction(selector, base.GunName);
			yield break;
		}
	}
}
