using System;
using System.Collections.Generic;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.EntityLib.Exhibits;
using LBoLEntitySideloader.Attributes;

namespace Sanae_Kochiya.Exhibits
{
	[EntityLogic(typeof(SanaeExhibitUDef))]
	public sealed class SanaeExhibitU : ShiningExhibit
	{
		protected override void OnEnterBattle()
		{
			base.ReactBattleEvent<UsUsingEventArgs>(base.Battle.UsUsed, new EventSequencedReactor<UsUsingEventArgs>(this.OnUsUsed));
		}

		private IEnumerable<BattleAction> OnUsUsed(UsUsingEventArgs args)
		{
			base.NotifyActivating();
			yield return new CastBlockShieldAction(base.Owner, base.Owner, base.Value1, 0, BlockShieldType.Normal, true);
			yield break;
		}
	}
}
