using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoLEntitySideloader.Attributes;

namespace Momiji.Source.Cards
{
	[EntityLogic(typeof(PartingSliceDef))]
	public sealed class PartingSlice : SampleCharacterCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			int intention = 0;
			int count = 0;
			EnemyUnit[] enemies = selector.GetEnemies(base.Battle);
			foreach (EnemyUnit enemy in enemies)
			{
				intention = base.IntentionCheck(enemy);
				bool flag = intention == 1 || intention == 3 || intention == 5 || intention == 7;
				if (flag)
				{
					int num = count;
					count = num + 1;
				}
				enemy = null;
			}
			EnemyUnit[] array = null;
			yield return base.AttackAction(selector, base.GunName);
			bool isUpgraded = this.IsUpgraded;
			if (isUpgraded)
			{
				yield return base.AttackAction(selector, base.GunName);
			}
			bool battleShouldEnd = base.Battle.BattleShouldEnd;
			if (battleShouldEnd)
			{
				yield break;
			}
			bool flag2 = count > 0;
			if (flag2)
			{
				yield return new ApplyStatusEffectAction<Graze>(base.Battle.Player, new int?(base.Value1 * count), new int?(0), new int?(0), new int?(0), 0.2f, true);
			}
			yield break;
		}
	}
}
