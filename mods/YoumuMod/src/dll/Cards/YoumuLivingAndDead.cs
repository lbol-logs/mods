using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Base.Extensions;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Battle.Interactions;
using LBoL.Core.Cards;
using LBoLEntitySideloader.Attributes;
using YoumuCharacterMod.Cards.Template;

namespace YoumuCharacterMod.Cards
{
	[EntityLogic(typeof(YoumuLivingAndDeadDef))]
	public sealed class YoumuLivingAndDead : YoumuCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			Type[] allYoumuEtherealCards = YoumuCard.AllEthereal.SampleManyOrAll(base.Value1, base.GameRun.BattleCardRng);
			List<Card> list = new List<Card>();
			Type[] array2 = allYoumuEtherealCards;
			int num;
			for (int i = 0; i < array2.Length; i = num + 1)
			{
				Card youmuEtherealCard = Library.CreateCard(array2[i]);
				list.Add(youmuEtherealCard);
				youmuEtherealCard = null;
				num = i;
			}
			bool flag = list.Count > 0;
			if (flag)
			{
				MiniSelectCardInteraction interaction = new MiniSelectCardInteraction(list, false, false, false)
				{
					Source = this
				};
				yield return new InteractionAction(interaction, false);
				Card selectedCard = interaction.SelectedCard;
				selectedCard.SetTurnCost(base.Mana);
				selectedCard.IsExile = true;
				yield return new AddCardsToHandAction(new Card[] { selectedCard });
				interaction = null;
				selectedCard = null;
			}
			yield break;
		}
	}
}
