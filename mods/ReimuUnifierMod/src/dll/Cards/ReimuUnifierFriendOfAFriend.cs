using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Battle.Interactions;
using LBoL.Core.Cards;
using LBoL.Core.Randoms;
using LBoLEntitySideloader.Attributes;
using ReimuUnifierMod.Cards.Template;

namespace ReimuUnifierMod.Cards
{
	[EntityLogic(typeof(ReimuUnifierFriendOfAFriendDef))]
	public sealed class ReimuUnifierFriendOfAFriend : ReimuUnifierCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			Card[] array = base.Battle.RollCardsWithoutManaLimit(new CardWeightTable(RarityWeightTable.BattleCard, OwnerWeightTable.AllOnes, CardTypeWeightTable.OnlyFriend, false), base.Value2, null);
			foreach (Card card in array)
			{
				card.SetBaseCost(ManaGroup.Anys(card.ConfigCost.Amount));
				card = null;
			}
			Card[] array2 = null;
			SelectCardInteraction interaction = new SelectCardInteraction(0, base.Value1, array, SelectedCardHandling.DoNothing)
			{
				Source = this
			};
			yield return new InteractionAction(interaction, false);
			IReadOnlyList<Card> selectedCards = interaction.SelectedCards;
			bool flag = selectedCards.Count > 0;
			if (flag)
			{
				foreach (Card card2 in selectedCards)
				{
					card2.SetTurnCost(new ManaGroup
					{
						Any = 0
					});
					card2.IsEthereal = true;
					card2.IsExile = true;
					card2 = null;
				}
				IEnumerator<Card> enumerator = null;
				yield return new AddCardsToHandAction(selectedCards, AddCardsType.Normal, false);
			}
			yield break;
		}
	}
}
