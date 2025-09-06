using System;
using System.Collections.Generic;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Units;
using LBoL.Presentation;
using LBoLEntitySideloader.Attributes;

namespace lvalonexrumia.StatusEffects
{
	[EntityLogic(typeof(sefuckyouDef))]
	public sealed class sefuckyou : sereact
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
				base.Count = Math.Max(0, base.Count - pct);
				bool flag2 = base.Count == 0;
				if (flag2)
				{
					base.NotifyActivating();
					base.Battle.RequestDebugAction(new InstantWinAction(), "lvalonexrumia: Mutual Depletion+ instawin effect");
				}
			}
			yield break;
		}
	}
}
