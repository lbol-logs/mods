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

namespace Sanae_Kochiya.Source.Cards.Rare
{
	[EntityLogic(typeof(SanaeColorRandomDef))]
	public sealed class SanaeColorRandom : SampleCharacterCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			List<Card> list = new List<Card>();
			list.AddRange(base.Battle.RollCardsWithoutManaLimit(new CardWeightTable(RarityWeightTable.AllOnes, OwnerWeightTable.Valid, CardTypeWeightTable.CanBeLoot, false), 1, (CardConfig config) => config.Colors.Contains(ManaColor.White) && !config.Colors.Contains(ManaColor.Blue) && !config.Colors.Contains(ManaColor.Black) && !config.Colors.Contains(ManaColor.Red) && !config.Colors.Contains(ManaColor.Green)));
			list.AddRange(base.Battle.RollCardsWithoutManaLimit(new CardWeightTable(RarityWeightTable.AllOnes, OwnerWeightTable.Valid, CardTypeWeightTable.CanBeLoot, false), 1, (CardConfig config) => !config.Colors.Contains(ManaColor.White) && config.Colors.Contains(ManaColor.Blue) && !config.Colors.Contains(ManaColor.Black) && !config.Colors.Contains(ManaColor.Red) && !config.Colors.Contains(ManaColor.Green)));
			bool isUpgraded = this.IsUpgraded;
			if (isUpgraded)
			{
				list.AddRange(base.Battle.RollCardsWithoutManaLimit(new CardWeightTable(RarityWeightTable.AllOnes, OwnerWeightTable.Valid, CardTypeWeightTable.CanBeLoot, false), 1, (CardConfig config) => !config.Colors.Contains(ManaColor.White) && !config.Colors.Contains(ManaColor.Blue) && config.Colors.Contains(ManaColor.Black) && !config.Colors.Contains(ManaColor.Red) && !config.Colors.Contains(ManaColor.Green)));
				list.AddRange(base.Battle.RollCardsWithoutManaLimit(new CardWeightTable(RarityWeightTable.AllOnes, OwnerWeightTable.Valid, CardTypeWeightTable.CanBeLoot, false), 1, (CardConfig config) => !config.Colors.Contains(ManaColor.White) && !config.Colors.Contains(ManaColor.Blue) && !config.Colors.Contains(ManaColor.Black) && config.Colors.Contains(ManaColor.Red) && !config.Colors.Contains(ManaColor.Green)));
			}
			list.AddRange(base.Battle.RollCardsWithoutManaLimit(new CardWeightTable(RarityWeightTable.AllOnes, OwnerWeightTable.Valid, CardTypeWeightTable.CanBeLoot, false), 1, (CardConfig config) => !config.Colors.Contains(ManaColor.White) && !config.Colors.Contains(ManaColor.Blue) && !config.Colors.Contains(ManaColor.Black) && !config.Colors.Contains(ManaColor.Red) && config.Colors.Contains(ManaColor.Green)));
			bool flag = list.Count > 0;
			if (flag)
			{
				SelectCardInteraction interaction = new SelectCardInteraction(1, 1, list, SelectedCardHandling.DoNothing)
				{
					Source = this
				};
				yield return new InteractionAction(interaction, false);
				Card selectedCard = interaction.SelectedCards.FirstOrDefault<Card>();
				selectedCard.SetTurnCost(default(ManaGroup));
				selectedCard.IsExile = true;
				selectedCard.IsEthereal = true;
				yield return new AddCardsToHandAction(new Card[] { selectedCard });
				interaction = null;
				selectedCard = null;
			}
			yield break;
		}
	}
}
