using System;
using System.Collections.Generic;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoLEntitySideloader.Attributes;
using YoumuCharacterMod.Cards;

namespace YoumuCharacterMod.StatusEffects
{
	[EntityLogic(typeof(YoumuDualWielderSeDef))]
	public sealed class YoumuDualWielderSe : StatusEffect
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
				base.Count += args.Effect.Level;
				while (base.Count >= YoumuDualWielderSe.lockOnThreshold)
				{
					yield return new AddCardsToHandAction(Library.CreateCards<YoumuSlashOfPresent>(base.Level, false), AddCardsType.Normal);
					base.Count -= YoumuDualWielderSe.lockOnThreshold;
				}
			}
			yield break;
		}

		private static readonly int lockOnThreshold = 5;
	}
}
