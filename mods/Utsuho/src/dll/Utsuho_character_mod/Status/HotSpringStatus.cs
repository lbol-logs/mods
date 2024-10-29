using System;
using System.Collections.Generic;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoLEntitySideloader.Attributes;

namespace Utsuho_character_mod.Status
{
	[EntityLogic(typeof(HotSpringEffect))]
	public sealed class HotSpringStatus : StatusEffect
	{
		protected override void OnAdded(Unit unit)
		{
			base.ReactOwnerEvent<UnitEventArgs>(base.Owner.TurnStarted, new EventSequencedReactor<UnitEventArgs>(this.OnOwnerTurnStarted));
		}

		private IEnumerable<BattleAction> OnOwnerTurnStarted(UnitEventArgs args)
		{
			bool battleShouldEnd = base.Battle.BattleShouldEnd;
			if (battleShouldEnd)
			{
				yield break;
			}
			base.NotifyActivating();
			int level = base.GetSeLevel<HotSpringStatus>();
			yield return new ApplyStatusEffectAction<RadiationStatus>(base.Battle.Player, new int?(level), null, null, null, 0f, true);
			yield return new ApplyStatusEffectAction<HotSpringStatus>(base.Battle.Player, new int?(1), null, null, null, 0f, true);
			yield break;
		}
	}
}
