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
using PatchouliCharacterMod.BattleActions;
using PatchouliCharacterMod.Cards.Template;

namespace PatchouliCharacterMod.Cards.B
{
	[EntityLogic(typeof(PatchouliMagicalResearchDef))]
	public sealed class PatchouliMagicalResearch : PatchouliCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			Type[] allPatchouliEtherealCards = PatchouliBoostCard.AllBoostCard.SampleManyOrAll(base.Value1, base.GameRun.BattleCardRng);
			List<Card> list = new List<Card>();
			Type[] array2 = allPatchouliEtherealCards;
			int num;
			for (int i = 0; i < array2.Length; i = num + 1)
			{
				Card PatchouliEtherealCard = Library.CreateCard(array2[i]);
				list.Add(PatchouliEtherealCard);
				PatchouliEtherealCard = null;
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
				selectedCard.IsEthereal = true;
				yield return new AddCardsToHandAction(new Card[] { selectedCard });
				interaction = null;
				selectedCard = null;
			}
			yield return new BoostAllInHandAction(base.Value2);
			yield break;
		}
	}
}
