using System;
using System.Collections.Generic;
using System.Linq;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Cards;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoLEntitySideloader.Attributes;

namespace ReimuUnifierMod.StatusEffects
{
	[EntityLogic(typeof(ReimuUnifierDanmakuCollisionSeDef))]
	public sealed class ReimuUnifierDanmakuCollisionSe : StatusEffect
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
			base.ReactOwnerEvent<UnitEventArgs>(unit.TurnEnded, new EventSequencedReactor<UnitEventArgs>(this.OnOwnerTurnEnded));
		}

		private IEnumerable<BattleAction> OnOwnerTurnEnded(UnitEventArgs args)
		{
			yield return new CastBlockShieldAction(base.Battle.Player, base.Level * this.SummonedTeammatesInHand, 0, BlockShieldType.Direct, false);
			yield break;
		}
	}
}
