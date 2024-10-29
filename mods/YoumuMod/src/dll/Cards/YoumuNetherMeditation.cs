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
	[EntityLogic(typeof(YoumuNetherMeditationDef))]
	public sealed class YoumuNetherMeditation : YoumuCard
	{
		public override Interaction Precondition()
		{
			List<Card> list = base.Battle.HandZone.Where((Card hand) => hand != this).ToList<Card>();
			List<Card> list2 = new List<Card>();
			bool flag = list.Count <= 0;
			Interaction interaction;
			if (flag)
			{
				interaction = null;
			}
			else
			{
				foreach (Card card in list.Where((Card c) => c.CardType == CardType.Attack && !c.IsCopy))
				{
					list2.Add(card);
				}
				bool flag2 = list2.Count <= 0;
				if (flag2)
				{
					interaction = null;
				}
				else
				{
					interaction = new SelectHandInteraction(0, base.Value2, list2);
				}
			}
			return interaction;
		}

		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			bool flag = precondition != null;
			if (flag)
			{
				Card origin = ((SelectHandInteraction)precondition).SelectedCards[0];
				List<Card> list = new List<Card>();
				int num;
				for (int i = 0; i < base.Value1; i = num + 1)
				{
					Card card = origin.CloneBattleCard();
					card.IsCopy = true;
					list.Add(card);
					card = null;
					num = i;
				}
				yield return new AddCardsToHandAction(list, AddCardsType.Normal);
				origin = null;
				list = null;
			}
			yield break;
		}
	}
}
