using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoLEntitySideloader.Attributes;

namespace Momiji.Source.Cards
{
	[EntityLogic(typeof(GuardBreakDef))]
	public sealed class GuardBreak : SampleCharacterCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			EnemyUnit selectedEnemy = selector.SelectedEnemy;
			yield return base.AttackAction(selector, base.GunName);
			yield return base.AttackAction(selector, base.GunName);
			bool isUpgraded = this.IsUpgraded;
			if (isUpgraded)
			{
				yield return base.AttackAction(selector, base.GunName);
			}
			bool battleShouldEnd = base.Battle.BattleShouldEnd;
			if (battleShouldEnd)
			{
				yield break;
			}
			yield return base.DebuffAction<Vulnerable>(selectedEnemy, 0, base.Value1, 0, 0, true, 0.03f);
			yield break;
		}
	}
}
