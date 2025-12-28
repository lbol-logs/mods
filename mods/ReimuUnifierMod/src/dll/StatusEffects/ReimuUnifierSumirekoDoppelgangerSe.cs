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
	[EntityLogic(typeof(ReimuUnifierSumirekoDoppelgangerSeDef))]
	public sealed class ReimuUnifierSumirekoDoppelgangerSe : StatusEffect
	{
		protected override void OnAdded(Unit unit)
		{
			base.ReactOwnerEvent<UnitEventArgs>(base.Owner.TurnStarting, new EventSequencedReactor<UnitEventArgs>(this.OnOwnerTurnStarting));
			base.ReactOwnerEvent<CardUsingEventArgs>(base.Battle.CardUsing, new EventSequencedReactor<CardUsingEventArgs>(this.OnOwnerCardUsing));
		}

		private IEnumerable<BattleAction> OnOwnerTurnStarting(UnitEventArgs args)
		{
			bool flag = !base.Battle.BattleShouldEnd && base.Battle.EnemyGroup.Alives != null;
			if (flag)
			{
				yield return new RemoveStatusEffectAction(this, true, 0.1f);
			}
			yield break;
		}

		private IEnumerable<BattleAction> OnOwnerCardUsing(CardUsingEventArgs args)
		{
			args.PlayTwice = true;
			args.AddModifier(this);
			yield break;
		}
	}
}
