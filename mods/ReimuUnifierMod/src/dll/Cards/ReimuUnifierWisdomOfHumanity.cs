using System;
using System.Collections.Generic;
using System.Linq;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Cards;
using LBoLEntitySideloader.Attributes;
using ReimuUnifierMod.BattleActions;
using ReimuUnifierMod.Cards.Template;

namespace ReimuUnifierMod.Cards
{
	[EntityLogic(typeof(ReimuUnifierWisdomOfHumanityDef))]
	public sealed class ReimuUnifierWisdomOfHumanity : ReimuUnifierCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			List<Type> PossibleTeamUps = new List<Type>
			{
				typeof(ReimuUnifierMarisaIncidentSolverFriend),
				typeof(ReimuUnifierMarisaKirisameFriend),
				typeof(ReimuUnifierSanaeHumanGodFriend),
				typeof(ReimuUnifierKosuzuDecipheringBibliophileFriend),
				typeof(ReimuUnifierSumirekoDreamVisitorFriend)
			};
			int TeamUpAmount = base.MultiTeamUpCheck(PossibleTeamUps);
			bool flag = TeamUpAmount != 0;
			if (flag)
			{
				yield return new DrawManyCardAction(TeamUpAmount);
				List<Card> CardsInHand = base.Battle.HandZone.ToList<Card>();
				foreach (Card card in CardsInHand)
				{
					bool flag2 = PossibleTeamUps.Contains(card.GetType()) && card.Summoned;
					if (flag2)
					{
						yield return new TeamUpAction(this, card);
					}
					card = null;
				}
				List<Card>.Enumerator enumerator = default(List<Card>.Enumerator);
				CardsInHand = null;
			}
			yield return new CastBlockShieldAction(base.Battle.Player, this.Block.Block * base.Battle.HandZone.Count, base.Shield.Shield * base.Battle.HandZone.Count, BlockShieldType.Direct, true);
			yield break;
			yield break;
		}
	}
}
