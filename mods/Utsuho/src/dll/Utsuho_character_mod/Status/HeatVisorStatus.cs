﻿using System;
using System.Collections.Generic;
using LBoL.Base.Extensions;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoLEntitySideloader.Attributes;

namespace Utsuho_character_mod.Status
{
	[EntityLogic(typeof(HeatVisorEffect))]
	public sealed class HeatVisorStatus : StatusEffect
	{
		private int ActiveTimes { get; set; }

		protected override void OnAdded(Unit unit)
		{
			base.ReactOwnerEvent<UnitEventArgs>(base.Owner.TurnStarting, new EventSequencedReactor<UnitEventArgs>(this.OnOwnerTurnStarting));
			base.HandleOwnerEvent<DamageEventArgs>(base.Battle.Player.DamageTaking, new GameEventHandler<DamageEventArgs>(this.OnPlayerDamageTaking));
			base.ReactOwnerEvent<DamageEventArgs>(base.Battle.Player.DamageReceived, new EventSequencedReactor<DamageEventArgs>(this.OnPlayerDamageReceived));
		}

		private IEnumerable<BattleAction> OnOwnerTurnStarting(UnitEventArgs args)
		{
			yield return new RemoveStatusEffectAction(this, true, 0.1f);
			yield break;
		}

		private void OnPlayerDamageTaking(DamageEventArgs args)
		{
			DamageInfo damageInfo = args.DamageInfo;
			int num = damageInfo.Damage.RoundToInt();
			bool flag = num >= 1 && this.ActiveTimes < base.Level;
			if (flag)
			{
				base.NotifyActivating();
				int num2 = this.ActiveTimes + 1;
				this.ActiveTimes = num2;
				args.DamageInfo = damageInfo.ReduceActualDamageBy(num);
				args.AddModifier(this);
			}
		}

		private IEnumerable<BattleAction> OnPlayerDamageReceived(DamageEventArgs args)
		{
			base.Level -= this.ActiveTimes;
			this.ActiveTimes = 0;
			bool flag = base.Level <= 0;
			if (flag)
			{
				yield return new RemoveStatusEffectAction(this, true, 0.1f);
			}
			yield break;
		}
	}
}
