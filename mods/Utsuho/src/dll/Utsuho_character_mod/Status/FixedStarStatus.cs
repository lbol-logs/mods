using System;
using System.Collections.Generic;
using System.Linq;
using LBoL.Base.Extensions;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Battle.Interactions;
using LBoL.Core.Cards;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoLEntitySideloader.Attributes;
using Utsuho_character_mod.CardsB;

namespace Utsuho_character_mod.Status
{
	[EntityLogic(typeof(FixedStarEffect))]
	public sealed class FixedStarStatus : StatusEffect
	{
		protected override void OnAdded(Unit unit)
		{
			base.ReactOwnerEvent<UnitEventArgs>(base.Owner.TurnEnding, new EventSequencedReactor<UnitEventArgs>(this.OnOwnerTurnEnding));
			base.HandleOwnerEvent<CardEventArgs>(base.Battle.CardDrawn, new GameEventHandler<CardEventArgs>(this.OnDrawCard));
		}

		private IEnumerable<BattleAction> OnOwnerTurnEnding(UnitEventArgs args)
		{
			bool battleShouldEnd = base.Battle.BattleShouldEnd;
			if (battleShouldEnd)
			{
				yield break;
			}
			base.NotifyActivating();
			IReadOnlyList<Card> selectedCards = null;
			List<Card> list = base.Battle.HandZone.ToList<Card>();
			bool flag = !list.Empty<Card>();
			if (flag)
			{
				SelectHandInteraction interaction = new SelectHandInteraction(0, base.Level, list)
				{
					Source = this
				};
				yield return new InteractionAction(interaction, false);
				selectedCards = interaction.SelectedCards.ToList<Card>();
				interaction = null;
			}
			bool flag2 = selectedCards != null;
			if (flag2)
			{
				foreach (Card card in selectedCards)
				{
					card.IsTempRetain = true;
					card = null;
				}
				IEnumerator<Card> enumerator = null;
			}
			yield break;
		}

		private void OnDrawCard(CardEventArgs args)
		{
			bool flag = args.Card is DarkMatterDef.DarkMatter;
			if (flag)
			{
				args.Card.IsAutoExile = true;
			}
		}
	}
}
