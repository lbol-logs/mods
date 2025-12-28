using System;
using System.Collections.Generic;
using System.Linq;
using LBoL.Base;
using LBoL.Base.Extensions;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Cards;
using LBoLEntitySideloader.Attributes;
using ReimuUnifierMod.Cards.Template;

namespace ReimuUnifierMod.Cards
{
	[EntityLogic(typeof(ReimuUnifierSupplyRunDef))]
	public sealed class ReimuUnifierSupplyRun : ReimuUnifierCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			List<Card> TeammatesToDraw = (from card in base.Battle.DrawZone.Concat(base.Battle.DiscardZone)
				where card != this && card.CardType == CardType.Friend
				select card).ToList<Card>();
			TeammatesToDraw.Shuffle(new RandomGen());
			bool flag = !TeammatesToDraw.Empty<Card>();
			if (flag)
			{
				yield return new MoveCardAction(TeammatesToDraw.First<Card>(), CardZone.Hand);
			}
			yield return new DrawManyCardAction(base.Value1);
			yield break;
		}
	}
}
