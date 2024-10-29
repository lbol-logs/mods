using System;
using System.Collections.Generic;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.EntityLib.Exhibits;
using LBoL.EntityLib.StatusEffects.Basic;
using LBoLEntitySideloader.Attributes;

namespace Sanae_Kochiya.Exhibits
{
	[EntityLogic(typeof(SanaeExhibitWDef))]
	public sealed class SanaeExhibitW : ShiningExhibit
	{
		protected override void OnEnterBattle()
		{
			base.ReactBattleEvent<UnitEventArgs>(base.Battle.Player.TurnStarted, new EventSequencedReactor<UnitEventArgs>(this.OnPlayerTurnStarted));
		}

		private IEnumerable<BattleAction> OnPlayerTurnStarted(UnitEventArgs args)
		{
			bool flag = base.Battle.Player.TurnCounter == 1;
			if (flag)
			{
				base.NotifyActivating();
				yield return new ApplyStatusEffectAction<AmuletForCard>(base.Owner, new int?(base.Value1), new int?(0), new int?(0), new int?(0), 0.2f, false);
			}
			yield break;
		}
	}
}
