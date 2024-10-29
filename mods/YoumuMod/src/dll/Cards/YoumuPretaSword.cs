using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoLEntitySideloader.Attributes;
using YoumuCharacterMod.Cards.Template;

namespace YoumuCharacterMod.Cards
{
	[EntityLogic(typeof(YoumuPretaSwordDef))]
	public sealed class YoumuPretaSword : YoumuCard
	{
		public override bool Triggered
		{
			get
			{
				IEnumerable<EnemyUnit> allAliveEnemies = base.Battle.AllAliveEnemies;
				foreach (EnemyUnit enemyUnit in allAliveEnemies)
				{
					bool flag = enemyUnit.HasStatusEffect<LockedOn>();
					bool flag2 = flag;
					if (flag2)
					{
						bool flag3 = enemyUnit.GetStatusEffect<LockedOn>().Level >= base.Value1;
						if (flag3)
						{
							return true;
						}
					}
				}
				return false;
			}
		}

		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			yield return base.AttackAction(selector, base.GunName);
			bool flag = base.PlayInTriggered && !base.Battle.BattleShouldEnd;
			if (flag)
			{
				yield return new DrawManyCardAction(base.Value2);
			}
			yield break;
		}
	}
}
