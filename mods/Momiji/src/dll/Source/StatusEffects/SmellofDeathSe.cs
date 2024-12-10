using System;
using System.Collections.Generic;
using System.Linq;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Cards;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoLEntitySideloader.Attributes;
using UnityEngine;

namespace Momiji.Source.StatusEffects
{
	[EntityLogic(typeof(SmellofDeathSeDef))]
	public sealed class SmellofDeathSe : StatusEffect
	{
		public int FinalDamage
		{
			get
			{
				return base.Owner.MaxHp * base.Level / 2;
			}
		}

		protected override void OnAdded(Unit unit)
		{
			bool flag = !(unit is EnemyUnit);
			if (flag)
			{
				Debug.LogError("Cannot add DeathExplode to " + unit.GetType().Name);
			}
			else
			{
				base.ReactOwnerEvent<DieEventArgs>(base.Owner.Dying, new EventSequencedReactor<DieEventArgs>(this.OnDying));
			}
		}

		private IEnumerable<BattleAction> OnDying(DieEventArgs args)
		{
			DieCause dieCause = args.DieCause;
			bool flag = dieCause == DieCause.Explode || dieCause == DieCause.ServantDie;
			if (flag)
			{
				yield break;
			}
			base.NotifyActivating();
			args.CancelBy(this);
			Unit owner = base.Owner;
			yield return new DamageAction(owner as EnemyUnit, base.Battle.AllAliveEnemies.Where((EnemyUnit e) => e != owner), DamageInfo.Attack((float)this.FinalDamage, false), "冰封噩梦B", GunType.Single);
			yield return new DieAction(owner, DieCause.Explode, owner, this);
			yield break;
		}
	}
}
