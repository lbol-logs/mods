using System;
using System.Collections.Generic;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Units;
using LBoL.Presentation;
using LBoLEntitySideloader.Attributes;
using lvalonexrumia.Patches;

namespace lvalonexrumia.StatusEffects
{
	[EntityLogic(typeof(semutualdepletionDef))]
	public sealed class semutualdepletion : sereact
	{
		public override bool ForceNotShowDownText
		{
			get
			{
				return true;
			}
		}

		protected override IEnumerable<BattleAction> HandleLifeChanged(Unit receive, int amount, Unit source, ActionCause cause, GameEntity actionSource)
		{
			bool battleShouldEnd = base.Battle.BattleShouldEnd;
			if (battleShouldEnd)
			{
				yield break;
			}
			bool flag = actionSource != this && amount < 0 && (receive == null || receive == base.Battle.Player) && !base.Battle.BattleShouldEnd && -amount >= toolbox.hpfrompercent(Singleton<GameMaster>.Instance.CurrentGameRun.Player, 1, true);
			if (flag)
			{
				int pct = -amount * 100 / Singleton<GameMaster>.Instance.CurrentGameRun.Player.MaxHp;
				base.NotifyActivating();
				foreach (Unit unit in base.Battle.AllAliveEnemies)
				{
					bool flag2 = !unit.IsAlive || base.Battle.BattleShouldEnd;
					if (!flag2)
					{
						yield return new ChangeLifeAction(-toolbox.hpfrompercent(unit, pct, true), unit);
						unit = null;
					}
				}
				IEnumerator<EnemyUnit> enumerator = null;
			}
			yield break;
			yield break;
		}
	}
}
