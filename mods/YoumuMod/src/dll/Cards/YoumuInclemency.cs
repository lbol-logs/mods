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
using YoumuCharacterMod.Cards.Template;

namespace YoumuCharacterMod.Cards
{
	[EntityLogic(typeof(YoumuInclemencyDef))]
	public sealed class YoumuInclemency : YoumuCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			bool isUpgraded = this.IsUpgraded;
			if (isUpgraded)
			{
				yield return new DrawManyCardAction(base.Value1);
			}
			List<Card> cardsInHand = base.Battle.HandZone.Where((Card hand) => hand != this).ToList<Card>();
			foreach (Card card in cardsInHand)
			{
				card.SetTurnCost(base.Mana);
				card = null;
			}
			List<Card>.Enumerator enumerator = default(List<Card>.Enumerator);
			yield return base.BuffAction<CantDrawThisTurn>(0, 0, 0, 0, 0.2f);
			yield break;
		}
	}
}
