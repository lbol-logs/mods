using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Cards;
using LBoLEntitySideloader.Attributes;
using PatchouliCharacterMod.Cards.Template;

namespace PatchouliCharacterMod.Cards
{
	[EntityLogic(typeof(PatchouliTwinspellDef))]
	public sealed class PatchouliTwinspell : PatchouliCard
	{
		protected override void OnEnterBattle(BattleController battle)
		{
			base.ReactBattleEvent<CardUsingEventArgs>(base.Battle.CardUsing, new EventSequencedReactor<CardUsingEventArgs>(this.OnCardUsing));
		}

		private IEnumerable<BattleAction> OnCardUsing(CardUsingEventArgs args)
		{
			PatchouliBoostCard boostCard;
			bool flag;
			if (base.Zone == CardZone.Hand)
			{
				Card card = args.Card;
				boostCard = card as PatchouliBoostCard;
				flag = boostCard != null;
			}
			else
			{
				flag = false;
			}
			bool flag2 = flag;
			if (flag2)
			{
				PatchouliBoostCard transformedCard = (PatchouliBoostCard)boostCard.CloneBattleCard();
				transformedCard.Boost = boostCard.Boost;
				bool isUpgraded = this.IsUpgraded;
				if (isUpgraded)
				{
					transformedCard.IsUpgraded = this.IsUpgraded;
				}
				yield return new TransformCardAction(this, transformedCard);
				transformedCard = null;
			}
			yield break;
		}

		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			yield return new DrawManyCardAction(base.Value1);
			yield break;
		}
	}
}
