using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoLEntitySideloader.Attributes;

namespace lvalonexrumia.StatusEffects
{
	[EntityLogic(typeof(semagiaDef))]
	public sealed class semagia : StatusEffect
	{
		protected override void OnAdded(Unit unit)
		{
			base.ReactOwnerEvent<DamageEventArgs>(base.Owner.DamageReceived, new EventSequencedReactor<DamageEventArgs>(this.OnDamageReceived));
			base.ReactOwnerEvent<GameEventArgs>(base.Battle.RoundEnded, new EventSequencedReactor<GameEventArgs>(this.OnTurnEnding));
		}

		private IEnumerable<BattleAction> OnDamageReceived(DamageEventArgs args)
		{
			bool flag = args.DamageInfo.DamageType == DamageType.Attack;
			if (flag)
			{
				base.NotifyActivating();
				yield return new ApplyStatusEffectAction<sebloodsword>(base.Battle.Player, new int?(base.Level), new int?(0), new int?(0), new int?(0), 0.2f, true);
			}
			yield break;
		}

		private IEnumerable<BattleAction> OnTurnEnding(GameEventArgs args)
		{
			bool battleShouldEnd = base.Battle.BattleShouldEnd;
			if (battleShouldEnd)
			{
				yield break;
			}
			yield return new RemoveStatusEffectAction(this, true, 0.1f);
			yield break;
		}
	}
}
