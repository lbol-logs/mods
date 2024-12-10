using System;
using System.Collections.Generic;
using System.Linq;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Cards;
using LBoL.Core.StatusEffects;
using LBoLEntitySideloader.Attributes;

namespace Momiji.Source.Cards
{
	[EntityLogic(typeof(PatrolDef))]
	public sealed class Patrol : SampleCharacterCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			DrawManyCardAction drawAction = new DrawManyCardAction(base.Value1);
			yield return drawAction;
			IReadOnlyList<Card> drawnCards = drawAction.DrawnCards;
			int num = drawnCards.Count((Card card) => card.Config.Colors.Contains(ManaColor.Red));
			bool isUpgraded = this.IsUpgraded;
			if (isUpgraded)
			{
				num += drawnCards.Count((Card card) => card.CardType == CardType.Status || card.CardType == CardType.Misfortune);
			}
			bool flag = num > 0;
			if (flag)
			{
				yield return base.BuffAction<Graze>(base.Value2 * num, 0, 0, 0, 0.2f);
			}
			yield break;
		}
	}
}
