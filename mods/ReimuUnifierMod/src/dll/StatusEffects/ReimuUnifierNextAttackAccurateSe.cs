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

namespace ReimuUnifierMod.StatusEffects
{
	[EntityLogic(typeof(ReimuUnifierNextAttackAccurateSeDef))]
	public sealed class ReimuUnifierNextAttackAccurateSe : StatusEffect
	{
		protected override void OnAdded(Unit unit)
		{
			base.HandleOwnerEvent<DamageDealingEventArgs>(base.Battle.Player.DamageDealing, new GameEventHandler<DamageDealingEventArgs>(this.OnDamageDealing));
			base.ReactOwnerEvent<CardUsingEventArgs>(base.Battle.CardUsed, new EventSequencedReactor<CardUsingEventArgs>(this.OnCardUsing));
		}

		private void OnDamageDealing(DamageDealingEventArgs args)
		{
			Card card = args.ActionSource as Card;
			bool flag = card != null && card.Config.Type == CardType.Attack;
			if (flag)
			{
				bool flag2 = !args.DamageInfo.IsAccuracy;
				if (flag2)
				{
					DamageInfo damageInfo = args.DamageInfo;
					damageInfo.IsAccuracy = true;
					args.DamageInfo = damageInfo;
					args.AddModifier(this);
				}
			}
		}

		private IEnumerable<BattleAction> OnCardUsing(CardUsingEventArgs args)
		{
			bool flag = args.Card.CardType == CardType.Attack && !args.Card.IsAccuracy;
			if (flag)
			{
				base.NotifyActivating();
				int level = base.Level - 1;
				base.Level = level;
				bool flag2 = base.Level <= 0;
				if (flag2)
				{
					yield return new RemoveStatusEffectAction(this, true, 0.1f);
				}
			}
			yield break;
		}
	}
}
