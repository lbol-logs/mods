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
using YoumuCharacterMod.Cards.Template;

namespace YoumuCharacterMod.Cards
{
	[EntityLogic(typeof(YoumuReinforcementOfTheArmyDef))]
	public sealed class YoumuReinforcementOfTheArmy : YoumuCard
	{
		public override Interaction Precondition()
		{
			IReadOnlyList<Card> drawZoneIndexOrder = base.Battle.DrawZoneIndexOrder;
			List<Card> list = new List<Card>();
			bool flag = drawZoneIndexOrder.Count <= 0;
			Interaction interaction;
			if (flag)
			{
				interaction = null;
			}
			else
			{
				foreach (Card card in drawZoneIndexOrder.Where((Card c) => c.CardType == CardType.Attack))
				{
					list.Add(card);
				}
				bool flag2 = list.Count <= 0;
				if (flag2)
				{
					interaction = null;
				}
				else
				{
					interaction = new SelectCardInteraction(0, base.Value1, list, SelectedCardHandling.DoNothing);
				}
			}
			return interaction;
		}

		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			SelectCardInteraction selectCardInteraction = (SelectCardInteraction)precondition;
			IReadOnlyList<Card> readOnlyList = ((selectCardInteraction != null) ? selectCardInteraction.SelectedCards : null);
			bool flag = readOnlyList != null && readOnlyList.Count > 0;
			if (flag)
			{
				foreach (Card card in readOnlyList)
				{
					card.SetTurnCost(base.Mana);
					yield return new MoveCardAction(card, CardZone.Hand);
					card = null;
				}
				IEnumerator<Card> enumerator = null;
			}
			yield break;
			yield break;
		}
	}
}
