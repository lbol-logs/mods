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
	[EntityLogic(typeof(exultbDef))]
	public sealed class exultb : UltimateSkill
	{
		public exultb()
		{
			base.TargetType = TargetType.AllEnemies;
			base.GunName = GunNameID.GetGunFromId(7071);
		}

		protected override IEnumerable<BattleAction> Actions(UnitSelector selector)
		{
			yield return PerformAction.Spell(base.Battle.Player, "exultb");
			foreach (Unit unit in base.Battle.AllAliveEnemies)
			{
				bool battleShouldEnd = base.Battle.BattleShouldEnd;
				if (battleShouldEnd)
				{
					yield break;
				}
				yield return new ApplyStatusEffectAction<sebleed>(unit, new int?(1), new int?(0), new int?(0), new int?(0), 0.2f, true);
				unit = null;
			}
			IEnumerator<EnemyUnit> enumerator = null;
			bool battleShouldEnd2 = base.Battle.BattleShouldEnd;
			if (battleShouldEnd2)
			{
				yield break;
			}
			int num;
			for (int i = 0; i < base.Value2; i = num + 1)
			{
				yield return new DamageAction(base.Owner, base.Battle.AllAliveEnemies, this.Damage, base.GunName, GunType.Single);
				num = i;
			}
			yield break;
			yield break;
		}
	}
}
