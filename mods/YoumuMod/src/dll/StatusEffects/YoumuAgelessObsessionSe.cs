using System;
using LBoL.Core;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoLEntitySideloader.Attributes;

namespace YoumuCharacterMod.StatusEffects
{
	[EntityLogic(typeof(YoumuAgelessObsessionSeDef))]
	public sealed class YoumuAgelessObsessionSe : StatusEffect
	{
		protected override void OnAdded(Unit unit)
		{
			foreach (EnemyUnit enemyUnit in base.Battle.AllAliveEnemies)
			{
				base.HandleOwnerEvent<StatusEffectApplyEventArgs>(enemyUnit.StatusEffectAdding, new GameEventHandler<StatusEffectApplyEventArgs>(this.OnEnemyStatusEffectAdding));
			}
			base.HandleOwnerEvent<UnitEventArgs>(base.Battle.EnemySpawned, new GameEventHandler<UnitEventArgs>(this.OnEnemySpawned));
		}

		private void OnEnemySpawned(UnitEventArgs args)
		{
			base.HandleOwnerEvent<StatusEffectApplyEventArgs>(args.Unit.StatusEffectAdding, new GameEventHandler<StatusEffectApplyEventArgs>(this.OnEnemyStatusEffectAdding));
		}

		private void OnEnemyStatusEffectAdding(StatusEffectApplyEventArgs args)
		{
			bool flag = args.Effect is LockedOn;
			if (flag)
			{
				base.NotifyActivating();
				args.Effect.Level *= base.Level + 1;
				args.AddModifier(this);
			}
		}
	}
}
