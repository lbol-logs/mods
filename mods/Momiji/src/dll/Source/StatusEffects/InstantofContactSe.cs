using System;
using System.Collections.Generic;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Units;
using LBoL.EntityLib.StatusEffects.ExtraTurn;
using LBoLEntitySideloader.Attributes;

namespace Momiji.Source.StatusEffects
{
	[EntityLogic(typeof(InstantofContactSeDef))]
	public sealed class InstantofContactSe : ExtraTurnPartner
	{
		protected override void OnAdded(Unit unit)
		{
			base.ReactOwnerEvent<BlockShieldEventArgs>(base.Owner.BlockShieldGained, new EventSequencedReactor<BlockShieldEventArgs>(this.OnBlockShieldGained));
			base.ThisTurnActivating = false;
			base.HandleOwnerEvent<UnitEventArgs>(base.Battle.Player.TurnStarting, delegate(UnitEventArgs args)
			{
				bool flag = base.Battle.Player.IsExtraTurn && !base.Battle.Player.IsSuperExtraTurn && base.Battle.Player.GetStatusEffectExtend<ExtraTurnPartner>() == this;
				if (flag)
				{
					base.ThisTurnActivating = true;
				}
			});
			base.ReactOwnerEvent<UnitEventArgs>(base.Battle.Player.TurnEnded, new EventSequencedReactor<UnitEventArgs>(this.OnPlayerTurnEnded));
		}

		private IEnumerable<BattleAction> OnPlayerTurnEnded(UnitEventArgs args)
		{
			bool thisTurnActivating = base.ThisTurnActivating;
			if (thisTurnActivating)
			{
				yield return new RemoveStatusEffectAction(this, true, 0.1f);
			}
			yield break;
		}

		private IEnumerable<BattleAction> OnBlockShieldGained(BlockShieldEventArgs args)
		{
			bool battleShouldEnd = base.Battle.BattleShouldEnd;
			if (battleShouldEnd)
			{
				yield break;
			}
			bool flag = args.Block > 0f || args.Shield > 0f;
			if (flag)
			{
				base.NotifyActivating();
				yield return new ApplyStatusEffectAction<RetaliationSe>(base.Battle.Player, new int?(base.Level), new int?(0), new int?(0), new int?(0), 0.2f, true);
				yield break;
			}
			yield break;
		}
	}
}
