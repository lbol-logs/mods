using System;
using System.Collections.Generic;
using LBoL.Base.Extensions;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoLEntitySideloader.Attributes;

namespace ReimuUnifierMod.StatusEffects
{
	[EntityLogic(typeof(ReimuUnifierPerfectCherryBorderSeDef))]
	public sealed class ReimuUnifierPerfectCherryBorderSe : StatusEffect
	{
		private int ActiveTimes { get; set; }

		protected override void OnAdded(Unit unit)
		{
			base.HandleOwnerEvent<DamageEventArgs>(base.Battle.Player.DamageTaking, new GameEventHandler<DamageEventArgs>(this.OnPlayerDamageTaking));
			base.ReactOwnerEvent<DamageEventArgs>(base.Battle.Player.DamageReceived, new EventSequencedReactor<DamageEventArgs>(this.OnPlayerDamageReceived));
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
				bool flag2 = base.Battle.Player.HasStatusEffect<ReimuUnifierPCBReflectSe>();
				if (flag2)
				{
					base.Battle.Player.GetStatusEffect<ReimuUnifierPCBReflectSe>().NotifyActivating();
					base.Battle.Player.GetStatusEffect<ReimuUnifierPCBReflectSe>().Count += num;
				}
			}
		}

		private IEnumerable<BattleAction> OnPlayerDamageReceived(DamageEventArgs args)
		{
			bool flag = base.Battle.Player.HasStatusEffect<ReimuUnifierPCBReflectSe>() && base.Battle.Player.GetStatusEffect<ReimuUnifierPCBReflectSe>().Count != 0;
			if (flag)
			{
				foreach (EnemyUnit enemy in base.Battle.AllAliveEnemies)
				{
					yield return DamageAction.LoseLife(enemy, base.Battle.Player.GetStatusEffect<ReimuUnifierPCBReflectSe>().Count, "Instant");
					enemy = null;
				}
				IEnumerator<EnemyUnit> enumerator = null;
				base.Battle.Player.GetStatusEffect<ReimuUnifierPCBReflectSe>().Count = 0;
				base.Battle.Player.GetStatusEffect<ReimuUnifierPCBReflectSe>().Level -= this.ActiveTimes;
				bool flag2 = base.Battle.Player.GetStatusEffect<ReimuUnifierPCBReflectSe>().Level <= 0;
				if (flag2)
				{
					yield return new RemoveStatusEffectAction(base.Battle.Player.GetStatusEffect<ReimuUnifierPCBReflectSe>(), true, 0.1f);
				}
			}
			base.Level -= this.ActiveTimes;
			this.ActiveTimes = 0;
			bool flag3 = base.Level <= 0;
			if (flag3)
			{
				yield return new RemoveStatusEffectAction(this, true, 0.1f);
			}
			yield break;
			yield break;
		}
	}
}
