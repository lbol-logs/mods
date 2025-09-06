using System;
using System.Collections.Generic;
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
	[EntityLogic(typeof(sebewaterDef))]
	public sealed class sebewater : StatusEffect
	{
		protected override void OnAdded(Unit unit)
		{
			base.ReactOwnerEvent<CardUsingEventArgs>(base.Battle.CardUsed, new EventSequencedReactor<CardUsingEventArgs>(this.OnCardUsed));
		}

		private IEnumerable<BattleAction> OnCardUsed(CardUsingEventArgs args)
		{
			bool flag = base.Battle.BattleShouldEnd || (!(args.Card is cardredblood) && !(args.Card is carddarkblood));
			if (flag)
			{
				yield break;
			}
			base.NotifyActivating();
			bool flag2 = base.Battle.DiscardZone.Count > 0;
			if (flag2)
			{
				SelectCardInteraction interaction = new SelectCardInteraction(0, base.Level, base.Battle.DiscardZone, SelectedCardHandling.DoNothing)
				{
					Source = this
				};
				yield return new InteractionAction(interaction, false);
				IReadOnlyList<Card> cards = interaction.SelectedCards;
				bool flag3 = cards.Count > 0;
				if (flag3)
				{
					foreach (Card card in cards)
					{
						yield return new MoveCardToDrawZoneAction(card, DrawZoneTarget.Random);
						card = null;
					}
					IEnumerator<Card> enumerator = null;
				}
				interaction = null;
				cards = null;
			}
			yield return new DrawManyCardAction(base.Level);
			yield break;
			yield break;
		}
	}
}
