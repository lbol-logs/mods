using System;
using System.Collections.Generic;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Cards;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoLEntitySideloader.Attributes;
using ReimuUnifierMod.Cards;

namespace ReimuUnifierMod.StatusEffects
{
	[EntityLogic(typeof(ReimuUnifierRetributiveBoundarySeDef))]
	public sealed class ReimuUnifierRetributiveBoundarySe : StatusEffect
	{
		protected override void OnAdded(Unit unit)
		{
			base.ReactOwnerEvent<StatisticalDamageEventArgs>(base.Owner.StatisticalTotalDamageReceived, new EventSequencedReactor<StatisticalDamageEventArgs>(this.OnStatisticalDamageReceived));
			base.ReactOwnerEvent<UnitEventArgs>(base.Owner.TurnStarted, new EventSequencedReactor<UnitEventArgs>(this.OnOwnerTurnStarted));
		}

		private IEnumerable<BattleAction> OnStatisticalDamageReceived(StatisticalDamageEventArgs args)
		{
			bool flag = args.DamageSource != base.Owner;
			if (flag)
			{
				base.NotifyActivating();
				int num;
				for (int i = 0; i < base.Level; i = num + 1)
				{
					yield return new AddCardsToHandAction(new Card[] { Library.CreateCard<ReimuUnifierYoukaiForgedNeedle>() });
					num = i;
				}
			}
			yield break;
		}

		private IEnumerable<BattleAction> OnOwnerTurnStarted(UnitEventArgs args)
		{
			yield return new RemoveStatusEffectAction(this, true, 0.1f);
			yield break;
		}
	}
}
