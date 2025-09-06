using System;
using System.Collections.Generic;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoLEntitySideloader.Attributes;
using lvalonexrumia.Patches;

namespace lvalonexrumia.StatusEffects
{
	[EntityLogic(typeof(seidliveDef))]
	public sealed class seidlive : StatusEffect
	{
		public override bool ForceNotShowDownText
		{
			get
			{
				return true;
			}
		}

		protected override void OnAdded(Unit unit)
		{
			base.ReactOwnerEvent<ChangeLifeEventArgs>(CustomGameEventManager.PostChangeLifeEvent, new EventSequencedReactor<ChangeLifeEventArgs>(this.OnLifeChanged));
			foreach (Unit unit2 in base.Battle.AllAliveUnits)
			{
				base.ReactOwnerEvent<DamageEventArgs>(unit2.DamageReceived, new EventSequencedReactor<DamageEventArgs>(this.OnDamageReceived));
			}
			base.HandleOwnerEvent<UnitEventArgs>(base.Battle.EnemySpawned, new GameEventHandler<UnitEventArgs>(this.OnEnemySpawned));
			base.ReactOwnerEvent<UnitEventArgs>(base.Battle.Player.TurnStarted, new EventSequencedReactor<UnitEventArgs>(this.OnPlayerTurnStarted));
			base.HandleOwnerEvent<DieEventArgs>(base.Owner.Dying, new GameEventHandler<DieEventArgs>(this.OnDying));
			base.ReactOwnerEvent<GameEventArgs>(base.Battle.BattleEnding, new EventSequencedReactor<GameEventArgs>(this.OnBattleEnding));
			base.ReactOwnerEvent<GameEventArgs>(base.Battle.RoundEnded, new EventSequencedReactor<GameEventArgs>(this.OnRoundEnded));
		}

		private IEnumerable<BattleAction> OnRoundEnded(GameEventArgs args)
		{
			bool flag = base.GameRun.Player.Hp <= 0;
			if (flag)
			{
				base.NotifyActivating();
				yield return new ForceKillAction(base.Battle.Player, base.Battle.Player);
			}
			yield return new RemoveStatusEffectAction(this, true, 0.1f);
			yield break;
		}

		private IEnumerable<BattleAction> OnBattleEnding(GameEventArgs args)
		{
			bool flag = base.GameRun.Player.Hp <= 0;
			if (flag)
			{
				base.NotifyActivating();
				base.GameRun.SetHpAndMaxHp(1, base.GameRun.Player.MaxHp, true);
			}
			yield break;
		}

		private void OnDying(DieEventArgs args)
		{
			base.NotifyActivating();
			args.CancelBy(this);
		}

		private IEnumerable<BattleAction> OnPlayerTurnStarted(UnitEventArgs args)
		{
			yield break;
		}

		private void OnEnemySpawned(UnitEventArgs args)
		{
			base.ReactOwnerEvent<DamageEventArgs>(args.Unit.DamageReceived, new EventSequencedReactor<DamageEventArgs>(this.OnDamageReceived));
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

		private IEnumerable<BattleAction> HandleLifeChanged(Unit receive, int amount, Unit source, ActionCause cause, GameEntity actionSource)
		{
			yield break;
		}
	}
}
