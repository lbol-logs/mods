using System;
using System.Collections.Generic;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoLEntitySideloader.Attributes;

namespace ReimuUnifierMod.StatusEffects
{
	[EntityLogic(typeof(ReimuUnifierScarletFateSeDef))]
	public sealed class ReimuUnifierScarletFateSe : StatusEffect
	{
		protected override void OnAdded(Unit unit)
		{
			base.Count = base.Limit;
			base.ReactOwnerEvent<UnitEventArgs>(base.Battle.Player.TurnStarting, new EventSequencedReactor<UnitEventArgs>(this.OnTurnStarting));
			base.ReactOwnerEvent<CardUsingEventArgs>(base.Battle.CardUsed, new EventSequencedReactor<CardUsingEventArgs>(this.OnCardUsed));
		}

		private IEnumerable<BattleAction> OnCardUsed(CardUsingEventArgs args)
		{
			bool isInTurn = base.Battle.Player.IsInTurn;
			if (isInTurn)
			{
				int count = base.Count - 1;
				base.Count = count;
				yield return PerformAction.Sfx("雷米线", 0f);
				bool flag = base.Count <= 0;
				if (flag)
				{
					base.NotifyActivating();
					Unit fakeRemi = base.Owner;
					yield return PerformAction.Effect(fakeRemi, "ReimiCharge", 0f, null, 0f, PerformAction.EffectBehavior.PlayOneShot, 0f);
					yield return PerformAction.Sfx("雷米结束回合", 0f);
					yield return new RequestEndPlayerTurnAction();
					base.Count = base.Limit;
					fakeRemi = null;
					fakeRemi = null;
				}
			}
			yield break;
		}

		private IEnumerable<BattleAction> OnTurnStarting(UnitEventArgs args)
		{
			base.Count = base.Limit;
			bool flag = !base.Battle.Player.IsExtraTurn && !base.Battle.Player.IsSuperExtraTurn;
			if (flag)
			{
				yield return new RemoveStatusEffectAction(this, true, 0.1f);
			}
			yield break;
		}
	}
}
