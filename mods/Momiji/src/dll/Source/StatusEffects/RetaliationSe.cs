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
	[EntityLogic(typeof(RetaliationSeDef))]
	public sealed class RetaliationSe : StatusEffect
	{
		protected override void OnAdded(Unit unit)
		{
			this.React(new ApplyStatusEffectAction<Reflect>(base.Battle.Player, new int?(base.Level), new int?(0), new int?(0), new int?(0), 0.2f, true));
			base.ReactOwnerEvent<UnitEventArgs>(base.Owner.TurnStarted, new EventSequencedReactor<UnitEventArgs>(this.OnOwnerTurnStarted));
		}

		public override bool Stack(StatusEffect other)
		{
			this.React(base.BuffAction<Reflect>(other.Level, 0, 0, 0, 0.2f));
			bool flag = base.Battle.Player.HasStatusEffect<Reflect>();
			if (flag)
			{
				base.Battle.Player.GetStatusEffect<Reflect>().Gun = "心抄斩";
			}
			return base.Stack(other);
		}

		private IEnumerable<BattleAction> OnOwnerTurnStarted(UnitEventArgs args)
		{
			yield return base.BuffAction<Reflect>(base.Level, 0, 0, 0, 0.2f);
			int level = base.Level - 1;
			base.Level = level;
			bool flag = base.Level <= 0;
			if (flag)
			{
				yield return new RemoveStatusEffectAction(this, true, 0.1f);
			}
			yield break;
		}
	}
}
