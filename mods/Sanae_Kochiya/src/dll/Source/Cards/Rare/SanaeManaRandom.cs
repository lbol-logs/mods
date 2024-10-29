using System;
using System.Collections.Generic;
using System.Linq;
using LBoL.Base;
using LBoL.ConfigData;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Cards;
using LBoL.Core.Randoms;
using LBoLEntitySideloader.Attributes;
using Sanae_Kochiya.Cards.Template;

namespace Sanae_Kochiya.Source.Cards.Rare
{
	[EntityLogic(typeof(SanaeManaRandomDef))]
	public sealed class SanaeManaRandom : SampleCharacterCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			List<Card> list = base.Battle.RollCards(new CardWeightTable(RarityWeightTable.BattleCard, OwnerWeightTable.Valid, CardTypeWeightTable.CanBeLoot, false), base.Value1, (CardConfig config) => config.Cost.Amount <= 4 && config.Id != base.Id && !config.IsXCost).ToList<Card>();
			bool flag = list.Count > 0;
			if (flag)
			{
				foreach (Card card in list)
				{
					bool isUpgraded = this.IsUpgraded;
					if (isUpgraded)
					{
						card.Upgrade();
					}
					card.IsEthereal = true;
					card.SetBaseCost(base.Mana);
					yield return new AddCardsToHandAction(new Card[] { card });
					card = null;
				}
				List<Card>.Enumerator enumerator = default(List<Card>.Enumerator);
			}
			yield break;
			yield break;
		}
	}
}
