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
using YoumuCharacterMod.GunName;

namespace YoumuCharacterMod.YoumuUlt
{
	[EntityLogic(typeof(YoumuUltGDef))]
	public sealed class YoumuUltG : UltimateSkill
	{
		public YoumuUltG()
		{
			base.TargetType = TargetType.SingleEnemy;
			base.GunName = YoumuGunName.UltimateSkillG;
		}

		protected override IEnumerable<BattleAction> Actions(UnitSelector selector)
		{
			EnemyUnit enemy = selector.GetEnemy(base.Battle);
			yield return new DamageAction(base.Owner, enemy, this.Damage, base.GunName, GunType.Single);
			yield return new DamageAction(base.Owner, enemy, this.Damage, YoumuGunName.UltimateSkillGBurst, GunType.Single);
			yield return new DamageAction(base.Owner, enemy, this.Damage, YoumuGunName.UltimateSkillGBurst, GunType.Single);
			bool isAlive = enemy.IsAlive;
			if (isAlive)
			{
				yield return new ApplyStatusEffectAction<LockedOn>(enemy, new int?(base.Value1), new int?(0), new int?(0), new int?(0), 0.2f, true);
			}
			yield break;
		}
	}
}
