using System;
using System.Collections.Generic;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Cards;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoLEntitySideloader.Attributes;
using YoumuCharacterMod.Cards.Template;
using YoumuCharacterMod.GunName;

namespace YoumuCharacterMod.Cards
{
	[EntityLogic(typeof(YoumuDyingDevaDef))]
	public sealed class YoumuDyingDeva : YoumuCard
	{
		protected override void OnEnterBattle(BattleController battle)
		{
			foreach (EnemyUnit enemyUnit in base.Battle.AllAliveEnemies)
			{
				base.ReactBattleEvent<StatusEffectApplyEventArgs>(enemyUnit.StatusEffectAdded, new EventSequencedReactor<StatusEffectApplyEventArgs>(this.OnEnemyStatusEffectAdded));
			}
			base.HandleBattleEvent<UnitEventArgs>(base.Battle.EnemySpawned, new GameEventHandler<UnitEventArgs>(this.OnEnemySpawned), (GameEventPriority)0);
			base.ReactBattleEvent<UnitEventArgs>(base.Battle.Player.TurnEnding, new EventSequencedReactor<UnitEventArgs>(this.OnPlayerTurnEnding));
		}

		private void OnEnemySpawned(UnitEventArgs args)
		{
			base.ReactBattleEvent<StatusEffectApplyEventArgs>(args.Unit.StatusEffectAdded, new EventSequencedReactor<StatusEffectApplyEventArgs>(this.OnEnemyStatusEffectAdded));
		}

		private IEnumerable<BattleAction> OnEnemyStatusEffectAdded(StatusEffectApplyEventArgs args)
		{
			bool flag = base.Zone == CardZone.Hand && !base.Battle.BattleShouldEnd;
			if (flag)
			{
				base.DeltaValue1 += base.Value2;
			}
			yield break;
		}

		private IEnumerable<BattleAction> OnPlayerTurnEnding(UnitEventArgs args)
		{
			bool flag = base.Battle.BattleShouldEnd || base.Zone != CardZone.Hand;
			if (flag)
			{
				yield break;
			}
			foreach (Unit unit in base.Battle.AllAliveEnemies)
			{
				bool flag2 = unit.HasStatusEffect<LockedOn>();
				if (flag2)
				{
					base.NotifyActivating();
					yield return new DamageAction(base.Battle.Player, unit, DamageInfo.Reaction((float)base.Value1, false), YoumuGunName.DyingDeva, GunType.Single);
				}
				unit = null;
			}
			IEnumerator<EnemyUnit> enumerator = null;
			yield break;
			yield break;
		}
	}
}
