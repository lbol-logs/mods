using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Units;
using LBoLEntitySideloader.Attributes;

namespace Momiji.Source.Cards
{
	[EntityLogic(typeof(AlwaysWatchingDef))]
	public sealed class AlwaysWatching : SampleCharacterCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			int intention = 0;
			int count = 0;
			yield return new CastBlockShieldAction(base.Battle.Player, base.Battle.Player, 0, base.Shield.Shield, BlockShieldType.Normal, true);
			foreach (EnemyUnit enemyUnit in base.Battle.EnemyGroup.Alives)
			{
				intention = base.IntentionCheck(enemyUnit);
				bool flag = intention == 1 || intention == 3 || intention == 5 || intention == 7;
				if (flag)
				{
					int num = count;
					count = num + 1;
				}
				enemyUnit = null;
			}
			IEnumerator<EnemyUnit> enumerator = null;
			bool flag2 = count > 0;
			if (flag2)
			{
				yield return new CastBlockShieldAction(base.Battle.Player, base.Battle.Player, base.Block.Block, 0, BlockShieldType.Normal, true);
			}
			yield break;
		}
	}
}
