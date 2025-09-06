using System;
using System.Collections.Generic;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoLEntitySideloader.Attributes;
using lvalonexrumia.Cards;

namespace lvalonexrumia.StatusEffects
{
	[EntityLogic(typeof(sedearswordDef))]
	public sealed class sedearsword : StatusEffect
	{
		protected override void OnAdded(Unit unit)
		{
			base.ReactOwnerEvent<UnitEventArgs>(base.Battle.Player.TurnStarted, new EventSequencedReactor<UnitEventArgs>(this.OnTurnStarted));
		}

		private IEnumerable<BattleAction> OnTurnStarted(UnitEventArgs args)
		{
			base.NotifyActivating();
			yield return new AddCardsToHandAction(Library.CreateCards<cardbloodstorm>(base.Level, false), AddCardsType.Normal);
			yield break;
		}
	}
}
