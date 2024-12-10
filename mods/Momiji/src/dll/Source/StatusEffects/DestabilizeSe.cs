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
	[EntityLogic(typeof(DestabilizeSeDef))]
	public sealed class DestabilizeSe : StatusEffect
	{
		protected override void OnAdded(Unit unit)
		{
			base.ReactOwnerEvent<DamageEventArgs>(base.Battle.Player.DamageDealt, new EventSequencedReactor<DamageEventArgs>(this.OnPlayerDamageDealt));
		}

		private IEnumerable<BattleAction> OnPlayerDamageDealt(DamageEventArgs args)
		{
			bool battleShouldEnd = base.Battle.BattleShouldEnd;
			if (battleShouldEnd)
			{
				yield break;
			}
			bool flag = args.Cause == ActionCause.Card;
			if (flag)
			{
				DamageInfo damageInfo = args.DamageInfo;
				bool flag2 = damageInfo.Damage > 0f;
				if (flag2)
				{
					yield return new CastBlockShieldAction(base.Battle.Player, base.Level, 0, BlockShieldType.Normal, false);
				}
				damageInfo = default(DamageInfo);
			}
			yield break;
		}
	}
}
