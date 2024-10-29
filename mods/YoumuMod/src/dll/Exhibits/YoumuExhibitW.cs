using System;
using System.Collections.Generic;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Cards;
using LBoL.EntityLib.Exhibits;
using LBoLEntitySideloader.Attributes;
using YoumuCharacterMod.Cards;

namespace YoumuCharacterMod.Exhibits
{
	[EntityLogic(typeof(YoumuExhibitWDef))]
	public sealed class YoumuExhibitW : ShiningExhibit
	{
		protected override void OnEnterBattle()
		{
			base.ReactBattleEvent<UnitEventArgs>(base.Battle.Player.TurnStarted, new EventSequencedReactor<UnitEventArgs>(this.OnPlayerTurnStarted));
		}

		private IEnumerable<BattleAction> OnPlayerTurnStarted(UnitEventArgs args)
		{
			bool flag = base.Battle.Player.TurnCounter == 1;
			if (flag)
			{
				base.NotifyActivating();
				yield return new AddCardsToHandAction(new Card[] { Library.CreateCard<YoumuSlashOfPresent>() });
			}
			yield break;
		}
	}
}
