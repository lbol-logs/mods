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
using Sanae_Kochiya.Cards.Template;

namespace Sanae_Kochiya.Source.Cards.Common
{
	[EntityLogic(typeof(SanaeBlockDiscardDef))]
	public sealed class SanaeBlockDiscard : SampleCharacterCard
	{
		public override Interaction Precondition()
		{
			List<Card> list = base.Battle.HandZone.Where((Card hand) => hand != this).ToList<Card>();
			bool flag = list.Count > 0;
			Interaction interaction;
			if (flag)
			{
				interaction = new SelectCardInteraction(base.Value1, 1, list, SelectedCardHandling.DoNothing);
			}
			else
			{
				interaction = null;
			}
			return interaction;
		}

		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			yield return base.DefenseAction(true);
			bool flag = precondition != null;
			if (flag)
			{
				IReadOnlyList<Card> cards = ((SelectCardInteraction)precondition).SelectedCards;
				bool flag2 = cards.Count > 0;
				if (flag2)
				{
					yield return new DiscardManyAction(cards);
				}
				yield break;
			}
			yield break;
		}
	}
}
