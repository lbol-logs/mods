using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoLEntitySideloader.Attributes;

namespace Momiji.Source.Cards
{
	[EntityLogic(typeof(HuntingCallDef))]
	public sealed class HuntingCall : SampleCharacterCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			int intention = 0;
			int count = 0;
			EnemyUnit[] enemies = selector.GetEnemies(base.Battle);
			foreach (EnemyUnit enemyUnit in enemies)
			{
				yield return new ApplyStatusEffectAction<Vulnerable>(enemyUnit, new int?(0), new int?(base.Value1), new int?(0), new int?(0), 0.2f, true);
				intention = base.IntentionCheck(enemyUnit);
				bool flag = intention == 1 || intention == 3 || intention == 5 || intention == 7;
				if (flag)
				{
					int num = count;
					count = num + 1;
				}
				enemyUnit = null;
			}
			EnemyUnit[] array = null;
			bool flag2 = count > 0;
			if (flag2)
			{
				yield return new DrawManyCardAction(base.Value2);
			}
			yield break;
		}
	}
}
