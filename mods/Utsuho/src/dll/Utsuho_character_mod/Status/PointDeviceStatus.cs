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
	[EntityLogic(typeof(PointDeviceEffect))]
	public sealed class PointDeviceStatus : StatusEffect
	{
		protected override void OnAdded(Unit unit)
		{
			this.CardToFree(base.Battle.EnumerateAllCards());
			base.ReactOwnerEvent<CardUsingEventArgs>(base.Battle.CardUsed, new EventSequencedReactor<CardUsingEventArgs>(this.OnCardUsed));
			base.HandleOwnerEvent<CardsEventArgs>(base.Battle.CardsAddedToDiscard, new GameEventHandler<CardsEventArgs>(this.OnAddCard));
			base.HandleOwnerEvent<CardsEventArgs>(base.Battle.CardsAddedToHand, new GameEventHandler<CardsEventArgs>(this.OnAddCard));
			base.HandleOwnerEvent<CardsEventArgs>(base.Battle.CardsAddedToExile, new GameEventHandler<CardsEventArgs>(this.OnAddCard));
			base.HandleOwnerEvent<CardsAddingToDrawZoneEventArgs>(base.Battle.CardsAddedToDrawZone, new GameEventHandler<CardsAddingToDrawZoneEventArgs>(this.OnAddCardToDraw));
		}

		private IEnumerable<BattleAction> OnCardUsed(CardUsingEventArgs args)
		{
			bool flag = args.Card.Id == "DarkMatter";
			if (flag)
			{
				yield return new MoveCardAction(args.Card, CardZone.Discard);
				yield return new DrawCardAction();
			}
			yield break;
		}

		private void OnAddCardToDraw(CardsAddingToDrawZoneEventArgs args)
		{
			this.CardToFree(args.Cards);
		}

		private void OnAddCard(CardsEventArgs args)
		{
			this.CardToFree(args.Cards);
		}

		private void CardToFree(IEnumerable<Card> cards)
		{
			foreach (Card card in cards)
			{
				bool flag = card.Id == "DarkMatter";
				if (flag)
				{
					card.FreeCost = true;
				}
			}
		}

		protected override void OnRemoved(Unit unit)
		{
			foreach (Card card in base.Battle.EnumerateAllCards())
			{
				bool flag = card.Id == "DarkMatter";
				if (flag)
				{
					card.FreeCost = false;
				}
			}
		}
	}
}
