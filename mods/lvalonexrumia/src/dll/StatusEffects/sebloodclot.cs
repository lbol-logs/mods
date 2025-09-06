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
	[EntityLogic(typeof(sebloodclotDef))]
	public sealed class sebloodclot : StatusEffect
	{
		public int Value
		{
			get
			{
				bool flag = base.Owner == null;
				int num;
				if (flag)
				{
					num = 5;
				}
				else
				{
					bool flag2 = base.Level == 0;
					if (flag2)
					{
						num = 5;
					}
					else
					{
						num = Math.Min(5 * base.Level, 100);
					}
				}
				return num;
			}
		}

		protected override void OnAdded(Unit unit)
		{
			base.HandleOwnerEvent<DamageEventArgs>(unit.DamageReceiving, new GameEventHandler<DamageEventArgs>(this.OnDamageReceiving));
			base.ReactOwnerEvent<GameEventArgs>(base.Battle.RoundEnded, new EventSequencedReactor<GameEventArgs>(this.OnRoundEnded));
		}

		private IEnumerable<BattleAction> OnRoundEnded(GameEventArgs args)
		{
			bool battleShouldEnd = base.Battle.BattleShouldEnd;
			if (battleShouldEnd)
			{
				yield break;
			}
			yield return new RemoveStatusEffectAction(this, true, 0.1f);
			yield break;
		}

		private void OnDamageReceiving(DamageEventArgs args)
		{
			DamageInfo damageInfo = args.DamageInfo;
			bool flag = damageInfo.DamageType == DamageType.Attack;
			if (flag)
			{
				damageInfo.Damage = damageInfo.Amount * (1f - (float)this.Value / 100f);
				args.DamageInfo = damageInfo;
				args.AddModifier(this);
			}
		}
	}
}
