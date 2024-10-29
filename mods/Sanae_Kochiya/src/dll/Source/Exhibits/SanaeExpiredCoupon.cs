using System;
using System.Collections.Generic;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoLEntitySideloader.Attributes;

namespace Sanae_Kochiya.Source.Exhibits
{
	[EntityLogic(typeof(SanaeExpiredCouponDef))]
	public sealed class SanaeExpiredCoupon : Exhibit
	{
		protected override void OnEnterBattle()
		{
			base.Active = true;
			base.ReactBattleEvent<UsUsingEventArgs>(base.Battle.UsUsed, new EventSequencedReactor<UsUsingEventArgs>(this.OnUsUsed));
		}

		private IEnumerable<BattleAction> OnUsUsed(UsUsingEventArgs args)
		{
			bool active = base.Active;
			if (active)
			{
				base.NotifyActivating();
				base.Active = false;
				yield return new GainPowerAction(base.Value1);
			}
			yield break;
		}

		protected override void OnLeaveBattle()
		{
			base.Active = false;
		}
	}
}
