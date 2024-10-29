using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Base.Extensions;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Cards;
using LBoLEntitySideloader.Attributes;
using Sanae_Kochiya.Cards.Template;

namespace Sanae_Kochiya.Source.Cards.Uncommon
{
	[EntityLogic(typeof(SanaeDrawAbilityDef))]
	public sealed class SanaeDrawAbility : SampleCharacterCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			DrawManyCardAction drawAction = new DrawManyCardAction(base.Value1);
			yield return drawAction;
			IReadOnlyList<Card> drawnCards = drawAction.DrawnCards;
			bool flag = drawnCards != null && drawnCards.Count > 0;
			if (flag)
			{
				foreach (Card card in drawnCards)
				{
					bool flag2 = card.CardType == CardType.Ability;
					if (flag2)
					{
						card.NotifyActivating();
						bool isUpgraded = this.IsUpgraded;
						if (isUpgraded)
						{
							bool flag3 = card.Cost.Amount > 0;
							if (flag3)
							{
								ManaColor[] array = card.Cost.EnumerateComponents().SampleManyOrAll(1, base.GameRun.BattleRng);
								card.DecreaseTurnCost(ManaGroup.FromComponents(array));
								array = null;
							}
						}
						else
						{
							card.DecreaseTurnCost(base.Mana);
						}
					}
					card = null;
				}
				IEnumerator<Card> enumerator = null;
			}
			yield break;
		}
	}
}
