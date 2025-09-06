using System;
using System.Collections.Generic;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoL.Presentation;
using lvalonexrumia.Patches;

namespace lvalonexrumia.StatusEffects
{
	public abstract class sereact : StatusEffect
	{
		public int lifeneed
		{
			get
			{
				bool flag = Singleton<GameMaster>.Instance.CurrentGameRun == null;
				int num;
				if (flag)
				{
					num = 0;
				}
				else
				{
					num = toolbox.hpfrompercent(Singleton<GameMaster>.Instance.CurrentGameRun.Player, 50, true);
				}
				return num;
			}
		}

		protected override void OnAdded(Unit unit)
		{
			this.dosmth();
			base.ReactOwnerEvent<ChangeLifeEventArgs>(CustomGameEventManager.PostChangeLifeEvent, new EventSequencedReactor<ChangeLifeEventArgs>(this.OnLifeChanged));
			foreach (Unit unit2 in base.Battle.AllAliveUnits)
			{
				base.ReactOwnerEvent<DamageEventArgs>(unit2.DamageReceived, new EventSequencedReactor<DamageEventArgs>(this.OnDamageReceived));
			}
			base.HandleOwnerEvent<UnitEventArgs>(base.Battle.EnemySpawned, new GameEventHandler<UnitEventArgs>(this.OnEnemySpawned));
			base.ReactOwnerEvent<GameEventArgs>(base.Battle.BattleEnded, new EventSequencedReactor<GameEventArgs>(this.OnBattleEnded), (GameEventPriority)0);
			base.HandleOwnerEvent<HealEventArgs>(base.Battle.Player.HealingReceived, new GameEventHandler<HealEventArgs>(this.OnHealingReceived));
			base.ReactOwnerEvent<UnitEventArgs>(base.Battle.Player.TurnStarted, new EventSequencedReactor<UnitEventArgs>(this.OnPlayerTurnStarted));
		}

		private IEnumerable<BattleAction> OnBattleEnded(GameEventArgs args)
		{
			yield return new RemoveStatusEffectAction(this, true, 0.1f);
			yield break;
		}

		protected virtual void dosmth()
		{
		}

		protected virtual void OnHealingReceived(HealEventArgs args)
		{
			bool battleShouldEnd = base.Battle.BattleShouldEnd;
			if (battleShouldEnd)
			{
			}
		}

		protected virtual IEnumerable<BattleAction> OnPlayerTurnStarted(UnitEventArgs args)
		{
			yield break;
		}

		protected virtual void OnEnemySpawned(UnitEventArgs args)
		{
			base.ReactOwnerEvent<DamageEventArgs>(args.Unit.DamageReceived, new EventSequencedReactor<DamageEventArgs>(this.OnDamageReceived));
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
