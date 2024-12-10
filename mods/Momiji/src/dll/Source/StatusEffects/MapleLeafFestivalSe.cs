using System;
using System.Collections.Generic;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoLEntitySideloader.Attributes;

namespace Momiji.Source.StatusEffects
{
	[EntityLogic(typeof(MapleLeafFestivalSeDef))]
	public sealed class MapleLeafFestivalSe : StatusEffect
	{
		protected override void OnAdded(Unit unit)
		{
			base.ReactOwnerEvent<UnitEventArgs>(base.Owner.TurnStarted, new EventSequencedReactor<UnitEventArgs>(this.OnOwnerTurnStarted));
		}

		private IEnumerable<BattleAction> OnOwnerTurnStarted(UnitEventArgs args)
		{
			bool battleShouldEnd = base.Battle.BattleShouldEnd;
			if (battleShouldEnd)
			{
				yield break;
			}
			base.NotifyActivating();
			yield return new AddCardsToHandAction(Library.CreateCards<MapleLeaf>(base.Level, false), AddCardsType.Normal);
			yield break;
		}
	}
}
