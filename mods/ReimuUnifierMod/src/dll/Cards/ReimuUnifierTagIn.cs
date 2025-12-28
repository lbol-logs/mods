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
	[EntityLogic(typeof(ReimuUnifierTagInDef))]
	public sealed class ReimuUnifierTagIn : ReimuUnifierCard
	{
		public override Interaction Precondition()
		{
			bool isUpgraded = this.IsUpgraded;
			if (isUpgraded)
			{
				List<Card> list = (from card in base.Battle.HandZone.Concat(base.Battle.DrawZoneToShow).Concat(base.Battle.DiscardZone)
					where card != this
					select card).ToList<Card>();
				bool flag = !list.Empty<Card>();
				if (flag)
				{
					return new SelectCardInteraction(0, 1, list, SelectedCardHandling.DoNothing);
				}
			}
			else
			{
				List<Card> list = base.Battle.HandZone.Where((Card card) => card != this).ToList<Card>();
				bool flag2 = !list.Empty<Card>();
				if (flag2)
				{
					return new SelectHandInteraction(0, 1, list);
				}
			}
			return null;
		}

		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			ReimuUnifierTagIn.<Actions>d__1 <Actions>d__ = new ReimuUnifierTagIn.<Actions>d__1(-2);
			<Actions>d__.<>4__this = this;
			<Actions>d__.<>3__selector = selector;
			<Actions>d__.<>3__consumingMana = consumingMana;
			<Actions>d__.<>3__precondition = precondition;
			return <Actions>d__;
		}
	}
}
