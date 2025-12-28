using System;
using System.Collections.Generic;
using System.Linq;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Battle.Interactions;
using LBoL.Core.Cards;
using LBoLEntitySideloader.Attributes;
using ReimuUnifierMod.Cards.Template;

namespace ReimuUnifierMod.Cards
{
	[EntityLogic(typeof(ReimuUnifierPerfectPosessionDef))]
	public sealed class ReimuUnifierPerfectPosession : ReimuUnifierCard
	{
		public override Interaction Precondition()
		{
			List<Card> list = base.Battle.HandZone.Where((Card hand) => hand != this).ToList<Card>();
			bool flag = list.Count <= 0;
			Interaction interaction;
			if (flag)
			{
				interaction = null;
			}
			else
			{
				interaction = new SelectHandInteraction(0, 1, list);
			}
			return interaction;
		}

		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			List<Card> hand = base.Battle.HandZone.ToList<Card>();
			bool flag = precondition != null;
			if (flag)
			{
				foreach (Card item in ((SelectHandInteraction)precondition).SelectedCards)
				{
					hand.Remove(item);
					item = null;
				}
				IEnumerator<Card> enumerator = null;
			}
			bool flag2 = hand.Count > 0;
			if (flag2)
			{
				yield return new ExileManyCardAction(hand);
				yield return new CastBlockShieldAction(base.Battle.Player, 0, base.Value1 * hand.Count, BlockShieldType.Normal, true);
				int TeammatesInHand = 0;
				foreach (Card card in hand)
				{
					bool flag3 = card.CardType == CardType.Friend;
					if (flag3)
					{
						int num = TeammatesInHand;
						TeammatesInHand = num + 1;
					}
					card = null;
				}
				List<Card>.Enumerator enumerator2 = default(List<Card>.Enumerator);
				yield return new GainManaAction(ManaGroup.Blues(TeammatesInHand));
			}
			yield break;
		}
	}
}
