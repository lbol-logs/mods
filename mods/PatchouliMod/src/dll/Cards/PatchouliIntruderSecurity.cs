using System;
using System.Collections.Generic;
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
	[EntityLogic(typeof(PatchouliIntruderSecurityDef))]
	public sealed class PatchouliIntruderSecurity : PatchouliCard
	{
		public override Interaction Precondition()
		{
			IReadOnlyList<Card> discardZone = base.Battle.DiscardZone;
			bool flag = discardZone.Count <= 0;
			Interaction interaction;
			if (flag)
			{
				interaction = null;
			}
			else
			{
				interaction = new SelectCardInteraction(0, base.Value1, base.Battle.DiscardZone, SelectedCardHandling.DoNothing);
			}
			return interaction;
		}

		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			yield return base.DefenseAction(true);
			SelectCardInteraction selectCardInteraction = (SelectCardInteraction)precondition;
			SelectCardInteraction selectCardInteraction2 = selectCardInteraction;
			IReadOnlyList<Card> readOnlyList = ((selectCardInteraction2 != null) ? selectCardInteraction2.SelectedCards : null);
			bool flag = readOnlyList != null && readOnlyList.Count > 0;
			if (flag)
			{
				foreach (Card card in readOnlyList)
				{
					yield return new MoveCardAction(card, CardZone.Hand);
					card = null;
				}
				IEnumerator<Card> enumerator = null;
			}
			yield break;
			yield break;
		}
	}
}
