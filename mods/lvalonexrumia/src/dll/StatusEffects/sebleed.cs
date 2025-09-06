using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoLEntitySideloader.Attributes;
using lvalonexrumia.Patches;

namespace lvalonexrumia.StatusEffects
{
	[EntityLogic(typeof(sebleedDef))]
	public sealed class sebleed : StatusEffect
	{
		public int truecount
		{
			get
			{
				bool flag = base.Owner != null;
				int num;
				if (flag)
				{
					num = (int)Math.Ceiling((double)((float)base.Owner.MaxHp * 0.01f));
				}
				else
				{
					num = 0;
				}
				return num;
			}
		}

		public int lifenow
		{
			get
			{
				bool flag = base.Owner != null;
				int num;
				if (flag)
				{
					num = base.Owner.Hp;
				}
				else
				{
					num = 0;
				}
				return num;
			}
		}

		protected override void OnAdded(Unit unit)
		{
			base.Count = (int)Math.Ceiling((double)((float)unit.MaxHp * 0.01f));
			base.ReactOwnerEvent<DamageEventArgs>(unit.DamageReceived, new EventSequencedReactor<DamageEventArgs>(this.OnDamageReceived));
			base.ReactOwnerEvent<UnitEventArgs>(unit.TurnEnding, new EventSequencedReactor<UnitEventArgs>(this.OnTurnEnding));
		}

		private IEnumerable<BattleAction> OnDamageReceived(DamageEventArgs args)
		{
			bool flag = args.DamageInfo.DamageType == DamageType.Attack;
			if (flag)
			{
				base.NotifyActivating();
				bool isNotAlive = args.Target.IsNotAlive;
				if (isNotAlive)
				{
					yield break;
				}
				yield return new ChangeLifeAction(-(int)Math.Ceiling((double)((float)args.Target.MaxHp * 0.01f)), args.Target);
			}
			yield break;
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
