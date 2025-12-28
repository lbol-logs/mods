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
	[EntityLogic(typeof(ReimuUnifierRitualPowerConduitDef))]
	public sealed class ReimuUnifierRitualPowerConduit : ReimuUnifierCard
	{
		public override Interaction Precondition()
		{
			List<Card> list = base.Battle.HandZone.Where((Card card) => card != this && card.CardType == CardType.Friend && card.Summoned).ToList<Card>();
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

		protected override int AdditionalValue1
		{
			get
			{
				return base.SummonedTeammatesInHand;
			}
		}

		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			int EffectTimes = base.Value1;
			SelectHandInteraction selectHandInteraction = (SelectHandInteraction)precondition;
			Card ChosenTeammate = ((selectHandInteraction != null) ? selectHandInteraction.SelectedCards.First<Card>() : null);
			bool flag = ChosenTeammate != null && ChosenTeammate.GetPassiveActions() != null && ChosenTeammate.GetPassiveActions().Count<BattleAction>() > 0;
			if (flag)
			{
				int num;
				for (int i = 0; i < EffectTimes; i = num + 1)
				{
					foreach (BattleAction action in ChosenTeammate.GetPassiveActions())
					{
						yield return action;
						action = null;
					}
					IEnumerator<BattleAction> enumerator = null;
					num = i;
				}
			}
			yield break;
			yield break;
		}
	}
}
