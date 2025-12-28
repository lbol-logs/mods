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
	[EntityLogic(typeof(ReimuUnifierBattleForgedBondsDef))]
	public sealed class ReimuUnifierBattleForgedBonds : ReimuUnifierCard
	{
		public override Interaction Precondition()
		{
			List<Card> list = (from card in base.Battle.HandZone.Concat(base.Battle.DrawZoneToShow).Concat(base.Battle.DiscardZone)
				where card != this && card.CanUpgrade
				select card).ToList<Card>();
			bool flag = list.Count <= 0;
			Interaction interaction;
			if (flag)
			{
				interaction = null;
			}
			else
			{
				interaction = new SelectCardInteraction(0, base.Value1, list, SelectedCardHandling.DoNothing);
			}
			return interaction;
		}

		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			SelectCardInteraction SelectCardInteraction = (SelectCardInteraction)precondition;
			IReadOnlyList<Card> readOnlyList = ((SelectCardInteraction != null) ? SelectCardInteraction.SelectedCards : null);
			bool flag = readOnlyList != null;
			if (flag)
			{
				Card card = readOnlyList.First<Card>();
				card.NotifyActivating();
				bool canUpgrade = card.CanUpgrade;
				if (canUpgrade)
				{
					yield return new UpgradeCardAction(card);
				}
				bool flag2 = card.CardType == CardType.Friend;
				if (flag2)
				{
					yield return new DrawCardAction();
				}
				card = null;
			}
			yield break;
		}
	}
}
