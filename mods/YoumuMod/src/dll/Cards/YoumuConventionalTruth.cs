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
using YoumuCharacterMod.BattleActions;
using YoumuCharacterMod.Cards.Template;

namespace YoumuCharacterMod.Cards
{
	[EntityLogic(typeof(YoumuConventionalTruthDef))]
	public sealed class YoumuConventionalTruth : YoumuCard
	{
		public override Interaction Precondition()
		{
			List<Card> list = base.Battle.ExileZone.Where((Card exile) => exile != this && exile.Id != base.Id).ToList<Card>();
			bool flag = list.Count <= 0;
			Interaction interaction;
			if (flag)
			{
				interaction = null;
			}
			else
			{
				interaction = new SelectCardInteraction(0, base.Value1, list, SelectedCardHandling.DoNothing);
			}
			return interaction;
		}

		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			SelectCardInteraction selectCardInteraction = (SelectCardInteraction)precondition;
			SelectCardInteraction selectCardInteraction2 = selectCardInteraction;
			Card card2;
			if (selectCardInteraction2 == null || selectCardInteraction2.SelectedCards.Count <= 0)
			{
				card2 = null;
			}
			else
			{
				SelectCardInteraction selectCardInteraction3 = selectCardInteraction;
				card2 = ((selectCardInteraction3 != null) ? selectCardInteraction3.SelectedCards[0] : null);
			}
			Card card = card2;
			bool flag = card != null;
			if (flag)
			{
				yield return new MoveCardAction(card, CardZone.Hand);
			}
			yield return new UnsheatheAllInHandAction();
			yield break;
		}
	}
}
