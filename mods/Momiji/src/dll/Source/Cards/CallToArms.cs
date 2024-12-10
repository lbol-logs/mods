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

namespace Momiji.Source.Cards
{
	[EntityLogic(typeof(CallToArmsDef))]
	public sealed class CallToArms : SampleCharacterCard
	{
		public override Interaction Precondition()
		{
			IReadOnlyList<Card> readOnlyList = (from card in base.Battle.DrawZoneToShow.Concat(base.Battle.DiscardZone)
				where card != this
				select card).ToList<Card>();
			bool flag = readOnlyList.Count <= 0;
			Interaction interaction;
			if (flag)
			{
				interaction = null;
			}
			else
			{
				interaction = new SelectCardInteraction(0, base.Value1, readOnlyList, SelectedCardHandling.DoNothing);
			}
			return interaction;
		}

		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			SelectCardInteraction selectCardInteraction = (SelectCardInteraction)precondition;
			IReadOnlyList<Card> readOnlyList = ((selectCardInteraction != null) ? selectCardInteraction.SelectedCards : null);
			bool flag = readOnlyList != null && readOnlyList.Count > 0;
			if (flag)
			{
				foreach (Card card in readOnlyList)
				{
					yield return new MoveCardAction(card, CardZone.Hand);
					bool flag2 = !card.IsUpgraded;
					if (flag2)
					{
						yield return new UpgradeCardAction(card);
					}
					card = null;
				}
				IEnumerator<Card> enumerator = null;
			}
			yield break;
			yield break;
		}
	}
}
