using System;
using System.Collections.Generic;
using LBoL.Base.Extensions;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Cards;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoLEntitySideloader.Attributes;

namespace ReimuUnifierMod.StatusEffects
{
	[EntityLogic(typeof(ReimuUnifierRabbleRousingSeDef))]
	public sealed class ReimuUnifierRabbleRousingSe : StatusEffect
	{
		protected override void OnAdded(Unit unit)
		{
			base.ReactOwnerEvent<UnitEventArgs>(base.Owner.TurnStarted, new EventSequencedReactor<UnitEventArgs>(this.OnOwnerTurnStarted));
		}

		private IEnumerable<BattleAction> OnOwnerTurnStarted(UnitEventArgs args)
		{
			yield return new AddCardsToHandAction(new Card[] { new List<Card>
			{
				Library.CreateCard("ReimuUnifierMarisaKirisameFriend"),
				Library.CreateCard("ReimuUnifierYukariYakumoFriend"),
				Library.CreateCard("ReimuUnifierKogasaYoukaiBlacksmithFriend")
			}.Sample(base.GameRun.BattleRng) });
			base.Duration--;
			bool flag = base.Duration <= 0;
			if (flag)
			{
				yield return new RemoveStatusEffectAction(this, true, 0.1f);
			}
			yield break;
		}
	}
}
