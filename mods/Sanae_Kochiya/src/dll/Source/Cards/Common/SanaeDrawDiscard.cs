using System;
using System.Collections.Generic;
using System.Linq;
using LBoL.Base;
using LBoL.Base.Extensions;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Battle.Interactions;
using LBoL.Core.Cards;
using LBoLEntitySideloader.Attributes;
using Sanae_Kochiya.Cards.Template;

namespace Sanae_Kochiya.Source.Cards.Common
{
	[EntityLogic(typeof(SanaeDrawDiscardDef))]
	public sealed class SanaeDrawDiscard : SampleCharacterCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			yield return new DrawManyCardAction(base.Value1);
			List<SanaeDrawDiscard> list = Library.CreateCards<SanaeDrawDiscard>(2, this.IsUpgraded).ToList<SanaeDrawDiscard>();
			SanaeDrawDiscard first = list[0];
			SanaeDrawDiscard sanaeDrawDiscard = list[1];
			first.ShowWhichDescription = 1;
			sanaeDrawDiscard.ShowWhichDescription = 2;
			first.SetBattle(base.Battle);
			sanaeDrawDiscard.SetBattle(base.Battle);
			MiniSelectCardInteraction interaction = new MiniSelectCardInteraction(list, false, false, false)
			{
				Source = this
			};
			yield return new InteractionAction(interaction, false);
			bool flag = interaction.SelectedCard == first;
			if (flag)
			{
				List<Card> discard = base.Battle.HandZone.ToList<Card>();
				bool flag2 = discard.Count > base.Value2;
				if (flag2)
				{
					List<Card> thiscard = new List<Card>();
					int num;
					for (int i = 0; i < base.Value2; i = num + 1)
					{
						thiscard.Add(discard.Sample(base.GameRun.BattleCardRng));
						discard.Remove(thiscard[i]);
						num = i;
					}
					yield return new DiscardManyAction(thiscard);
					thiscard = null;
				}
				else
				{
					yield return new DiscardManyAction(discard);
				}
				yield return new DrawManyCardAction(base.Value2);
				discard = null;
			}
			yield break;
		}
	}
}
