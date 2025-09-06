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
	[EntityLogic(typeof(seadrenalineDef))]
	public sealed class seadrenaline : sereact
	{
		public int atkincrease
		{
			get
			{
				bool flag = base.Owner == null;
				int num;
				if (flag)
				{
					num = 0;
				}
				else
				{
					num = base.Level * 5;
				}
				return num;
			}
		}

		protected override void dosmth()
		{
			base.Count = base.lifeneed;
			base.Highlight = base.Owner.Hp < base.lifeneed;
		}

		protected override void OnHealingReceived(HealEventArgs args)
		{
			this.dosmth();
		}

		protected override IEnumerable<BattleAction> HandleLifeChanged(Unit receive, int amount, Unit source, ActionCause cause, GameEntity actionSource)
		{
			base.Count = base.lifeneed;
			base.Highlight = base.Owner.Hp < base.lifeneed;
			bool battleShouldEnd = base.Battle.BattleShouldEnd;
			if (battleShouldEnd)
			{
				yield break;
			}
			bool flag = actionSource != this && amount < 0 && (receive == null || receive == base.Battle.Player) && !base.Battle.BattleShouldEnd && base.Battle.Player.Hp < toolbox.hpfrompercent(Singleton<GameMaster>.Instance.CurrentGameRun.Player, 50, true);
			if (flag)
			{
				base.NotifyActivating();
				yield return new ApplyStatusEffectAction<seatkincrease>(base.Battle.Player, new int?(base.Level * 5), new int?(0), new int?(0), new int?(0), 0.2f, true);
				yield return new ApplyStatusEffectAction<sebloodclot>(base.Battle.Player, new int?(base.Level), new int?(0), new int?(0), new int?(0), 0.2f, true);
			}
			yield break;
		}
	}
}
