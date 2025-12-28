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
using LBoLEntitySideloader.Attributes;

namespace ReimuUnifierMod.StatusEffects
{
	[EntityLogic(typeof(ReimuUnifierDuplexBarrierDanmakuMirrorSeDef))]
	public sealed class ReimuUnifierDuplexBarrierDanmakuMirrorSe : StatusEffect
	{
		private ManaGroup SePreviewMana
		{
			get
			{
				return ManaGroup.Anys(0);
			}
		}

		protected override void OnAdded(Unit unit)
		{
			base.ReactOwnerEvent<CardUsingEventArgs>(base.Battle.CardUsed, new EventSequencedReactor<CardUsingEventArgs>(this.OnCardUsed));
			base.ReactOwnerEvent<UnitEventArgs>(base.Owner.TurnStarted, new EventSequencedReactor<UnitEventArgs>(this.OnTurnStarted));
		}

		private IEnumerable<BattleAction> OnCardUsed(CardUsingEventArgs args)
		{
			bool flag = !this.Battle.BattleShouldEnd;
			if (flag)
			{
				Card card = args.Card;
				bool flag2 = card.CardType == CardType.Friend && card.Summoning && !card.IsCopy;
				if (flag2)
				{
					this.NotifyActivating();
					Card Copy = card.CloneBattleCard();
					Copy.IsCopy = true;
					Copy.SetTurnCost(ManaGroup.Empty);
					Copy.SetKeyword(Keyword.Ethereal, true);
					yield return new AddCardsToHandAction(new Card[] { Copy });
					yield break;
				}
				card = null;
			}
			yield break;
		}

		private IEnumerable<BattleAction> OnTurnStarted(UnitEventArgs args)
		{
			List<Card> TeammatesInHand = base.Battle.HandZone.Where((Card card) => card.CardType == CardType.Friend && card.Summoned).ToList<Card>();
			base.NotifyActivating();
			foreach (Card card3 in TeammatesInHand)
			{
				card3.NotifyActivating();
				Card card2 = card3;
				int loyalty = card2.Loyalty;
				card2.Loyalty = loyalty + 1;
				card3 = null;
			}
			List<Card>.Enumerator enumerator = default(List<Card>.Enumerator);
			yield break;
		}
	}
}
