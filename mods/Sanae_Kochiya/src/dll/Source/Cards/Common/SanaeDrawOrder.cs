using System;
using System.Collections.Generic;
using System.Linq;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Battle.Interactions;
using LBoL.Core.Cards;
using LBoLEntitySideloader.Attributes;
using Sanae_Kochiya.Cards.Template;

namespace Sanae_Kochiya.Source.Cards.Common
{
	[EntityLogic(typeof(SanaeDrawOrderDef))]
	public sealed class SanaeDrawOrder : SampleCharacterCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			List<Card> full = base.Battle.DrawZone.ToList<Card>();
			List<Card> list = new List<Card>();
			int i = 1;
			while (i <= base.Value1 && full.FirstOrDefault<Card>() != null)
			{
				list.Add(full.FirstOrDefault<Card>());
				full.RemoveAt(0);
				int num = i;
				i = num + 1;
			}
			bool flag = list.Count > 0;
			if (flag)
			{
				SelectCardInteraction interaction = new SelectCardInteraction(1, 1, list, SelectedCardHandling.DoNothing)
				{
					Source = this
				};
				yield return new InteractionAction(interaction, false);
				Card selectedCard = interaction.SelectedCards.FirstOrDefault<Card>();
				yield return new MoveCardToDrawZoneAction(selectedCard, DrawZoneTarget.Top);
				bool flag2 = selectedCard.CardType == CardType.Skill;
				if (flag2)
				{
					yield return new DrawManyCardAction(base.Value2);
				}
				interaction = null;
				selectedCard = null;
			}
			yield return new GainManaAction(base.Mana);
			bool isUpgraded = this.IsUpgraded;
			if (isUpgraded)
			{
				yield return new DrawManyCardAction(base.Value2);
			}
			yield break;
		}
	}
}
