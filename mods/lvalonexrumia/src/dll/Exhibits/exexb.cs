using System;
using System.Collections.Generic;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Units;
using LBoL.EntityLib.Exhibits;
using LBoLEntitySideloader.Attributes;
using lvalonexrumia.Patches;
using lvalonexrumia.StatusEffects;

namespace lvalonexrumia.Exhibits
{
	[EntityLogic(typeof(exexbDef))]
	public sealed class exexb : ShiningExhibit
	{
		protected override void OnEnterBattle()
		{
			base.ReactBattleEvent<UnitEventArgs>(base.Battle.Player.TurnStarted, new EventSequencedReactor<UnitEventArgs>(this.OnPlayerTurnStarted));
			base.ReactBattleEvent<StatisticalDamageEventArgs>(base.Battle.Player.StatisticalTotalDamageDealt, new EventSequencedReactor<StatisticalDamageEventArgs>(this.OnStatisticalDamageDealt));
			base.ReactBattleEvent<DamageEventArgs>(base.Battle.Player.DamageReceived, new EventSequencedReactor<DamageEventArgs>(this.OnDamageReceived));
			base.ReactBattleEvent<DamageEventArgs>(base.Battle.Player.DamageDealt, new EventSequencedReactor<DamageEventArgs>(this.OnDamageDealt));
			base.ReactBattleEvent<ChangeLifeEventArgs>(CustomGameEventManager.PostChangeLifeEvent, new EventSequencedReactor<ChangeLifeEventArgs>(this.OnLifeChanged));
			base.Active = true;
		}

		private IEnumerable<BattleAction> OnDamageReceived(DamageEventArgs args)
		{
			bool flag = args.DamageInfo.Damage == 0f;
			if (flag)
			{
				yield break;
			}
			foreach (BattleAction action in this.HandleLifeChanged(args.Target, (int)args.DamageInfo.Damage * -1, args.Source, args.Cause, args.ActionSource))
			{
				yield return action;
				action = null;
			}
			IEnumerator<BattleAction> enumerator = null;
			yield break;
			yield break;
		}

		private IEnumerable<BattleAction> OnLifeChanged(ChangeLifeEventArgs args)
		{
			foreach (BattleAction action in this.HandleLifeChanged(args.argsunit, args.Amount, base.Battle.Player, args.Cause, args.ActionSource))
			{
				yield return action;
				action = null;
			}
			IEnumerator<BattleAction> enumerator = null;
			yield break;
			yield break;
		}

		private IEnumerable<BattleAction> HandleLifeChanged(Unit receive, int amount, Unit source, ActionCause cause, GameEntity actionSource)
		{
			bool battleShouldEnd = base.Battle.BattleShouldEnd;
			if (battleShouldEnd)
			{
				yield break;
			}
			bool flag = actionSource != this && amount < 0 && (receive == null || receive == base.Battle.Player);
			if (flag)
			{
				foreach (Unit unit in base.Battle.AllAliveEnemies)
				{
					bool flag2 = unit.IsAlive && !base.Battle.BattleShouldEnd;
					if (flag2)
					{
						base.NotifyActivating();
						yield return new ChangeLifeAction(amount, unit);
					}
					unit = null;
				}
				IEnumerator<EnemyUnit> enumerator = null;
			}
			yield break;
			yield break;
		}

		private IEnumerable<BattleAction> OnPlayerTurnStarted(UnitEventArgs args)
		{
			base.Active = true;
			yield break;
		}

		private IEnumerable<BattleAction> OnDamageDealt(DamageEventArgs args)
		{
			bool flag = base.Battle.BattleShouldEnd || !base.Active;
			if (flag)
			{
				yield break;
			}
			bool active = base.Active;
			if (active)
			{
				base.NotifyActivating();
				base.Active = false;
				foreach (Unit unit in base.Battle.AllAliveEnemies)
				{
					yield return new ApplyStatusEffectAction<sebleed>(unit, new int?(base.Value1), new int?(0), new int?(0), new int?(0), 0.2f, true);
					unit = null;
				}
				IEnumerator<EnemyUnit> enumerator = null;
			}
			yield break;
			yield break;
		}

		private IEnumerable<BattleAction> OnStatisticalDamageDealt(StatisticalDamageEventArgs args)
		{
			yield break;
		}

		protected override void OnLeaveBattle()
		{
			base.Active = false;
		}
	}
}
