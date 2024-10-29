using System;
using System.Collections.Generic;
using System.Linq;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoLEntitySideloader.Attributes;
using PatchouliCharacterMod.Cards;

namespace PatchouliCharacterMod.StatusEffects
{
	[EntityLogic(typeof(PatchouliAstronomyStudySeDef))]
	public sealed class PatchouliAstronomyStudySe : StatusEffect
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
			List<PatchouliAstronomy> list = base.Battle.HandZone.OfType<PatchouliAstronomy>().ToList<PatchouliAstronomy>();
			bool flag = list.Count < base.Level;
			if (flag)
			{
				base.NotifyActivating();
				yield return new AddCardsToHandAction(Library.CreateCards<PatchouliAstronomy>(base.Level - list.Count, false), AddCardsType.Normal);
			}
			yield break;
		}
	}
}
