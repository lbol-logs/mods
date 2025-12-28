using System;
using System.Collections.Generic;
using System.Linq;
using LBoL.Base;
using LBoL.Base.Extensions;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.Interactions;
using LBoL.Core.Cards;
using LBoLEntitySideloader.Attributes;
using ReimuUnifierMod.Cards.Template;

namespace ReimuUnifierMod.Cards
{
	[EntityLogic(typeof(ReimuUnifierCallForHelpDef))]
	public sealed class ReimuUnifierCallForHelp : ReimuUnifierCard
	{
		public override Interaction Precondition()
		{
			List<Card> list = base.Battle.DrawZone.Where((Card card) => card != this && card.CardType == CardType.Friend).ToList<Card>();
			bool flag = !list.Empty<Card>();
			Interaction interaction;
			if (flag)
			{
				interaction = new SelectCardInteraction(0, base.Value1, list, SelectedCardHandling.DoNothing);
			}
			else
			{
				interaction = null;
			}
			return interaction;
		}

		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			ReimuUnifierCallForHelp.<Actions>d__1 <Actions>d__ = new ReimuUnifierCallForHelp.<Actions>d__1(-2);
			<Actions>d__.<>4__this = this;
			<Actions>d__.<>3__selector = selector;
			<Actions>d__.<>3__consumingMana = consumingMana;
			<Actions>d__.<>3__precondition = precondition;
			return <Actions>d__;
		}
	}
}
