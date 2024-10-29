using System;
using System.Collections.Generic;
using System.Linq;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.Interactions;
using LBoL.Core.Cards;
using LBoLEntitySideloader.Attributes;
using PatchouliCharacterMod.BattleActions;
using PatchouliCharacterMod.Cards.Template;

namespace PatchouliCharacterMod.Cards
{
	[EntityLogic(typeof(PatchouliSummerRedDef))]
	public sealed class PatchouliSummerRed : PatchouliCard
	{
		public override Interaction Precondition()
		{
			List<Card> list = base.Battle.HandZone.Where((Card hand) => hand != this && !hand.IsRetain).ToList<Card>();
			bool flag = list.Count == 1;
			if (flag)
			{
				this.oneTargetHand = list[0];
			}
			bool flag2 = list.Count <= 1;
			Interaction interaction;
			if (flag2)
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
				Card card = ((SelectHandInteraction)precondition).SelectedCards[0];
				bool flag2 = card != null;
				if (flag2)
				{
					card.IsTempRetain = true;
					PatchouliBoostCard boostCard = card as PatchouliBoostCard;
					bool flag3 = boostCard != null;
					if (flag3)
					{
						yield return new BoostAction(boostCard, base.Value2);
					}
					boostCard = null;
				}
				card = null;
			}
			yield break;
		}

		private Card oneTargetHand;
	}
}
