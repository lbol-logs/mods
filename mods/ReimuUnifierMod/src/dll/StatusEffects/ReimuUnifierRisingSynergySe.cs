using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Cards;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoLEntitySideloader.Attributes;

namespace ReimuUnifierMod.StatusEffects
{
	[EntityLogic(typeof(ReimuUnifierRisingSynergySeDef))]
	public sealed class ReimuUnifierRisingSynergySe : StatusEffect
	{
		protected override void OnAdded(Unit unit)
		{
			base.ReactOwnerEvent<StatisticalDamageEventArgs>(base.Owner.StatisticalTotalDamageDealt, new EventSequencedReactor<StatisticalDamageEventArgs>(this.OnStatisticalDamageDealt));
		}

		private IEnumerable<BattleAction> OnStatisticalDamageDealt(StatisticalDamageEventArgs args)
		{
			bool flag = args.DamageSource == base.Owner && args.ActionSource is Card;
			if (flag)
			{
				Card CardDamageSource = (Card)args.ActionSource;
				bool flag2 = CardDamageSource.CardType == CardType.Friend;
				if (flag2)
				{
					base.NotifyActivating();
					yield return base.BuffAction<TempFirepower>(base.Level, 0, 0, 0, 0.2f);
				}
				CardDamageSource = null;
			}
			yield break;
		}
	}
}
