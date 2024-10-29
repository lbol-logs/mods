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
using Sanae_Kochiya.Source.Cards.Starter;

namespace Sanae_Kochiya.Source.Cards.Rare
{
	[EntityLogic(typeof(SanaeExilePowerDef))]
	public sealed class SanaeExilePower : SampleCharacterCard
	{
		public override ManaGroup GetXCostFromPooled(ManaGroup pooledMana)
		{
			return pooledMana;
		}

		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			yield return base.DefenseAction(true);
			List<Card> list = (from zone in base.Battle.DrawZone.Concat(base.Battle.DiscardZone)
				where zone != this
				select zone).ToList<Card>();
			int number = base.SynergyAmount(consumingMana, ManaColor.Any, 1) - 2;
			bool flag = list.Count > 0 && number > 0;
			if (flag)
			{
				SelectHandInteraction interaction = new SelectHandInteraction(0, number, list)
				{
					Source = this
				};
				yield return new InteractionAction(interaction, false);
				IReadOnlyList<Card> selectedCards = interaction.SelectedCards.ToList<Card>();
				interaction = null;
				bool flag2 = selectedCards.Count > 0;
				if (flag2)
				{
					yield return new ExileManyCardAction(selectedCards);
					bool isUpgraded = this.IsUpgraded;
					if (isUpgraded)
					{
						yield return new AddCardsToDiscardAction(Library.CreateCards<SanaeStatus>(selectedCards.Count, false), AddCardsType.Normal);
					}
				}
				interaction = null;
				selectedCards = null;
			}
			yield break;
		}
	}
}
