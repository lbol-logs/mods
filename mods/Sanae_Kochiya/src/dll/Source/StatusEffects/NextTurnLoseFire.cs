﻿using System;
using System.Collections.Generic;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoLEntitySideloader.Attributes;

namespace Sanae_Kochiya.Source.StatusEffects
{
	[EntityLogic(typeof(NextTurnLoseFireDef))]
	public sealed class NextTurnLoseFire : StatusEffect
	{
		protected override void OnAdded(Unit unit)
		{
			base.ReactOwnerEvent<UnitEventArgs>(base.Battle.Player.TurnStarted, new EventSequencedReactor<UnitEventArgs>(this.OnTurnStarted));
		}

		private IEnumerable<BattleAction> OnTurnStarted(UnitEventArgs args)
		{
			bool flag = !base.Battle.BattleShouldEnd;
			if (flag)
			{
				base.NotifyActivating();
				yield return base.DebuffAction<FirepowerNegative>(base.Owner, base.Level, 0, 0, 0, true, 0.1f);
				yield return new RemoveStatusEffectAction(this, true, 0.1f);
			}
			yield break;
		}
	}
}