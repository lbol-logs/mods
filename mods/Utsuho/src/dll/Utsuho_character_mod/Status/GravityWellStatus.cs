using System;
using System.Collections.Generic;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Cards;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoLEntitySideloader.Attributes;

namespace Utsuho_character_mod.Status
{
	[EntityLogic(typeof(GravityWellEffect))]
	public sealed class GravityWellStatus : StatusEffect
	{
		protected override void OnAdded(Unit unit)
		{
			base.ReactOwnerEvent<UnitEventArgs>(base.Owner.TurnEnded, new EventSequencedReactor<UnitEventArgs>(this.OnOwnerTurnEnded));
		}

		private IEnumerable<BattleAction> OnOwnerTurnEnded(UnitEventArgs args)
		{
			bool battleShouldEnd = base.Battle.BattleShouldEnd;
			if (battleShouldEnd)
			{
				yield break;
			}
			base.NotifyActivating();
			yield return new CastBlockShieldAction(base.Owner, base.Owner, 0, base.Level, BlockShieldType.Direct, false);
			yield return new AddCardsToHandAction(new Card[] { Library.CreateCard("DarkMatter") });
			yield break;
		}
	}
}
