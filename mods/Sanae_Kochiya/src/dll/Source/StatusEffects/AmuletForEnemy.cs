using System;
using System.Collections.Generic;
using System.Linq;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Cards;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoL.EntityLib.StatusEffects.Neutral.TwoColor;
using LBoLEntitySideloader.Attributes;

namespace Sanae_Kochiya.Source.StatusEffects
{
	[EntityLogic(typeof(AmuletForEnemyDef))]
	public sealed class AmuletForEnemy : StatusEffect
	{
		protected override void OnAdded(Unit unit)
		{
			base.ReactOwnerEvent<CardsEventArgs>(base.Battle.CardsAddedToDiscard, new EventSequencedReactor<CardsEventArgs>(this.OnAddCard));
			base.ReactOwnerEvent<CardsEventArgs>(base.Battle.CardsAddedToHand, new EventSequencedReactor<CardsEventArgs>(this.OnAddCard));
			base.ReactOwnerEvent<CardsEventArgs>(base.Battle.CardsAddedToExile, new EventSequencedReactor<CardsEventArgs>(this.OnAddCard));
			base.ReactOwnerEvent<CardsAddingToDrawZoneEventArgs>(base.Battle.CardsAddedToDrawZone, new EventSequencedReactor<CardsAddingToDrawZoneEventArgs>(this.OnCardsAddedToDrawZone));
		}

		private IEnumerable<BattleAction> OnAddCard(CardsEventArgs args)
		{
			return this.ExileCard(args.Cards);
		}

		private IEnumerable<BattleAction> OnCardsAddedToDrawZone(CardsAddingToDrawZoneEventArgs args)
		{
			return this.ExileCard(args.Cards);
		}

		private IEnumerable<BattleAction> ExileCard(IEnumerable<Card> cards)
		{
			List<Card> candidate = cards.Where((Card card) => card.CardType != CardType.Status && card.Zone != CardZone.Exile).ToList<Card>();
			bool flag = candidate.Count == 0;
			if (flag)
			{
				yield break;
			}
			bool flag2 = base.Level < candidate.Count;
			if (flag2)
			{
				candidate.RemoveRange(base.Level, candidate.Count - base.Level);
			}
			base.NotifyActivating();
			bool flag3 = base.Battle.Player.HasStatusEffect<RainbowMarketSe>();
			if (flag3)
			{
				foreach (Card card2 in candidate)
				{
					yield return new MoveCardAction(card2, CardZone.Exile);
					card2 = null;
				}
				List<Card>.Enumerator enumerator = default(List<Card>.Enumerator);
			}
			else
			{
				yield return new ExileManyCardAction(candidate);
			}
			base.Level -= candidate.Count;
			bool flag4 = base.Level <= 0;
			if (flag4)
			{
				yield return new RemoveStatusEffectAction(this, true, 0.1f);
			}
			yield break;
			yield break;
		}
	}
}
