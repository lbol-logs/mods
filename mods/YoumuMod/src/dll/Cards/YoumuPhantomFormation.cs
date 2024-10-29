using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoLEntitySideloader.Attributes;
using YoumuCharacterMod.Cards.Template;

namespace YoumuCharacterMod.Cards
{
	[EntityLogic(typeof(YoumuPhantomFormationDef))]
	public sealed class YoumuPhantomFormation : YoumuCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			yield return base.DefenseAction(true);
			foreach (Unit enemyUnit in base.Battle.AllAliveEnemies)
			{
				bool flag = enemyUnit.HasStatusEffect<LockedOn>();
				if (flag)
				{
					yield return base.DebuffAction<TempFirepowerNegative>(enemyUnit, base.Value1, 0, 0, 0, true, 0.2f);
				}
				enemyUnit = null;
			}
			IEnumerator<EnemyUnit> enumerator = null;
			yield break;
			yield break;
		}
	}
}
