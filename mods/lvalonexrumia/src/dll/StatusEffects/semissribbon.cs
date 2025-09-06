using System;
using System.Collections.Generic;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoLEntitySideloader.Attributes;

namespace lvalonexrumia.StatusEffects
{
	[EntityLogic(typeof(semissribbonDef))]
	public sealed class semissribbon : StatusEffect
	{
		protected override void OnAdded(Unit unit)
		{
			foreach (EnemyUnit enemyUnit in base.Battle.AllAliveEnemies)
			{
				base.ReactOwnerEvent<StatusEffectApplyEventArgs>(enemyUnit.StatusEffectAdded, new EventSequencedReactor<StatusEffectApplyEventArgs>(this.OnEnemyStatusEffectAdded));
			}
			base.HandleOwnerEvent<UnitEventArgs>(base.Battle.EnemySpawned, new GameEventHandler<UnitEventArgs>(this.OnEnemySpawned));
		}

		private IEnumerable<BattleAction> OnEnemyStatusEffectAdded(StatusEffectApplyEventArgs args)
		{
			bool flag = args.ActionSource != this && args.Effect is sebloodmark;
			if (flag)
			{
				base.NotifyActivating();
				yield return new ApplyStatusEffectAction<sebloodsword>(base.Battle.Player, new int?(base.Level), new int?(0), new int?(0), new int?(0), 0.2f, true);
			}
			yield break;
		}

		private void OnEnemySpawned(UnitEventArgs args)
		{
			base.ReactOwnerEvent<StatusEffectApplyEventArgs>(args.Unit.StatusEffectAdded, new EventSequencedReactor<StatusEffectApplyEventArgs>(this.OnEnemyStatusEffectAdded));
		}
	}
}
