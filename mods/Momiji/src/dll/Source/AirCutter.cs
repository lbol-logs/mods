using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoL.EntityLib.StatusEffects.Cirno;
using LBoLEntitySideloader.Attributes;
using Momiji.Source.StatusEffects;

namespace Momiji.Source
{
	[EntityLogic(typeof(AirCutterDef))]
	public sealed class AirCutter : SampleCharacterCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			EnemyUnit selectedEnemy = selector.SelectedEnemy;
			yield return base.AttackAction(selector, base.GunName);
			yield return base.DefenseAction(true);
			bool flag = base.Battle.Player.HasStatusEffect<HowlingMountainWindSe>() && selectedEnemy.HasStatusEffect<Vulnerable>();
			if (flag)
			{
				yield return base.AttackAction(selector, base.GunName);
			}
			bool flag2 = base.Battle.Player.HasStatusEffect<BlackWindSe>();
			if (flag2)
			{
				yield return new ApplyStatusEffectAction<Vulnerable>(selectedEnemy, new int?(0), new int?(1), new int?(0), new int?(0), 0.2f, true);
			}
			bool flag3 = base.Battle.Player.HasStatusEffect<FrigidSkySe>();
			if (flag3)
			{
				yield return base.DebuffAction<Cold>(selectedEnemy, 0, 0, 0, 0, true, 0.03f);
			}
			yield break;
		}
	}
}
