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
	[EntityLogic(typeof(ShieldCounterSeDef))]
	public sealed class ShieldCounterSe : StatusEffect
	{
		protected override void OnAdded(Unit unit)
		{
			base.ReactOwnerEvent<DamageEventArgs>(base.Battle.Player.DamageDealt, new EventSequencedReactor<DamageEventArgs>(this.OnPlayerDamageDealt));
		}

		public IEnumerable<BattleAction> OnPlayerDamageDealt(DamageEventArgs args)
		{
			bool flag = args.Source == base.Battle.Player && args.Target != null && args.DamageInfo.DamageType == DamageType.Reaction;
			if (flag)
			{
				base.NotifyActivating();
				bool isAlive = args.Target.IsAlive;
				if (isAlive)
				{
					yield return new ApplyStatusEffectAction<Vulnerable>(args.Target, new int?(0), new int?(base.Level), new int?(0), new int?(0), 0.2f, true);
				}
				yield break;
			}
			yield break;
		}
	}
}
