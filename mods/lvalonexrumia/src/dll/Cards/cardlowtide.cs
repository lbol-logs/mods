using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Battle.Interactions;
using LBoL.Core.Cards;
using LBoL.Presentation;
using LBoLEntitySideloader.Attributes;
using lvalonexrumia.Cards.Template;
using lvalonexrumia.Patches;

namespace lvalonexrumia.Cards
{
	[EntityLogic(typeof(cardlowtideDef))]
	public sealed class cardlowtide : lvalonexrumiaCard
	{
		protected override int heal
		{
			get
			{
				return toolbox.hpfrompercent(Singleton<GameMaster>.Instance.CurrentGameRun.Player, base.Value1, false);
			}
		}

		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			yield return new ChangeLifeAction(-this.heal, null);
			bool flag = base.Battle.DrawZone.Count > 0;
			if (flag)
			{
				SelectCardInteraction interaction = new SelectCardInteraction(0, base.Value2, base.Battle.DrawZoneToShow, SelectedCardHandling.DoNothing)
				{
					Source = this
				};
				yield return new InteractionAction(interaction, false);
				IReadOnlyList<Card> cards = interaction.SelectedCards;
				bool flag2 = cards.Count > 0;
				if (flag2)
				{
					foreach (Card card in cards)
					{
						yield return new MoveCardAction(card, CardZone.Hand);
						card = null;
					}
					IEnumerator<Card> enumerator = null;
				}
				interaction = null;
				cards = null;
			}
			bool flag3 = base.Battle.DiscardZone.Count > 0;
			if (flag3)
			{
				SelectCardInteraction interaction2 = new SelectCardInteraction(0, base.Value2, base.Battle.DiscardZone, SelectedCardHandling.DoNothing)
				{
					Source = this
				};
				yield return new InteractionAction(interaction2, false);
				IReadOnlyList<Card> cards2 = interaction2.SelectedCards;
				bool flag4 = cards2.Count > 0;
				if (flag4)
				{
					foreach (Card card2 in cards2)
					{
						yield return new MoveCardAction(card2, CardZone.Hand);
						card2 = null;
					}
					IEnumerator<Card> enumerator2 = null;
				}
				interaction2 = null;
				cards2 = null;
			}
			bool flag5 = base.Battle.ExileZone.Count > 0;
			if (flag5)
			{
				SelectCardInteraction interaction3 = new SelectCardInteraction(0, base.Value2, base.Battle.ExileZone, SelectedCardHandling.DoNothing)
				{
					Source = this
				};
				yield return new InteractionAction(interaction3, false);
				IReadOnlyList<Card> cards3 = interaction3.SelectedCards;
				bool flag6 = cards3.Count > 0;
				if (flag6)
				{
					foreach (Card card3 in cards3)
					{
						yield return new MoveCardAction(card3, CardZone.Hand);
						card3 = null;
					}
					IEnumerator<Card> enumerator3 = null;
				}
				interaction3 = null;
				cards3 = null;
			}
			yield break;
			yield break;
		}
	}
}
