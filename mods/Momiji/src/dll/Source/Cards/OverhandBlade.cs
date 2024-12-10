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
	[EntityLogic(typeof(OverhandBladeDef))]
	public sealed class OverhandBlade : SampleCharacterCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			EnemyUnit selectedEnemy = selector.SelectedEnemy;
			bool weakCheck = false;
			bool vulnCheck = false;
			yield return base.AttackAction(selector, base.GunName);
			bool flag = selectedEnemy.HasStatusEffect<Vulnerable>();
			if (flag)
			{
				vulnCheck = true;
			}
			bool flag2 = selectedEnemy.HasStatusEffect<Weak>();
			if (flag2)
			{
				weakCheck = true;
			}
			bool flag3 = vulnCheck;
			if (flag3)
			{
				yield return new ApplyStatusEffectAction<Weak>(selectedEnemy, new int?(0), new int?(base.Value1), new int?(0), new int?(0), 0.2f, true);
			}
			bool flag4 = weakCheck;
			if (flag4)
			{
				yield return new ApplyStatusEffectAction<Vulnerable>(selectedEnemy, new int?(0), new int?(base.Value1), new int?(0), new int?(0), 0.2f, true);
			}
			yield break;
		}
	}
}
