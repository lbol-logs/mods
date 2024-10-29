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
using PatchouliCharacterMod.Cards.Template;

namespace PatchouliCharacterMod.Cards
{
	[EntityLogic(typeof(PatchouliSpellCreationDef))]
	public sealed class PatchouliSpellCreation : PatchouliBoostCard
	{
		protected override bool HasTreshold { get; set; } = true;

		protected override int BoostThreshold1 { get; set; } = 2;

		protected override int BoostThreshold2 { get; set; } = 4;

		protected override int BoostThreshold3 { get; set; } = 6;

		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			int selectCardsAmount = 0;
			bool flag = base.Boost >= this.BoostThreshold1;
			if (flag)
			{
				int num2 = selectCardsAmount;
				selectCardsAmount = num2 + 1;
			}
			bool flag2 = base.Boost >= this.BoostThreshold2;
			if (flag2)
			{
				int num2 = selectCardsAmount;
				selectCardsAmount = num2 + 1;
			}
			bool flag3 = base.Boost >= this.BoostThreshold3;
			if (flag3)
			{
				int num2 = selectCardsAmount;
				selectCardsAmount = num2 + 1;
			}
			bool isUpgraded = this.IsUpgraded;
			if (isUpgraded)
			{
				int num2 = selectCardsAmount;
				selectCardsAmount = num2 + 1;
			}
			bool flag4 = selectCardsAmount > 0 && !base.Battle.BattleShouldEnd;
			if (flag4)
			{
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
				yield return base.AttackAction(selector, base.GunName);
				foreach (Card card in interaction.SelectedCards)
				{
					OptionCard optionCard = card as OptionCard;
					bool flag5 = optionCard != null;
					if (flag5)
					{
						optionCard.SetBattle(base.Battle);
						foreach (BattleAction battleAction in optionCard.TakeEffectActions())
						{
							yield return battleAction;
							battleAction = null;
						}
						IEnumerator<BattleAction> enumerator2 = null;
					}
					optionCard = null;
					card = null;
				}
				IEnumerator<Card> enumerator = null;
				base.ResetBoost();
				list = null;
				list2 = null;
				interaction = null;
			}
			else
			{
				yield return base.AttackAction(selector, base.GunName);
			}
			yield break;
			yield break;
		}

		private readonly List<Type> _types = new List<Type>
		{
			typeof(PatchouliSpellCreationBlock),
			typeof(PatchouliSpellCreationDraw),
			typeof(PatchouliSpellCreationFire),
			typeof(PatchouliSpellCreationWeak)
		};
	}
}
