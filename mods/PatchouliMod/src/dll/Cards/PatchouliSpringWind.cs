using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Base.Extensions;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Battle.Interactions;
using LBoL.Core.Cards;
using LBoL.EntityLib.Cards.Neutral.NoColor;
using LBoLEntitySideloader.Attributes;
using PatchouliCharacterMod.Cards.Template;

namespace PatchouliCharacterMod.Cards
{
	[EntityLogic(typeof(PatchouliSpringWindDef))]
	public sealed class PatchouliSpringWind : PatchouliBoostCard
	{
		protected override bool HasTreshold { get; set; } = true;

		protected override int BoostThreshold1 { get; set; } = 5;

		public override Interaction Precondition()
		{
			List<Card> list = new List<Card>();
			foreach (Card card in base.Battle.HandZone)
			{
				bool flag = card != this && !card.IsEcho && card.CanBeDuplicated;
				if (flag)
				{
					list.Add(card);
				}
			}
			bool flag2 = list.Count <= 0;
			Interaction interaction;
			if (flag2)
			{
				interaction = null;
			}
			else
			{
				interaction = new SelectHandInteraction(0, base.Value1, list);
			}
			return interaction;
		}

		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			bool flag = precondition != null;
			if (flag)
			{
				IReadOnlyList<Card> selectedCards = ((SelectHandInteraction)precondition).SelectedCards;
				bool flag2 = selectedCards.NotEmpty<Card>();
				if (flag2)
				{
					foreach (Card card in selectedCards)
					{
						card.IsEcho = true;
						card = null;
					}
					IEnumerator<Card> enumerator = null;
				}
				selectedCards = null;
			}
			bool flag3 = base.Boost >= this.BoostThreshold1;
			if (flag3)
			{
				bool isUpgraded = this.IsUpgraded;
				if (isUpgraded)
				{
					yield return new AddCardsToHandAction(Library.CreateCards<PManaCard>(base.Value1, false), AddCardsType.Normal);
				}
				else
				{
					yield return new AddCardsToHandAction(Library.CreateCards<GManaCard>(base.Value1, false), AddCardsType.Normal);
				}
				base.ResetBoost();
			}
			yield break;
		}
	}
}
