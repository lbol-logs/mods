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
	[EntityLogic(typeof(sebloodmarkDef))]
	public sealed class sebloodmark : StatusEffect
	{
		public int Value
		{
			get
			{
				bool flag = base.Owner == null;
				int num;
				if (flag)
				{
					num = 20;
				}
				else
				{
					bool flag2 = base.Level == 0;
					if (flag2)
					{
						num = 20;
					}
					else
					{
						num = 20 * base.Level;
					}
				}
				return num;
			}
		}

		protected override void OnAdded(Unit unit)
		{
			base.HandleOwnerEvent<DamageEventArgs>(unit.DamageReceiving, new GameEventHandler<DamageEventArgs>(this.OnDamageReceiving));
			base.ReactOwnerEvent<UnitEventArgs>(unit.TurnStarting, new EventSequencedReactor<UnitEventArgs>(this.OnTurnEnding));
		}

		private void OnDamageReceiving(DamageEventArgs args)
		{
			DamageInfo damageInfo = args.DamageInfo;
			bool flag = damageInfo.DamageType == DamageType.Attack;
			if (flag)
			{
				damageInfo.Damage = damageInfo.Amount * (1f + (float)this.Value / 100f);
				args.DamageInfo = damageInfo;
				args.AddModifier(this);
			}
		}

		private IEnumerable<BattleAction> OnTurnEnding(UnitEventArgs args)
		{
			bool battleShouldEnd = base.Battle.BattleShouldEnd;
			if (battleShouldEnd)
			{
				yield break;
			}
			base.NotifyActivating();
			bool flag = base.Level > 1;
			if (flag)
			{
				int level = base.Level;
				base.Level = level - 1;
			}
			else
			{
				yield return new RemoveStatusEffectAction(this, true, 0.1f);
			}
			yield break;
		}
	}
}
