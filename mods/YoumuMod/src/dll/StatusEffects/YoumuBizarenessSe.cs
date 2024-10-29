﻿using System;
using System.Collections.Generic;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoL.EntityLib.StatusEffects.Others;
using LBoLEntitySideloader.Attributes;

namespace YoumuCharacterMod.StatusEffects
{
	[EntityLogic(typeof(YoumuBizarenessSeDef))]
	public sealed class YoumuBizarenessSe : StatusEffect
	{
		protected override void OnAdded(Unit unit)
		{
			foreach (EnemyUnit enemyUnit in base.Battle.AllAliveEnemies)
			{
				base.ReactOwnerEvent<StatusEffectApplyEventArgs>(enemyUnit.StatusEffectAdded, new EventSequencedReactor<StatusEffectApplyEventArgs>(this.OnEnemyStatusEffectAdded));
			}
			base.HandleOwnerEvent<UnitEventArgs>(base.Battle.EnemySpawned, new GameEventHandler<UnitEventArgs>(this.OnEnemySpawned));
		}

		private void OnEnemySpawned(UnitEventArgs args)
		{
			base.ReactOwnerEvent<StatusEffectApplyEventArgs>(args.Unit.StatusEffectAdded, new EventSequencedReactor<StatusEffectApplyEventArgs>(this.OnEnemyStatusEffectAdded));
		}

		private IEnumerable<BattleAction> OnEnemyStatusEffectAdded(StatusEffectApplyEventArgs args)
		{
			bool flag = args.Effect is LockedOn;
			if (flag)
			{
				base.NotifyActivating();
				yield return new ApplyStatusEffectAction<Poison>(args.Unit, new int?(base.Level), null, null, null, 0f, true);
			}
			yield break;
		}
	}
}