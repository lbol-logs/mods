using System;
using System.Collections.Generic;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Cards;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoLEntitySideloader.Attributes;
using PatchouliCharacterMod.BattleActions;
using PatchouliCharacterMod.Cards.Template;
using PatchouliCharacterMod.Patch;

namespace PatchouliCharacterMod.StatusEffects
{
	[EntityLogic(typeof(PatchouliAwakenedSpellbookSeDef))]
	public sealed class PatchouliAwakenedSpellbookSe : StatusEffect
	{
		protected override void OnAdded(Unit unit)
		{
			base.ReactOwnerEvent<CardUsingEventArgs>(base.Battle.CardUsing, new EventSequencedReactor<CardUsingEventArgs>(this.OnCardUsing));
			base.ReactOwnerEvent<CardUsingEventArgs>(base.Battle.CardUsed, new EventSequencedReactor<CardUsingEventArgs>(this.OnCardUsed));
			base.ReactOwnerEvent<TriggerSignEventArgs>(CustomGameEventPatch.Spellcasted, new EventSequencedReactor<TriggerSignEventArgs>(this.OnSignTriggered));
		}

		private IEnumerable<BattleAction> OnSignTriggered(TriggerSignEventArgs args)
		{
			base.NotifyActivating();
			yield return new BoostAllInHandAction(base.Level);
			yield break;
		}

		private IEnumerable<BattleAction> OnCardUsing(CardUsingEventArgs args)
		{
			Card card = args.Card;
			PatchouliBoostCard boostCard = card as PatchouliBoostCard;
			bool flag = boostCard != null;
			if (flag)
			{
				this.Boost = boostCard.Boost;
			}
			yield break;
		}

		private IEnumerable<BattleAction> OnCardUsed(CardUsingEventArgs args)
		{
			Card card = args.Card;
			PatchouliBoostCard boostCard = card as PatchouliBoostCard;
			bool flag = boostCard != null && this.Boost >= this.BoostThreshold1;
			if (flag)
			{
				base.NotifyActivating();
				yield return new ApplyStatusEffectAction<PatchouliFireSignSe>(base.Battle.Player, new int?(base.Level), new int?(0), new int?(PatchouliSignSe.TurnLimit), new int?(0), 0.2f, true);
			}
			yield break;
		}

		public int Boost = 0;

		public int BoostThreshold1 = 4;
	}
}
