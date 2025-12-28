using System;
using System.Collections.Generic;
using System.Linq;
using LBoL.Base;
using LBoL.Base.Extensions;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.Interactions;
using LBoL.Core.Cards;
using LBoL.Core.StatusEffects;
using LBoLEntitySideloader.Attributes;
using ReimuUnifierMod.BattleActions;
using ReimuUnifierMod.Cards.Template;

namespace ReimuUnifierMod.Cards
{
	[EntityLogic(typeof(ReimuUnifierDoubleDealingDef))]
	public sealed class ReimuUnifierDoubleDealing : ReimuUnifierCard
	{
		public override Interaction Precondition()
		{
			List<Card> list = base.Battle.HandZone.Where((Card card) => card != this && card.CardType == CardType.Friend && !card.Summoned).ToList<Card>();
			bool flag = !list.Empty<Card>();
			Interaction interaction;
			if (flag)
			{
				interaction = new SelectHandInteraction(1, 1, list);
			}
			else
			{
				interaction = null;
			}
			return interaction;
		}

		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			bool flag = base.TeamUpCheck<ReimuUnifierShinmyoumaruInchlingPrincessFriend>();
			if (flag)
			{
				foreach (Card card2 in base.Battle.HandZone.Where((Card card) => card.CardType == CardType.Friend))
				{
					card2.NotifyActivating();
					Card card4 = card2;
					int loyalty = card4.Loyalty;
					card4.Loyalty = loyalty + 1;
					card2 = null;
				}
				IEnumerator<Card> enumerator = null;
				yield return new TeamUpAction(this, base.TeamUpCard(typeof(ReimuUnifierShinmyoumaruInchlingPrincessFriend)));
			}
			bool isUpgraded = this.IsUpgraded;
			if (isUpgraded)
			{
				Random r = new Random();
				int rInt = r.Next(0, 1);
				bool flag2 = rInt == 0;
				if (flag2)
				{
					yield return base.DebuffAction<Weak>(base.Battle.Player, 0, 1, 0, 0, true, 0.2f);
				}
				else
				{
					yield return base.DebuffAction<Vulnerable>(base.Battle.Player, 0, 1, 0, 0, true, 0.2f);
				}
				r = null;
			}
			else
			{
				yield return base.DebuffAction<Weak>(base.Battle.Player, 0, 1, 0, 0, true, 0.2f);
				yield return base.DebuffAction<Vulnerable>(base.Battle.Player, 0, 1, 0, 0, true, 0.2f);
			}
			SelectHandInteraction selectHandInteraction = (SelectHandInteraction)precondition;
			IReadOnlyList<Card> readOnlyList = ((selectHandInteraction != null) ? selectHandInteraction.SelectedCards : null);
			bool flag3 = readOnlyList != null;
			if (flag3)
			{
				using (IEnumerator<Card> enumerator2 = readOnlyList.GetEnumerator())
				{
					while (enumerator2.MoveNext())
					{
						Card card3 = enumerator2.Current;
						card3.NotifyActivating();
						card3.Summon();
						card3 = null;
					}
					yield break;
				}
			}
			yield break;
		}
	}
}
