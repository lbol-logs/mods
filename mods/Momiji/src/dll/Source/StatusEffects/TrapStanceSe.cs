using System;
using System.Collections.Generic;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoL.EntityLib.StatusEffects.Basic;
using LBoLEntitySideloader.Attributes;

namespace Momiji.Source.StatusEffects
{
	[EntityLogic(typeof(TrapStanceSeDef))]
	public sealed class TrapStanceSe : StatusEffect
	{
		protected override void OnAdded(Unit unit)
		{
			base.ReactOwnerEvent<StatusEffectEventArgs>(base.Battle.Player.StatusEffectRemoved, new EventSequencedReactor<StatusEffectEventArgs>(this.StatusEffectRemoved));
			base.ReactOwnerEvent<UnitEventArgs>(base.Owner.TurnStarted, new EventSequencedReactor<UnitEventArgs>(this.OnOwnerTurnStarted));
		}

		private IEnumerable<BattleAction> StatusEffectRemoved(StatusEffectEventArgs args)
		{
			bool flag = args.ActionSource is Reflect;
			if (flag)
			{
				int retalLevel = base.Battle.Player.GetStatusEffect<RetaliationSe>().Level;
				bool flag2 = (float)retalLevel > 0f && !this.hasActivated;
				if (flag2)
				{
					yield return new ApplyStatusEffectAction<Reflect>(base.Battle.Player, new int?(retalLevel), new int?(0), new int?(0), new int?(0), 0.2f, true);
					bool flag3 = base.Battle.Player.HasStatusEffect<Reflect>();
					if (flag3)
					{
						base.Battle.Player.GetStatusEffect<Reflect>().Gun = "心抄斩";
					}
					this.hasActivated = true;
				}
			}
			yield break;
		}

		private IEnumerable<BattleAction> OnOwnerTurnStarted(UnitEventArgs args)
		{
			bool battleShouldEnd = base.Battle.BattleShouldEnd;
			if (battleShouldEnd)
			{
				yield break;
			}
			bool flag = this.hasActivated;
			if (flag)
			{
				this.hasActivated = false;
			}
			yield break;
		}

		private bool hasActivated = false;
	}
}
