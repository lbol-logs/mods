using System;
using System.Collections.Generic;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Units;
using lvalonexrumia.Patches;

namespace lvalonexrumia.Cards.Template
{
	public abstract class reactcard : lvalonexrumiaCard
	{
		protected override void OnEnterBattle(BattleController battle)
		{
			base.ReactBattleEvent<GameEventArgs>(base.Battle.BattleEnded, new EventSequencedReactor<GameEventArgs>(this.OnBattleEnded), (GameEventPriority)0);
			base.HandleBattleEvent<HealEventArgs>(base.Battle.Player.HealingReceived, new GameEventHandler<HealEventArgs>(this.OnHealingReceived), (GameEventPriority)0);
			base.HandleBattleEvent<GameEventArgs>(base.Battle.BattleStarting, new GameEventHandler<GameEventArgs>(this.OnBattleStarting), (GameEventPriority)0);
		}

		private IEnumerable<BattleAction> OnBattleEnded(GameEventArgs args)
		{
			yield return new RemoveCardAction(this);
			yield break;
		}

		protected virtual void OnBattleStarting(GameEventArgs args)
		{
			base.ReactBattleEvent<ChangeLifeEventArgs>(CustomGameEventManager.PostChangeLifeEvent, new EventSequencedReactor<ChangeLifeEventArgs>(this.OnLifeChanged));
			foreach (Unit unit in base.Battle.AllAliveUnits)
			{
				base.ReactBattleEvent<DamageEventArgs>(unit.DamageReceived, new EventSequencedReactor<DamageEventArgs>(this.OnDamageReceived));
			}
			base.HandleBattleEvent<UnitEventArgs>(base.Battle.EnemySpawned, new GameEventHandler<UnitEventArgs>(this.OnEnemySpawned), (GameEventPriority)0);
		}

		protected virtual void OnHealingReceived(HealEventArgs args)
		{
			bool battleShouldEnd = base.Battle.BattleShouldEnd;
			if (battleShouldEnd)
			{
			}
		}

		protected virtual void OnEnemySpawned(UnitEventArgs args)
		{
			base.ReactBattleEvent<DamageEventArgs>(args.Unit.DamageReceived, new EventSequencedReactor<DamageEventArgs>(this.OnDamageReceived));
		}

		protected virtual IEnumerable<BattleAction> OnDamageReceived(DamageEventArgs args)
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

		protected virtual IEnumerable<BattleAction> OnLifeChanged(ChangeLifeEventArgs args)
		{
			bool flag = args.Amount == 0;
			if (flag)
			{
				yield break;
			}
			foreach (BattleAction action in this.HandleLifeChanged(args.argsunit, args.Amount, base.Battle.Player, args.Cause, args.ActionSource))
			{
				yield return action;
				action = null;
			}
			IEnumerator<BattleAction> enumerator = null;
			yield break;
			yield break;
		}

		protected abstract IEnumerable<BattleAction> HandleLifeChanged(Unit receive, int amount, Unit source, ActionCause cause, GameEntity actionSource);
	}
}
