using System;
using System.Collections.Generic;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoLEntitySideloader.Attributes;

namespace ReimuUnifierMod.StatusEffects
{
	[EntityLogic(typeof(ReimuUnifierYukariLifeLossSeDef))]
	public sealed class ReimuUnifierYukariLifeLossSe : StatusEffect
	{
		protected override void OnAdded(Unit unit)
		{
			base.ReactOwnerEvent<UnitEventArgs>(base.Owner.TurnStarted, new EventSequencedReactor<UnitEventArgs>(this.OnOwnerTurnStarted));
		}

		private IEnumerable<BattleAction> OnOwnerTurnStarted(UnitEventArgs args)
		{
			base.NotifyActivating();
			foreach (Unit enemy in base.Battle.AllAliveEnemies)
			{
				yield return DamageAction.LoseLife(enemy, base.Level, "Instant");
				enemy = null;
			}
			IEnumerator<EnemyUnit> enumerator = null;
			yield return new RemoveStatusEffectAction(this, true, 0.1f);
			yield break;
			yield break;
		}
	}
}
