using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Battle.Interactions;
using LBoL.Core.Cards;
using LBoLEntitySideloader.Attributes;

namespace Momiji.Source.Cards
{
	[EntityLogic(typeof(HuntersTrapDef))]
	public sealed class HuntersTrap : SampleCharacterCard
	{
		public override Interaction Precondition()
		{
			List<Card> list = new List<Card>
			{
				Library.CreateCard<AirCutter>(),
				Library.CreateCard<MapleLeaf>()
			};
			return new SelectCardInteraction(1, 1, list, SelectedCardHandling.DoNothing);
		}

		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			bool flag = precondition == null;
			if (flag)
			{
				yield break;
			}
			SelectCardInteraction selectCardInteraction = (SelectCardInteraction)precondition;
			List<Card> cards = new List<Card> { selectCardInteraction.SelectedCards[0] };
			yield return new AddCardsToHandAction(cards, AddCardsType.Normal);
			yield return base.DefenseAction(true);
			yield break;
		}
	}
}
