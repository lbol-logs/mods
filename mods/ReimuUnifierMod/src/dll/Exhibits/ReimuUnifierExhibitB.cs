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
	[EntityLogic(typeof(ReimuUnifierExhibitBDef))]
	public sealed class ReimuUnifierExhibitB : ShiningExhibit
	{
		protected override void OnEnterBattle()
		{
			base.ReactBattleEvent<CardUsingEventArgs>(base.Battle.CardUsed, new EventSequencedReactor<CardUsingEventArgs>(this.OnCardUsed));
		}

		private IEnumerable<BattleAction> OnCardUsed(CardUsingEventArgs args)
		{
			bool battleShouldEnd = base.Battle.BattleShouldEnd;
			if (battleShouldEnd)
			{
				yield break;
			}
			bool flag = args.Card.CardType == CardType.Friend && args.Card.Summoning;
			if (flag)
			{
				base.NotifyActivating();
				yield return new CastBlockShieldAction(base.Battle.Player, 0, 3, BlockShieldType.Direct, false);
			}
			yield break;
		}
	}
}
