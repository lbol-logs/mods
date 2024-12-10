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
	[EntityLogic(typeof(SeizeTheMomentDef))]
	public sealed class SeizeTheMoment : SampleCharacterCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			EnemyUnit selectedEnemy = selector.SelectedEnemy;
			yield return base.AttackAction(selector, base.GunName);
			int intention = base.IntentionCheck(selectedEnemy);
			bool flag = intention == 1 || intention == 3 || intention == 5;
			if (flag)
			{
				yield return new ApplyStatusEffectAction<TempFirepowerNegative>(selectedEnemy, new int?(base.Value1), new int?(0), new int?(0), new int?(0), 0.2f, true);
			}
			bool flag2 = intention == 2 || intention == 3 || intention == 6;
			if (flag2)
			{
				yield return new ApplyStatusEffectAction<Vulnerable>(selectedEnemy, new int?(0), new int?(base.Value2), new int?(0), new int?(0), 0.2f, true);
			}
			yield return new ApplyStatusEffectAction<SpiritNegative>(selectedEnemy, new int?(base.Value1), new int?(0), new int?(0), new int?(0), 0.2f, true);
			bool flag3 = intention >= 4;
			if (flag3)
			{
				yield return base.AttackAction(selector, base.GunName);
			}
			yield break;
		}
	}
}
