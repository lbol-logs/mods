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
using Momiji.Source.GunName;

namespace Momiji.Source.Ultimate
{
	[EntityLogic(typeof(RabiesBiteDef))]
	public sealed class RabiesBite : UltimateSkill
	{
		public RabiesBite()
		{
			base.TargetType = TargetType.SingleEnemy;
			base.GunName = GunNameID.GetGunFromId(4158);
		}

		protected override IEnumerable<BattleAction> Actions(UnitSelector selector)
		{
			EnemyUnit enemy = selector.GetEnemy(base.Battle);
			yield return PerformAction.Spell(base.Battle.Player, "RabiesBite");
			yield return new DamageAction(base.Owner, enemy, this.Damage, base.GunName, GunType.Single);
			yield return new DamageAction(base.Owner, enemy, this.Damage, base.GunName, GunType.Single);
			bool isAlive = enemy.IsAlive;
			if (isAlive)
			{
				yield return new ApplyStatusEffectAction<Vulnerable>(enemy, new int?(0), new int?(base.Value1), new int?(0), new int?(0), 0.2f, true);
				yield break;
			}
			yield break;
		}

		public void OnEnterBattle(BattleController battle)
		{
			base.Owner.ReactBattleEvent<DieEventArgs>(base.Battle.EnemyDied, new Func<DieEventArgs, IEnumerable<BattleAction>>(this.OnEnemyDied));
		}

		private IEnumerable<BattleAction> OnEnemyDied(DieEventArgs args)
		{
			bool flag = args.DieSource == this && !args.Unit.HasStatusEffect<Servant>();
			if (flag)
			{
				base.GameRun.GainMaxHp(base.Value2, true, true);
				yield return PerformAction.Sfx("Shengyan", 0f);
			}
			yield break;
		}
	}
}
