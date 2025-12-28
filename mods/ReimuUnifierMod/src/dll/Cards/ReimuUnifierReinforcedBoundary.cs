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
using ReimuUnifierMod.Cards.Template;

namespace ReimuUnifierMod.Cards
{
	[EntityLogic(typeof(ReimuUnifierReinforcedBoundaryDef))]
	public sealed class ReimuUnifierReinforcedBoundary : ReimuUnifierCard
	{
		public override Interaction Precondition()
		{
			List<Card> list = base.Battle.HandZone.Where((Card card) => card != this && card.CardType == CardType.Friend && card.Summoned && card.GetPassiveActions() != null).ToList<Card>();
			bool flag = list.Count <= 0;
			Interaction interaction;
			if (flag)
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
			SelectHandInteraction selectHandInteraction = (SelectHandInteraction)precondition;
			IReadOnlyList<Card> readOnlyList = ((selectHandInteraction != null) ? selectHandInteraction.SelectedCards : null);
			yield return new CastBlockShieldAction(base.Battle.Player, base.Battle.Player, this.Block.Block, 0, BlockShieldType.Normal, true);
			bool flag = readOnlyList != null;
			if (flag)
			{
				foreach (Card card2 in readOnlyList)
				{
					IEnumerable<BattleAction> passiveActions = card2.GetPassiveActions();
					bool flag2 = passiveActions != null;
					if (flag2)
					{
						foreach (BattleAction battleAction in passiveActions)
						{
							yield return battleAction;
							battleAction = null;
						}
						IEnumerator<BattleAction> enumerator3 = null;
					}
					passiveActions = null;
					card2 = null;
				}
				IEnumerator<Card> enumerator2 = null;
				List<Card>.Enumerator enumerator = default(List<Card>.Enumerator);
				yield break;
			}
			yield break;
			yield break;
		}
	}
}
