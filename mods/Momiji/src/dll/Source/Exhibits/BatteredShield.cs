using System;
using System.Collections.Generic;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.EntityLib.Exhibits;
using LBoL.EntityLib.StatusEffects.Basic;
using LBoLEntitySideloader.Attributes;

namespace Momiji.Source.Exhibits
{
	[EntityLogic(typeof(BatteredShieldDef))]
	public sealed class BatteredShield : ShiningExhibit
	{
		protected override void OnEnterBattle()
		{
			base.HandleBattleEvent<UnitEventArgs>(base.Owner.TurnStarting, new GameEventHandler<UnitEventArgs>(this.OnTurnStarting));
			base.ReactBattleEvent<BlockShieldEventArgs>(base.Owner.BlockShieldGained, new EventSequencedReactor<BlockShieldEventArgs>(this.OnBlockShieldGained));
		}

		protected override void OnLeaveBattle()
		{
			this.Triggered = false;
		}

		private void OnTurnStarting(UnitEventArgs args)
		{
			this.Triggered = false;
		}

		private IEnumerable<BattleAction> OnBlockShieldGained(BlockShieldEventArgs args)
		{
			bool flag = args.Block > 0f || args.Shield > 0f;
			if (flag)
			{
				bool flag2 = !this.Triggered;
				if (flag2)
				{
					this.Triggered = true;
					base.NotifyActivating();
					yield return new ApplyStatusEffectAction<Reflect>(base.Owner, new int?(base.Value1), null, null, null, 0.1f, true);
					bool flag3 = base.Battle.Player.HasStatusEffect<Reflect>();
					if (flag3)
					{
						base.Battle.Player.GetStatusEffect<Reflect>().Gun = "心抄斩";
					}
				}
			}
			yield break;
		}

		private bool Triggered = false;
	}
}
