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

namespace Sanae_Kochiya.Source.StatusEffects
{
	[EntityLogic(typeof(SanaeExileDamageSeDef))]
	public sealed class SanaeExileDamageSe : StatusEffect
	{
		protected override void OnAdded(Unit unit)
		{
			base.ReactOwnerEvent<CardEventArgs>(base.Battle.CardExiled, new EventSequencedReactor<CardEventArgs>(this.OnCardExiled));
		}

		private IEnumerable<BattleAction> OnCardExiled(CardEventArgs args)
		{
			bool flag = args.Card.Keywords.HasFlag(Keyword.AutoExile) || args.Card.CardType == CardType.Status;
			if (flag)
			{
				EnemyUnit target = base.Battle.RandomAliveEnemy;
				bool flag2 = target == null;
				if (flag2)
				{
					yield break;
				}
				yield return PerformAction.Effect(target, "DoubleLianhuadieHit", 0f, "DoubleLianhuadie", 0f, PerformAction.EffectBehavior.PlayOneShot, 0f);
				yield return new DamageAction(base.Battle.Player, target, DamageInfo.Reaction((float)base.Level, false), "Instant", GunType.Single);
				target = null;
			}
			yield break;
		}
	}
}
