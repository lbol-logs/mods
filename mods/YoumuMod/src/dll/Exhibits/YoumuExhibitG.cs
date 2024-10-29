using System;
using System.Collections.Generic;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoL.EntityLib.Exhibits;
using LBoLEntitySideloader.Attributes;

namespace YoumuCharacterMod.Exhibits
{
	[EntityLogic(typeof(YoumuExhibitGDef))]
	public sealed class YoumuExhibitG : ShiningExhibit
	{
		protected override void OnEnterBattle()
		{
			foreach (EnemyUnit enemyUnit in base.Battle.AllAliveEnemies)
			{
				base.ReactBattleEvent<StatusEffectApplyEventArgs>(enemyUnit.StatusEffectAdded, new EventSequencedReactor<StatusEffectApplyEventArgs>(this.OnEnemyStatusEffectAdded));
			}
			base.HandleBattleEvent<UnitEventArgs>(base.Battle.EnemySpawned, new GameEventHandler<UnitEventArgs>(this.OnEnemySpawned));
			base.ReactBattleEvent<UnitEventArgs>(base.Battle.Player.TurnEnding, new EventSequencedReactor<UnitEventArgs>(this.OnPlayerTurnEnding));
			base.ReactBattleEvent<GameEventArgs>(base.Battle.AllEnemyTurnEnding, new EventSequencedReactor<GameEventArgs>(this.OnEnemyTurnEnding));
			base.ReactBattleEvent<GameEventArgs>(base.Battle.BattleStarted, new EventSequencedReactor<GameEventArgs>(this.OnBattleStarted));
		}

		private IEnumerable<BattleAction> OnPlayerTurnEnding(UnitEventArgs args)
		{
			foreach (EnemyUnit enemyUnit in base.Battle.AllAliveEnemies)
			{
				bool flag = enemyUnit.HasStatusEffect<LockedOn>();
				if (flag)
				{
					enemyUnit.GetStatusEffect<LockedOn>().IsAutoDecreasing = false;
				}
				enemyUnit = null;
			}
			IEnumerator<EnemyUnit> enumerator = null;
			yield break;
		}

		private IEnumerable<BattleAction> OnEnemyTurnEnding(GameEventArgs args)
		{
			foreach (EnemyUnit enemyUnit in base.Battle.AllAliveEnemies)
			{
				bool flag = enemyUnit.HasStatusEffect<LockedOn>();
				if (flag)
				{
					enemyUnit.GetStatusEffect<LockedOn>().IsAutoDecreasing = false;
				}
				enemyUnit = null;
			}
			IEnumerator<EnemyUnit> enumerator = null;
			yield break;
		}

		private void OnEnemySpawned(UnitEventArgs args)
		{
			base.ReactBattleEvent<StatusEffectApplyEventArgs>(args.Unit.StatusEffectAdded, new EventSequencedReactor<StatusEffectApplyEventArgs>(this.OnEnemyStatusEffectAdded));
		}

		private IEnumerable<BattleAction> OnEnemyStatusEffectAdded(StatusEffectApplyEventArgs args)
		{
			bool flag = args.Effect is LockedOn && !base.Battle.BattleShouldEnd;
			if (flag)
			{
				args.Effect.IsAutoDecreasing = false;
				args.AddModifier(this);
			}
			yield break;
		}

		private IEnumerable<BattleAction> OnBattleStarted(GameEventArgs args)
		{
			foreach (EnemyUnit enemyUnit in base.Battle.AllAliveEnemies)
			{
				yield return new ApplyStatusEffectAction<LockedOn>(enemyUnit, new int?(base.Value1), new int?(0), null, null, 0f, true);
				enemyUnit = null;
			}
			IEnumerator<EnemyUnit> enumerator = null;
			yield break;
			yield break;
		}
	}
}
