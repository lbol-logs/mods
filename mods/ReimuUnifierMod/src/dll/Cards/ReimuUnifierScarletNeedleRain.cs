using System;
using System.Collections.Generic;
using System.Linq;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoLEntitySideloader.Attributes;
using ReimuUnifierMod.Cards.Template;

namespace ReimuUnifierMod.Cards
{
	[EntityLogic(typeof(ReimuUnifierScarletNeedleRainDef))]
	public sealed class ReimuUnifierScarletNeedleRain : ReimuUnifierCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			int AttackCount = base.Battle.AllAliveEnemies.Count<EnemyUnit>();
			int num;
			for (int i = 0; i < AttackCount; i = num + 1)
			{
				yield return base.AttackAction(selector, base.GunName);
				num = i;
			}
			foreach (Unit target in base.Battle.AllAliveEnemies)
			{
				yield return base.DebuffAction<Vulnerable>(target, 0, AttackCount, 0, 0, true, 0.2f);
				target = null;
			}
			IEnumerator<EnemyUnit> enumerator = null;
			yield break;
			yield break;
		}
	}
}
