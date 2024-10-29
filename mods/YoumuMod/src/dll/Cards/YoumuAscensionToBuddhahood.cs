using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Base.Extensions;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.Interactions;
using LBoL.Core.Cards;
using LBoLEntitySideloader.Attributes;
using YoumuCharacterMod.Cards.Template;
using YoumuCharacterMod.StatusEffects;

namespace YoumuCharacterMod.Cards
{
	[EntityLogic(typeof(YoumuAscensionToBuddhahoodDef))]
	public sealed class YoumuAscensionToBuddhahood : YoumuCard
	{
		public override ManaGroup? PlentifulMana
		{
			get
			{
				return new ManaGroup?(base.Mana);
			}
		}

		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			bool flag = !base.Battle.BattleShouldEnd;
			if (flag)
			{
				yield return base.BuffAction<YoumuAscensionToBuddhahoodSe>(base.Value1, 0, 0, 0, 0.2f);
			}
			bool flag2 = precondition != null;
			if (flag2)
			{
				IReadOnlyList<Card> selectedCards = ((SelectHandInteraction)precondition).SelectedCards;
				bool flag3 = selectedCards.NotEmpty<Card>();
				if (flag3)
				{
					foreach (Card card in selectedCards)
					{
						card.IsEcho = true;
						card = null;
					}
					IEnumerator<Card> enumerator = null;
				}
				selectedCards = null;
			}
			yield break;
		}
	}
}
