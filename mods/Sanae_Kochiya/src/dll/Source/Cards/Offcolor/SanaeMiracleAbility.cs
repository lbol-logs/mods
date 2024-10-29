using System;
using System.Collections.Generic;
using System.Linq;
using LBoL.Base;
using LBoL.ConfigData;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Battle.Interactions;
using LBoL.Core.Cards;
using LBoL.Core.Randoms;
using LBoLEntitySideloader.Attributes;
using Sanae_Kochiya.Cards.Template;

namespace Sanae_Kochiya.Source.Cards.Offcolor
{
	[EntityLogic(typeof(SanaeMiracleAbilityDef))]
	public sealed class SanaeMiracleAbility : SampleCharacterCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			List<Card> list = base.Battle.RollCardsWithoutManaLimit(new CardWeightTable(RarityWeightTable.OnlyUncommon, OwnerWeightTable.Valid, CardTypeWeightTable.CanBeLoot, false), base.Value1, (CardConfig config) => config.Type == CardType.Ability).ToList<Card>();
			bool flag = base.Value2 > 0;
			if (flag)
			{
				list.AddRange(base.Battle.RollCardsWithoutManaLimit(new CardWeightTable(RarityWeightTable.OnlyRare, OwnerWeightTable.Valid, CardTypeWeightTable.CanBeLoot, false), base.Value1, (CardConfig config) => config.Type == CardType.Ability));
			}
			bool flag2 = list.Count > 0;
			if (flag2)
			{
				SelectCardInteraction interaction = new SelectCardInteraction(1, 1, list, SelectedCardHandling.DoNothing)
				{
					Source = this
				};
				yield return new InteractionAction(interaction, false);
				Card selectedCard = interaction.SelectedCards.FirstOrDefault<Card>();
				selectedCard.SetTurnCost(default(ManaGroup));
				selectedCard.IsEcho = true;
				selectedCard.IsEthereal = true;
				yield return new AddCardsToHandAction(new Card[] { selectedCard });
				interaction = null;
				selectedCard = null;
			}
			yield break;
		}
	}
}
