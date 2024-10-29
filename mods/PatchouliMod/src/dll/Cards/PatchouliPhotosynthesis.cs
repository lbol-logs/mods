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
using PatchouliCharacterMod.Cards.Template;
using PatchouliCharacterMod.StatusEffects;

namespace PatchouliCharacterMod.Cards
{
	[EntityLogic(typeof(PatchouliPhotosynthesisDef))]
	public sealed class PatchouliPhotosynthesis : PatchouliCard
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
				interaction = new SelectHandInteraction(0, base.Value2, list);
			}
			return interaction;
		}

		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			bool flag = precondition != null;
			if (flag)
			{
				IReadOnlyList<Card> cards = ((SelectHandInteraction)precondition).SelectedCards;
				bool flag2 = cards.Count > 0;
				if (flag2)
				{
					yield return new ExileManyCardAction(cards);
					yield return base.BuffAction<PatchouliSunSignSe>(cards.Count, 0, 0, PatchouliSignSe.TurnLimit, 0.2f);
				}
				cards = null;
				cards = null;
			}
			yield break;
		}
	}
}
