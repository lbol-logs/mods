using System;
using System.Collections.Generic;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoLEntitySideloader.Attributes;

namespace Momiji.Source.StatusEffects
{
	[EntityLogic(typeof(MountainsideTrailTrackingSeDef))]
	public sealed class MountainsideTrailTrackingSe : StatusEffect
	{
		protected override void OnAdded(Unit unit)
		{
			base.ReactOwnerEvent<DamageEventArgs>(base.Battle.Player.DamageDealt, new EventSequencedReactor<DamageEventArgs>(this.OnPlayerDamageDealt));
			base.ReactOwnerEvent<UnitEventArgs>(base.Owner.TurnStarted, new EventSequencedReactor<UnitEventArgs>(this.OnOwnerTurnStarted));
		}

		private IEnumerable<BattleAction> OnPlayerDamageDealt(DamageEventArgs args)
		{
			bool flag = base.Battle.BattleShouldEnd || this.hasActivated;
			if (flag)
			{
				yield break;
			}
			bool flag2 = args.Cause == ActionCause.Card;
			if (flag2)
			{
				DamageInfo damageInfo = args.DamageInfo;
				bool flag3 = damageInfo.Damage > 0f;
				if (flag3)
				{
					bool flag4 = args.Target.HasStatusEffect<Vulnerable>();
					if (flag4)
					{
						yield return new DrawManyCardAction(base.Level);
						this.hasActivated = true;
					}
				}
				damageInfo = default(DamageInfo);
			}
			yield break;
		}

		private IEnumerable<BattleAction> OnOwnerTurnStarted(UnitEventArgs args)
		{
			bool battleShouldEnd = base.Battle.BattleShouldEnd;
			if (battleShouldEnd)
			{
				yield break;
			}
			bool flag = this.hasActivated;
			if (flag)
			{
				this.hasActivated = false;
			}
			yield break;
		}

		private bool hasActivated = false;
	}
}
