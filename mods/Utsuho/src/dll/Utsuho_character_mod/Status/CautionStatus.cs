using System;
using System.Collections.Generic;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoL.EntityLib.StatusEffects.ExtraTurn;
using LBoLEntitySideloader.Attributes;

namespace Utsuho_character_mod.Status
{
	[EntityLogic(typeof(CautionEffect))]
	public sealed class CautionStatus : StatusEffect
	{
		protected override void OnAdded(Unit unit)
		{
			base.ReactOwnerEvent<UnitEventArgs>(base.Owner.TurnStarting, new EventSequencedReactor<UnitEventArgs>(this.OnOwnerTurnStarting));
		}

		private IEnumerable<BattleAction> OnOwnerTurnStarting(UnitEventArgs args)
		{
			bool flag = !base.Battle.BattleShouldEnd;
			if (flag)
			{
				yield return new ApplyStatusEffectAction<Burst>(base.Owner, new int?(1), null, null, null, 0f, true);
				yield return new ApplyStatusEffectAction<TimeIsLimited>(base.Battle.Player, new int?(1), null, null, null, 0f, true);
			}
			yield break;
		}
	}
}
