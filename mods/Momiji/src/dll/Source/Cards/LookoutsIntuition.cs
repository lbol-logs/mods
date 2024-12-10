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
	[EntityLogic(typeof(LookoutsIntuitionDef))]
	public sealed class LookoutsIntuition : SampleCharacterCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			int count = 0;
			EnemyUnit selectedEnemy = selector.SelectedEnemy;
			yield return base.BuffAction<Graze>(base.Value1, 0, 0, 0, 0.2f);
			bool flag = selectedEnemy.HasStatusEffect<Vulnerable>();
			if (flag)
			{
				count = selectedEnemy.GetStatusEffect<Vulnerable>().Duration / base.Value2;
				yield return new CastBlockShieldAction(base.Battle.Player, 0, count * base.Shield.Shield, BlockShieldType.Normal, false);
			}
			yield break;
		}
	}
}
