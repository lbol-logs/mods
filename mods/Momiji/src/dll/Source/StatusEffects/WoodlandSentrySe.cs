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
	[EntityLogic(typeof(WoodlandSentrySeDef))]
	public sealed class WoodlandSentrySe : StatusEffect
	{
		protected override void OnAdded(Unit unit)
		{
			base.ReactOwnerEvent<UnitEventArgs>(base.Battle.Player.TurnEnding, new EventSequencedReactor<UnitEventArgs>(this.OnTurnEnding));
		}

		private IEnumerable<BattleAction> OnTurnEnding(UnitEventArgs args)
		{
			int num = base.Battle.HandZone.Count * base.Level;
			bool flag = num > 0;
			if (flag)
			{
				base.NotifyActivating();
				yield return new CastBlockShieldAction(base.Battle.Player, num, 0, BlockShieldType.Normal, true);
			}
			yield break;
		}
	}
}
