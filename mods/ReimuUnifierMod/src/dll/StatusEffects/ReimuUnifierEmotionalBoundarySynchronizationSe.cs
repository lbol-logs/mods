using System;
using System.Collections.Generic;
using System.Linq;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Cards;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoLEntitySideloader.Attributes;

namespace ReimuUnifierMod.StatusEffects
{
	[EntityLogic(typeof(ReimuUnifierEmotionalBoundarySynchronizationSeDef))]
	public sealed class ReimuUnifierEmotionalBoundarySynchronizationSe : StatusEffect
	{
		protected override void OnAdded(Unit unit)
		{
			base.ReactOwnerEvent<CardUsingEventArgs>(base.Battle.CardUsed, new EventSequencedReactor<CardUsingEventArgs>(this.OnCardUsed));
		}

		private IEnumerable<BattleAction> OnCardUsed(CardUsingEventArgs args)
		{
			bool battleShouldEnd = base.Battle.BattleShouldEnd;
			if (battleShouldEnd)
			{
				yield break;
			}
			Card card = args.Card;
			bool flag = card.CardType == CardType.Friend && !card.Summoning;
			if (flag)
			{
				base.NotifyActivating();
				List<Card> TeammatesInHand = base.Battle.HandZone.Where((Card Hand) => Hand.CardType == CardType.Friend).ToList<Card>();
				foreach (Card Teammate in TeammatesInHand)
				{
					Teammate.NotifyActivating();
					Teammate.Loyalty++;
					Teammate = null;
				}
				List<Card>.Enumerator enumerator = default(List<Card>.Enumerator);
				TeammatesInHand = null;
			}
			yield break;
		}
	}
}
