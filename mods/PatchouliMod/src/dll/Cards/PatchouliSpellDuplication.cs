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

namespace PatchouliCharacterMod.Cards
{
	[EntityLogic(typeof(PatchouliSpellDuplicationDef))]
	public sealed class PatchouliSpellDuplication : PatchouliCard
	{
		public override Interaction Precondition()
		{
			List<Card> list = base.Battle.HandZone.Where((Card hand) => hand != this && hand.CanBeDuplicated).ToList<Card>();
			bool flag = list.Count <= 0;
			Interaction interaction;
			if (flag)
			{
				interaction = null;
			}
			else
			{
				interaction = new SelectHandInteraction(1, 1, list);
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
					card.SetTurnCost(base.Mana);
					card.IsExile = true;
					card.IsEthereal = true;
					PatchouliBoostCard boostOrigin = origin as PatchouliBoostCard;
					PatchouliBoostCard boostCard;
					bool flag2;
					if (boostOrigin != null)
					{
						boostCard = card as PatchouliBoostCard;
						flag2 = boostCard != null;
					}
					else
					{
						flag2 = false;
					}
					bool flag3 = flag2;
					if (flag3)
					{
						boostCard.Boost = boostOrigin.Boost;
						list.Add(boostCard);
					}
					else
					{
						list.Add(card);
					}
					card = null;
					boostOrigin = null;
					boostCard = null;
					num = i;
				}
				yield return new AddCardsToHandAction(list, AddCardsType.Normal);
				bool flag4 = origin.CardType == CardType.Ability || origin.IsExile;
				if (flag4)
				{
					origin.IsCopy = true;
				}
				origin = null;
				list = null;
			}
			yield break;
		}
	}
}
