using System;
using System.Collections.Generic;
using LBoL.Base;
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
	[EntityLogic(typeof(exexaDef))]
	public sealed class exexa : ShiningExhibit
	{
		private void updatecounter()
		{
			base.Counter = Convert.ToInt32(Math.Ceiling((double)(base.GameRun.Player.MaxHp - base.GameRun.Player.Hp) * (double)base.Value2 / 100.0));
		}

		protected override void OnAdded(PlayerUnit player)
		{
			this.updatecounter();
			base.HandleGameRunEvent<DamageEventArgs>(base.GameRun.Player.DamageReceived, new GameEventHandler<DamageEventArgs>(this.OnGRDamageReceived));
			base.HandleGameRunEvent<HealEventArgs>(base.GameRun.Player.HealingReceived, new GameEventHandler<HealEventArgs>(this.OnGRDamageReceived));
		}

		private void OnGRDamageReceived(HealEventArgs args)
		{
			this.updatecounter();
		}

		private void OnGRDamageReceived(DamageEventArgs args)
		{
			this.updatecounter();
		}

		protected override void OnEnterBattle()
		{
			base.ReactBattleEvent<UnitEventArgs>(base.Battle.Player.TurnStarted, new EventSequencedReactor<UnitEventArgs>(this.OnPlayerTurnStarted));
			base.HandleBattleEvent<DamageDealingEventArgs>(base.Battle.Player.DamageDealing, new GameEventHandler<DamageDealingEventArgs>(this.OnDamageDealing));
			base.HandleBattleEvent<DamageEventArgs>(base.Battle.Player.DamageReceived, new GameEventHandler<DamageEventArgs>(this.OnDamageReceived));
			base.HandleBattleEvent<ChangeLifeEventArgs>(CustomGameEventManager.PostChangeLifeEvent, new GameEventHandler<ChangeLifeEventArgs>(this.OnLifeChanged));
		}

		private void OnLifeChanged(ChangeLifeEventArgs args)
		{
			bool flag = args.argsunit == base.Battle.Player || args.argsunit == null;
			if (flag)
			{
				this.updatecounter();
			}
		}

		private void OnDamageReceived(DamageEventArgs args)
		{
			this.updatecounter();
		}

		private void OnDamageDealing(DamageDealingEventArgs args)
		{
			bool flag = args.DamageInfo.DamageType == DamageType.Attack;
			if (flag)
			{
				args.DamageInfo = args.DamageInfo.IncreaseBy(Convert.ToInt32(Math.Ceiling((double)(base.GameRun.Player.MaxHp - base.GameRun.Player.Hp) * (double)base.Value2 / 100.0)));
				args.AddModifier(this);
			}
		}

		private IEnumerable<BattleAction> OnPlayerTurnStarted(UnitEventArgs args)
		{
			bool flag = base.Battle.Player.TurnCounter == 1;
			if (flag)
			{
				base.NotifyActivating();
				foreach (Unit unit in base.Battle.AllAliveEnemies)
				{
					yield return new ApplyStatusEffectAction<sebloodmark>(unit, new int?(base.Value1), new int?(0), new int?(0), new int?(0), 0.2f, true);
					unit = null;
				}
				IEnumerator<EnemyUnit> enumerator = null;
			}
			yield break;
			yield break;
		}
	}
}
