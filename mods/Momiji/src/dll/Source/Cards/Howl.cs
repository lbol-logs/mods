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
	[EntityLogic(typeof(HowlDef))]
	public sealed class Howl : SampleCharacterCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			EnemyUnit selectedEnemy = selector.SelectedEnemy;
			int count = base.IntentionCheck(selectedEnemy);
			bool flag = count == 1 || count == 3 || count == 5 || count == 7;
			if (flag)
			{
				yield return new ApplyStatusEffectAction<FirepowerNegative>(selectedEnemy, new int?(base.Value1), new int?(0), new int?(0), new int?(0), 0.2f, true);
			}
			yield break;
		}
	}
}
