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
using YoumuCharacterMod.Cards.Template;

namespace YoumuCharacterMod.Cards
{
	[EntityLogic(typeof(YoumuAppearingAndDisappearingDef))]
	public sealed class YoumuAppearingAndDisappearing : YoumuCard
	{
		public override Interaction Precondition()
		{
			List<Card> list = (from card in base.Battle.HandZone.Concat(base.Battle.DrawZoneToShow).Concat(base.Battle.DiscardZone)
				where card != this
				select card).ToList<Card>();
			return new SelectCardInteraction(0, base.Value1, list, SelectedCardHandling.DoNothing);
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
					yield return new ExileCardAction(card);
					YoumuCard yCard = card as YoumuCard;
					bool flag2 = yCard != null && yCard.IsEthereal;
					if (flag2)
					{
						yield return new MoveCardAction(card, CardZone.Discard);
					}
					yCard = null;
					card = null;
				}
				IEnumerator<Card> enumerator = null;
			}
			yield break;
			yield break;
		}
	}
}
