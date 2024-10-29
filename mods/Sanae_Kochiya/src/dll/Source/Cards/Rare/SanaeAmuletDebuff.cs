using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Battle.Interactions;
using LBoL.Core.Cards;
using LBoL.Core.StatusEffects;
using LBoL.EntityLib.StatusEffects.Others;
using LBoLEntitySideloader.Attributes;
using Sanae_Kochiya.Cards.Template;

namespace Sanae_Kochiya.Source.Cards.Rare
{
	[EntityLogic(typeof(SanaeAmuletDebuffDef))]
	public sealed class SanaeAmuletDebuff : SampleCharacterCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			List<Card> list = new List<Card>
			{
				Library.CreateCard(typeof(SanaeAmuletDebuffWeak)),
				Library.CreateCard(typeof(SanaeAmuletDebuffFrail)),
				Library.CreateCard(typeof(SanaeAmuletDebuffVuln))
			};
			SelectCardInteraction interaction = new SelectCardInteraction(1, 3, list, SelectedCardHandling.DoNothing)
			{
				Source = this
			};
			yield return new InteractionAction(interaction, false);
			bool[] flags = new bool[3];
			foreach (Card card in interaction.SelectedCards)
			{
				bool flag = card.GetType() == typeof(SanaeAmuletDebuffWeak);
				if (flag)
				{
					flags[0] = true;
				}
				else
				{
					bool flag2 = card.GetType() == typeof(SanaeAmuletDebuffFrail);
					if (flag2)
					{
						flags[1] = true;
					}
					else
					{
						bool flag3 = card.GetType() == typeof(SanaeAmuletDebuffVuln);
						if (flag3)
						{
							flags[2] = true;
						}
					}
				}
				card = null;
			}
			IEnumerator<Card> enumerator = null;
			bool flag4 = flags[0];
			if (flag4)
			{
				yield return base.BuffAction<Firepower>(base.Value1, 0, 0, 0, 0.1f);
				yield return base.DebuffAction<Weak>(base.Battle.Player, 0, base.Value1, 0, 0, true, 0.1f);
			}
			bool flag5 = flags[1];
			if (flag5)
			{
				yield return base.BuffAction<Spirit>(base.Value1, 0, 0, 0, 0.1f);
				yield return base.DebuffAction<Fragil>(base.Battle.Player, 0, base.Value1, 0, 0, true, 0.1f);
			}
			bool flag6 = flags[2];
			if (flag6)
			{
				base.GameRun.GainMaxHp(base.Value1, true, true);
				yield return base.DebuffAction<Vulnerable>(base.Battle.Player, 0, base.Value1, 0, 0, true, 0.1f);
				yield return base.DebuffAction<Poison>(base.Battle.Player, base.Value1, 0, 0, 0, true, 0.1f);
			}
			yield break;
		}
	}
}
