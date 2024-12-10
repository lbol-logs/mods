using System;
using System.Collections.Generic;
using System.Linq;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Cards;
using LBoL.EntityLib.StatusEffects.Basic;
using LBoLEntitySideloader.Attributes;

namespace Momiji.Source.Cards
{
	[EntityLogic(typeof(GentlyCirclingLeavesDef))]
	public sealed class GentlyCirclingLeaves : SampleCharacterCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			DrawManyCardAction drawAction = new DrawManyCardAction(base.Value1);
			yield return drawAction;
			IReadOnlyList<Card> drawnCards = drawAction.DrawnCards;
			int num = drawnCards.Count((Card card) => card.CardType == CardType.Attack);
			int defense = drawnCards.Count((Card card) => card.CardType == CardType.Defense);
			bool flag = num > 0;
			if (flag)
			{
				yield return base.BuffAction<Reflect>(base.Value2 * num, 0, 0, 0, 0.2f);
			}
			bool flag2 = defense > 0;
			if (flag2)
			{
				yield return base.DefenseAction(base.Block.Block * defense, 0, BlockShieldType.Direct, false);
			}
			yield break;
		}
	}
}
