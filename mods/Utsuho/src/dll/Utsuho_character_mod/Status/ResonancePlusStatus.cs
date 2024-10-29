using System;
using System.Collections.Generic;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoLEntitySideloader.Attributes;
using Utsuho_character_mod.CardsU;

namespace Utsuho_character_mod.Status
{
	[EntityLogic(typeof(ResonancePlusEffect))]
	public sealed class ResonancePlusStatus : StatusEffect
	{
		protected override void OnAdded(Unit unit)
		{
			base.ReactOwnerEvent<CardEventArgs>(base.Battle.CardExiled, new EventSequencedReactor<CardEventArgs>(this.OnCardExiled));
		}

		private IEnumerable<BattleAction> OnCardExiled(CardEventArgs args)
		{
			bool battleShouldEnd = base.Battle.BattleShouldEnd;
			if (battleShouldEnd)
			{
				yield break;
			}
			bool flag = args.Cause != ActionCause.AutoExile && args.Card.BaseName != "Resonance";
			if (flag)
			{
				base.NotifyActivating();
				yield return new AddCardsToHandAction(Library.CreateCards<ResonanceDef.Resonance>(1, true), AddCardsType.Normal);
			}
			yield break;
		}
	}
}
