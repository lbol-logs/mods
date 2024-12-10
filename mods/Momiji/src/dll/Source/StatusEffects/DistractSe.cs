using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoLEntitySideloader.Attributes;

namespace Momiji.Source.StatusEffects
{
	[EntityLogic(typeof(DistractSeDef))]
	public sealed class DistractSe : StatusEffect
	{
		protected override void OnAdded(Unit unit)
		{
			base.ReactOwnerEvent<DamageEventArgs>(base.Battle.Player.DamageDealt, new EventSequencedReactor<DamageEventArgs>(this.OnPlayerDamageDealt));
		}

		public IEnumerable<BattleAction> OnPlayerDamageDealt(DamageEventArgs args)
		{
			bool flag = args.Source == base.Battle.Player && args.Target != null && args.DamageInfo.DamageType == DamageType.Attack;
			if (flag)
			{
				bool flag2 = args.Target.IsAlive && args.Target.HasStatusEffect<Vulnerable>();
				if (flag2)
				{
					yield return new ApplyStatusEffectAction<Weak>(args.Target, new int?(0), new int?(1), new int?(0), new int?(0), 0.2f, true);
				}
			}
			yield break;
		}
	}
}
