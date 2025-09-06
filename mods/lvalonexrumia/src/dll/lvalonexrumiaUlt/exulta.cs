using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Cards;
using LBoL.Core.Units;
using LBoLEntitySideloader.Attributes;
using lvalonexrumia.GunName;
using lvalonexrumia.StatusEffects;

namespace lvalonexrumia.lvalonexrumiaUlt
{
	[EntityLogic(typeof(exultaDef))]
	public sealed class exulta : UltimateSkill
	{
		public exulta()
		{
			base.TargetType = TargetType.SingleEnemy;
			base.GunName = GunNameID.GetGunFromId(7021);
		}

		protected override IEnumerable<BattleAction> Actions(UnitSelector selector)
		{
			yield return PerformAction.Spell(base.Battle.Player, "exulta");
			EnemyUnit enemy = selector.GetEnemy(base.Battle);
			bool flag = enemy.IsAlive && !base.Battle.BattleShouldEnd;
			if (flag)
			{
				yield return new ApplyStatusEffectAction<sebloodmark>(enemy, new int?(base.Value1), new int?(0), new int?(0), new int?(0), 0.2f, true);
				int num;
				for (int i = 0; i < base.Value2; i = num + 1)
				{
					bool flag2 = enemy.IsAlive && !base.Battle.BattleShouldEnd;
					if (flag2)
					{
						yield return new DamageAction(base.Owner, enemy, this.Damage, base.GunName, GunType.Single);
					}
					num = i;
				}
			}
			yield break;
		}
	}
}
