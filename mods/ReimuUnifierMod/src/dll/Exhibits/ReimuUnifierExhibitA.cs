using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.EntityLib.Exhibits;
using LBoLEntitySideloader.Attributes;

namespace ReimuUnifierMod.Exhibits
{
	[EntityLogic(typeof(ReimuUnifierExhibitADef))]
	public sealed class ReimuUnifierExhibitA : ShiningExhibit
	{
		public ManaGroup Mana2 { get; } = ManaGroup.Reds(2);

		protected override void OnEnterBattle()
		{
			base.OnEnterBattle();
			base.Counter = 0;
			base.Blackout = false;
			base.Active = true;
			base.ReactBattleEvent<CardUsingEventArgs>(base.Battle.CardUsed, new EventSequencedReactor<CardUsingEventArgs>(this.OnCardUsed));
		}

		protected override void OnLeaveBattle()
		{
			base.OnLeaveBattle();
			base.Counter = 0;
			base.Blackout = true;
			base.Active = false;
			base.ReactBattleEvent<CardUsingEventArgs>(base.Battle.CardUsed, new EventSequencedReactor<CardUsingEventArgs>(this.OnCardUsed));
		}

		private IEnumerable<BattleAction> OnCardUsed(CardUsingEventArgs args)
		{
			bool flag = base.Battle.BattleShouldEnd || base.Counter == 1;
			if (flag)
			{
				yield break;
			}
			bool flag2 = args.Card.CardType == CardType.Friend && args.Card.Summoning;
			if (flag2)
			{
				base.NotifyActivating();
				yield return new GainManaAction(ManaGroup.Reds(base.Value1));
				base.Counter = 1;
				base.Blackout = true;
				base.Active = false;
			}
			yield break;
		}
	}
}
