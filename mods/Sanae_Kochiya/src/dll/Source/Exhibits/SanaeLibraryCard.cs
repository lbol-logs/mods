using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.EntityLib.StatusEffects.Basic;
using LBoLEntitySideloader.Attributes;

namespace Sanae_Kochiya.Source.Exhibits
{
	[EntityLogic(typeof(SanaeLibraryCardDef))]
	public sealed class SanaeLibraryCard : Exhibit
	{
		protected override void OnEnterBattle()
		{
			base.ReactBattleEvent<UnitEventArgs>(base.Battle.Player.TurnStarted, new EventSequencedReactor<UnitEventArgs>(this.OnPlayerTurnStarted));
			base.HandleBattleEvent<CardUsingEventArgs>(base.Battle.CardUsed, new GameEventHandler<CardUsingEventArgs>(this.OnCardUsed));
		}

		private void OnCardUsed(CardUsingEventArgs args)
		{
			bool flag = args.Card.CardType == CardType.Attack;
			if (flag)
			{
				base.Active = false;
			}
		}

		private IEnumerable<BattleAction> OnPlayerTurnStarted(UnitEventArgs args)
		{
			bool active = base.Active;
			if (active)
			{
				base.NotifyActivating();
				yield return new ApplyStatusEffectAction<AmuletForCard>(base.Owner, new int?(base.Value1), new int?(0), new int?(0), new int?(0), 0.2f, true);
			}
			base.Active = true;
			yield break;
		}

		protected override void OnLeaveBattle()
		{
			base.Active = false;
		}
	}
}
