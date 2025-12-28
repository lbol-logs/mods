using System;
using System.Collections.Generic;
using System.Linq;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Cards;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoLEntitySideloader.Attributes;

namespace ReimuUnifierMod.StatusEffects
{
	[EntityLogic(typeof(ReimuUnifierRitualofEchoingProsperitySeDef))]
	public sealed class ReimuUnifierRitualofEchoingProsperitySe : StatusEffect
	{
		public int SummonedTeammatesInHand
		{
			get
			{
				int num;
				try
				{
					num = base.Battle.HandZone.Count((Card card) => card.CardType == CardType.Friend && card.Summoned);
				}
				catch
				{
					num = 0;
				}
				return num;
			}
		}

		protected override void OnAdded(Unit unit)
		{
			base.ReactOwnerEvent<UnitEventArgs>(base.Owner.TurnStarted, new EventSequencedReactor<UnitEventArgs>(this.OnOwnerTurnStarted));
		}

		private IEnumerable<BattleAction> OnOwnerTurnStarted(UnitEventArgs args)
		{
			bool flag = this.SummonedTeammatesInHand > 0;
			if (flag)
			{
				yield return base.BuffAction<TempFirepower>(base.Level * this.SummonedTeammatesInHand, 0, 0, 0, 0.2f);
				yield return base.BuffAction<TempSpirit>(base.Level * this.SummonedTeammatesInHand, 0, 0, 0, 0.2f);
			}
			yield break;
		}
	}
}
