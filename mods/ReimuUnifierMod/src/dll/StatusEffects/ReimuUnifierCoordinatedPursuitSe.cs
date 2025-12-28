using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Cards;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoL.EntityLib.StatusEffects.Reimu;
using LBoLEntitySideloader.Attributes;

namespace ReimuUnifierMod.StatusEffects
{
	[EntityLogic(typeof(ReimuUnifierCoordinatedPursuitSeDef))]
	public sealed class ReimuUnifierCoordinatedPursuitSe : StatusEffect
	{
		private ManaGroup SePreviewMana
		{
			get
			{
				return ManaGroup.Anys(0);
			}
		}

		protected override void OnAdded(Unit unit)
		{
			base.ReactOwnerEvent<CardUsingEventArgs>(base.Battle.CardUsed, new EventSequencedReactor<CardUsingEventArgs>(this.OnCardUsed));
		}

		private IEnumerable<BattleAction> OnCardUsed(CardUsingEventArgs args)
		{
			bool flag = !this.Battle.BattleShouldEnd;
			if (flag)
			{
				Card card = args.Card;
				bool flag2 = card.CardType == CardType.Friend && !card.Summoning;
				if (flag2)
				{
					this.NotifyActivating();
					yield return base.BuffAction<ReimuFreeAttackSe>(base.Level, 0, 0, 0, 0.2f);
					yield break;
				}
				card = null;
			}
			yield break;
		}
	}
}
