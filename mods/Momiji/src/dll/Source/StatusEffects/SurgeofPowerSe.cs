using System;
using System.Collections.Generic;
using JetBrains.Annotations;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Cards;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoLEntitySideloader.Attributes;

namespace Momiji.Source.StatusEffects
{
	[EntityLogic(typeof(SurgeofPowerSeDef))]
	public sealed class SurgeofPowerSe : StatusEffect
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
				bool flag = card.CardType == CardType.Attack || card.CardType == CardType.Skill || card.CardType == CardType.Defense || card.CardType == CardType.Ability || card.CardType == CardType.Status || card.CardType == CardType.Misfortune;
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
				bool flag = card.CardType == CardType.Attack || card.CardType == CardType.Skill || card.CardType == CardType.Defense || card.CardType == CardType.Ability || card.CardType == CardType.Status || card.CardType == CardType.Misfortune;
				if (flag)
				{
					card.FreeCost = false;
				}
			}
		}

		private IEnumerable<BattleAction> OnCardUsed(CardUsingEventArgs args)
		{
			bool flag = args.Card.CardType == CardType.Attack || args.Card.CardType == CardType.Skill || args.Card.CardType == CardType.Defense || args.Card.CardType == CardType.Ability || args.Card.CardType == CardType.Status || args.Card.CardType == CardType.Misfortune;
			if (flag)
			{
				int level = base.Level - 1;
				base.Level = level;
				bool flag2 = base.Level <= 0;
				if (flag2)
				{
					yield return new RemoveStatusEffectAction(this, true, 0.1f);
				}
			}
			yield break;
		}

		[UsedImplicitly]
		public ManaGroup Mana = ManaGroup.Empty;
	}
}
