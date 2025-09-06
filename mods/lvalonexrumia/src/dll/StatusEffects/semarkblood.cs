using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoLEntitySideloader.Attributes;

namespace lvalonexrumia.StatusEffects
{
	[EntityLogic(typeof(semarkbloodDef))]
	public sealed class semarkblood : StatusEffect
	{
		protected override void OnAdded(Unit unit)
		{
			base.ReactOwnerEvent<UnitEventArgs>(base.Owner.TurnStarted, new EventSequencedReactor<UnitEventArgs>(this.OnTurnStarted));
			base.ReactOwnerEvent<DamageEventArgs>(base.Owner.DamageDealt, new EventSequencedReactor<DamageEventArgs>(this.OnDamageDealt));
		}

		private IEnumerable<BattleAction> OnTurnStarted(UnitEventArgs args)
		{
			yield break;
		}

		private IEnumerable<BattleAction> OnDamageDealt(DamageEventArgs args)
		{
			bool flag = !base.Battle.BattleShouldEnd && args.Target.IsAlive;
			if (flag)
			{
				DamageInfo damageInfo = args.DamageInfo;
				bool flag2 = damageInfo.DamageType == DamageType.Attack && !args.Target.HasStatusEffect<sebloodmark>();
				if (flag2)
				{
					base.NotifyActivating();
					yield return new ApplyStatusEffectAction<sebloodmark>(args.Target, new int?(base.Level), null, null, null, 0f, true);
				}
				damageInfo = default(DamageInfo);
			}
			yield break;
		}
	}
}
