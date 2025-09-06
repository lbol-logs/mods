using System;
using HarmonyLib;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Units;
using LBoL.Presentation;
using LBoL.Presentation.Effect;
using LBoL.Presentation.UI.Panels;
using LBoL.Presentation.Units;

namespace lvalonexrumia.Patches
{
	[HarmonyPatch]
	public sealed class ChangeLifeAction : SimpleEventBattleAction<ChangeLifeEventArgs>
	{
		internal ChangeLifeAction(int amount = 1, Unit unit = null)
		{
			base.Args = new ChangeLifeEventArgs
			{
				Amount = amount,
				argsunit = unit
			};
		}

		public override void PreEventPhase()
		{
			base.Trigger(CustomGameEventManager.PreChangeLifeEvent);
		}

		public override void MainPhase()
		{
			BattleAction battleAction = null;
			GameRunController currentGameRun = Singleton<GameMaster>.Instance.CurrentGameRun;
			EnemyUnit enemyUnit = base.Args.argsunit as EnemyUnit;
			UnitView unitView = GameDirector.GetUnit(base.Battle.Player);
			bool flag = enemyUnit != null && enemyUnit.IsAlive;
			if (flag)
			{
				unitView = GameDirector.GetUnit(enemyUnit);
			}
			bool flag2 = base.Args.Amount >= 0;
			PopupHud.Instance.PopupFromScene(Math.Abs(base.Args.Amount), flag2 ? PopupHud.HealColor : PopupHud.PlayerHitColor, unitView.transform.position);
			EffectManager.CreateEffect(flag2 ? "UnitHealLarge" : "BloodHit", unitView.EffectRoot, true);
			AudioManager.PlayUi(flag2 ? "HealLarge" : "Bamuman", false);
			bool flag3 = base.Args.argsunit == null || base.Args.argsunit == base.Battle.Player;
			if (flag3)
			{
				bool flag4 = currentGameRun.Player.Hp + base.Args.Amount > currentGameRun.Player.MaxHp;
				if (flag4)
				{
					currentGameRun.SetHpAndMaxHp(currentGameRun.Player.MaxHp, currentGameRun.Player.MaxHp, true);
					return;
				}
				bool flag5 = currentGameRun.Player.Hp + base.Args.Amount <= 0;
				if (flag5)
				{
					base.React(new ForceKillAction(base.Battle.Player, base.Battle.Player), null, null);
				}
				else
				{
					currentGameRun.SetHpAndMaxHp(currentGameRun.Player.Hp + base.Args.Amount, currentGameRun.Player.MaxHp, true);
				}
			}
			else
			{
				bool flag6 = enemyUnit != null && enemyUnit.IsAlive;
				if (flag6)
				{
					bool flag7 = enemyUnit.Hp + base.Args.Amount > enemyUnit.MaxHp;
					if (flag7)
					{
						currentGameRun.SetEnemyHpAndMaxHp(enemyUnit.MaxHp, enemyUnit.MaxHp, enemyUnit, true);
						return;
					}
					bool flag8 = enemyUnit.Hp + base.Args.Amount <= 0;
					if (flag8)
					{
						base.React(new ForceKillAction(base.Battle.Player, enemyUnit), null, null);
					}
					else
					{
						currentGameRun.SetEnemyHpAndMaxHp(enemyUnit.Hp + base.Args.Amount, enemyUnit.MaxHp, enemyUnit, true);
					}
				}
			}
			bool flag9 = battleAction != null;
			if (flag9)
			{
				base.React(new Reactor(battleAction), null, null);
			}
		}

		public override void PostEventPhase()
		{
			base.Trigger(CustomGameEventManager.PostChangeLifeEvent);
		}
	}
}
