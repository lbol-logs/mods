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
	[EntityLogic(typeof(YoumuHalfBodyDistillationDef))]
	public sealed class YoumuHalfBodyDistillation : YoumuCard
	{
		public override Interaction Precondition()
		{
			IReadOnlyList<Card> exileZone = base.Battle.ExileZone;
			List<Card> list = new List<Card>();
			bool flag = exileZone.Count <= 0;
			Interaction interaction;
			if (flag)
			{
				interaction = null;
			}
			else
			{
				foreach (Card card in exileZone.Where((Card c) => (c.IsEthereal && c is YoumuCard) || YoumuCard.IsSlashCard(c)))
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
			yield return base.DefenseAction(true);
			SelectCardInteraction selectCardInteraction = (SelectCardInteraction)precondition;
			IReadOnlyList<Card> readOnlyList = ((selectCardInteraction != null) ? selectCardInteraction.SelectedCards : null);
			bool flag = readOnlyList != null && readOnlyList.Count > 0;
			if (flag)
			{
				foreach (Card card in readOnlyList)
				{
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
