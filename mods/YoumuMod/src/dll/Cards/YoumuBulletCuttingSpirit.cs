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
using YoumuCharacterMod.Cards.Template;

namespace YoumuCharacterMod.Cards
{
	[EntityLogic(typeof(YoumuBulletCuttingSpiritDef))]
	public sealed class YoumuBulletCuttingSpirit : YoumuCard
	{
		public override Interaction Precondition()
		{
			bool isUpgraded = this.IsUpgraded;
			Interaction interaction;
			if (isUpgraded)
			{
				interaction = null;
			}
			else
			{
				List<Card> list = base.Battle.HandZone.Where((Card hand) => hand != this && hand.CanUpgradeAndPositive).ToList<Card>();
				bool flag = list.Count == 1;
				if (flag)
				{
					this.oneTargetHand = list[0];
				}
				bool flag2 = list.Count <= 1;
				if (flag2)
				{
					interaction = null;
				}
				else
				{
					interaction = new SelectHandInteraction(1, 1, list);
				}
			}
			return interaction;
		}

		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			yield return base.HealAction(base.Value2);
			bool isUpgraded = this.IsUpgraded;
			if (isUpgraded)
			{
				yield return base.UpgradeAllHandsAction();
			}
			else
			{
				bool flag = precondition != null;
				if (flag)
				{
					Card card = ((SelectHandInteraction)precondition).SelectedCards[0];
					bool flag2 = card != null;
					if (flag2)
					{
						yield return new UpgradeCardAction(card);
					}
					card = null;
				}
				else
				{
					bool flag3 = this.oneTargetHand != null;
					if (flag3)
					{
						yield return new UpgradeCardAction(this.oneTargetHand);
						this.oneTargetHand = null;
					}
				}
			}
			yield break;
		}

		private Card oneTargetHand;
	}
}
