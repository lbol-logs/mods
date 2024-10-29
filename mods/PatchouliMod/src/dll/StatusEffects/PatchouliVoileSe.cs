using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Cards;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoLEntitySideloader.Attributes;
using PatchouliCharacterMod.Cards.Template;

namespace PatchouliCharacterMod.StatusEffects
{
	[EntityLogic(typeof(PatchouliVoileSeDef))]
	public sealed class PatchouliVoileSe : StatusEffect
	{
		public int BoostThreshold1 { get; } = 3;

		public int BoostThreshold2 { get; } = 6;

		public int BoostThreshold3 { get; } = 9;

		public ManaGroup Mana
		{
			get
			{
				return new ManaGroup
				{
					Blue = base.Level
				};
			}
		}

		protected override void OnAdded(Unit unit)
		{
			base.ReactOwnerEvent<CardUsingEventArgs>(base.Battle.CardUsing, new EventSequencedReactor<CardUsingEventArgs>(this.OnCardUsing));
			base.ReactOwnerEvent<CardUsingEventArgs>(base.Battle.CardUsed, new EventSequencedReactor<CardUsingEventArgs>(this.OnCardUsed));
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
			bool flag = args.Card is PatchouliBoostCard;
			if (flag)
			{
				bool flag2 = this.Boost >= this.BoostThreshold1;
				if (flag2)
				{
					base.NotifyActivating();
					yield return new DrawManyCardAction(base.Level);
				}
				bool flag3 = this.Boost >= this.BoostThreshold2;
				if (flag3)
				{
					yield return new GainManaAction(this.Mana);
				}
				bool flag4 = this.Boost >= this.BoostThreshold3;
				if (flag4)
				{
					yield return new ApplyStatusEffectAction<Firepower>(base.Battle.Player, new int?(base.Level), null, null, null, 0f, true);
				}
			}
			yield break;
		}

		private int Boost = 0;
	}
}
