using System;
using System.Collections.Generic;
using System.Linq;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Cards;
using LBoLEntitySideloader.Attributes;
using ReimuUnifierMod.Cards.Template;

namespace ReimuUnifierMod.Cards
{
	[EntityLogic(typeof(ReimuUnifierSummoningRitualDef))]
	public sealed class ReimuUnifierSummoningRitual : ReimuUnifierCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			DrawManyCardAction drawAction = new DrawManyCardAction(base.Value1);
			yield return drawAction;
			IReadOnlyList<Card> drawnCards = drawAction.DrawnCards;
			int DrawnTeammates = drawnCards.Count((Card card) => card.CardType == CardType.Friend);
			bool flag = DrawnTeammates > 0;
			if (flag)
			{
				yield return new GainManaAction(new ManaGroup
				{
					Red = DrawnTeammates
				});
			}
			yield break;
		}
	}
}
