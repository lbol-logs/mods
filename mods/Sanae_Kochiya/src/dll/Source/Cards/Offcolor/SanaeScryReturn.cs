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

namespace Sanae_Kochiya.Source.Cards.Offcolor
{
	[EntityLogic(typeof(SanaeScryReturnDef))]
	public sealed class SanaeScryReturn : SampleCharacterCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			yield return new ScryAction(base.Scry);
			bool flag = base.Battle != null && base.Battle.DrawZone.Count == 0 && base.Battle.DiscardZone.Count != 0;
			if (flag)
			{
				IReadOnlyList<Card> discardZone = base.Battle.DiscardZone;
				SelectCardInteraction interaction = new SelectCardInteraction(1, 1, discardZone, SelectedCardHandling.DoNothing)
				{
					Source = this
				};
				yield return new InteractionAction(interaction, false);
				Card card = interaction.SelectedCards.FirstOrDefault<Card>();
				bool flag2 = card != null;
				if (flag2)
				{
					yield return new MoveCardAction(card, CardZone.Hand);
				}
				yield break;
			}
			yield break;
		}
	}
}
