using System;
using System.Collections.Generic;
using System.Linq;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Battle.Interactions;
using LBoL.Core.Cards;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoLEntitySideloader.Attributes;
using lvalonexrumia.Cards;

namespace lvalonexrumia.StatusEffects
{
	[EntityLogic(typeof(sebloodcircleDef))]
	public sealed class sebloodcircle : StatusEffect
	{
		public override bool ForceNotShowDownText
		{
			get
			{
				return true;
			}
		}

		protected override void OnAdded(Unit unit)
		{
			base.ReactOwnerEvent<UnitEventArgs>(base.Owner.TurnStarted, new EventSequencedReactor<UnitEventArgs>(this.OnOwnerTurnStarted));
		}

		private IEnumerable<BattleAction> OnOwnerTurnStarted(UnitEventArgs args)
		{
			List<Card> list = base.Battle.ExileZone.Where((Card card) => card is carddarkblood || card is cardredblood).ToList<Card>();
			bool flag = base.Battle.BattleShouldEnd || list.Count == 0;
			if (flag)
			{
				yield break;
			}
			base.NotifyActivating();
			SelectCardInteraction interaction = new SelectCardInteraction(0, list.Count, list, SelectedCardHandling.DoNothing)
			{
				Source = this
			};
			yield return new InteractionAction(interaction, false);
			IReadOnlyList<Card> cards = interaction.SelectedCards;
			bool flag2 = cards.Count > 0;
			if (flag2)
			{
				foreach (Card card2 in cards)
				{
					bool flag3 = !base.Battle.HandIsFull;
					if (flag3)
					{
						yield return new MoveCardAction(card2, CardZone.Hand);
					}
					card2 = null;
				}
				IEnumerator<Card> enumerator = null;
			}
			yield break;
			yield break;
		}
	}
}
