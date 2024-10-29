using System;
using System.Collections.Generic;
using System.Linq;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Battle.Interactions;
using LBoL.Core.Cards;
using LBoL.EntityLib.Cards;
using LBoLEntitySideloader.Attributes;
using PatchouliCharacterMod.BattleActions;
using PatchouliCharacterMod.Cards.Template;

namespace PatchouliCharacterMod.Cards
{
	[EntityLogic(typeof(PatchouliElementalTriangleDef))]
	public sealed class PatchouliElementalTriangle : PatchouliCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			int selectCardsAmount = 1;
			List<Card> list = new List<Card>();
			List<Type> list2 = this._types.ToList<Type>();
			int num2;
			for (int num = 0; num < list2.Count; num = num2 + 1)
			{
				list.Add(Library.CreateCard(list2[num]));
				num2 = num;
			}
			SelectCardInteraction interaction = new SelectCardInteraction(0, selectCardsAmount, list, SelectedCardHandling.DoNothing)
			{
				Source = this
			};
			yield return new InteractionAction(interaction, false);
			foreach (Card card in interaction.SelectedCards)
			{
				OptionCard optionCard = card as OptionCard;
				bool flag = optionCard != null;
				if (flag)
				{
					optionCard.SetBattle(base.Battle);
					foreach (BattleAction battleAction in optionCard.TakeEffectActions())
					{
						yield return battleAction;
						battleAction = null;
					}
					IEnumerator<BattleAction> enumerator2 = null;
				}
				bool flag2 = optionCard is PatchouliElementalTriangleFire;
				if (flag2)
				{
					yield return new TriggerSignPassiveAction(0);
				}
				else
				{
					bool flag3 = optionCard is PatchouliElementalTriangleWater;
					if (flag3)
					{
						yield return new TriggerSignPassiveAction(1);
					}
					else
					{
						bool flag4 = optionCard is PatchouliElementalTriangleWood;
						if (flag4)
						{
							yield return new TriggerSignPassiveAction(2);
						}
					}
				}
				optionCard = null;
				card = null;
			}
			IEnumerator<Card> enumerator = null;
			yield break;
			yield break;
		}

		private readonly List<Type> _types = new List<Type>
		{
			typeof(PatchouliElementalTriangleFire),
			typeof(PatchouliElementalTriangleWater),
			typeof(PatchouliElementalTriangleWood)
		};
	}
}
