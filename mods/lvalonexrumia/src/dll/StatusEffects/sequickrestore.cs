using System;
using System.Collections.Generic;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoLEntitySideloader.Attributes;

namespace lvalonexrumia.StatusEffects
{
	[EntityLogic(typeof(sequickrestoreDef))]
	public sealed class sequickrestore : StatusEffect
	{
		public override bool ForceNotShowDownText
		{
			get
			{
				return true;
			}
		}

		public int truecounter
		{
			get
			{
				return this.truecount;
			}
		}

		protected override void OnAdded(Unit unit)
		{
			bool flag = base.Count != 0;
			if (flag)
			{
				this.truecount = base.Count;
			}
			else
			{
				this.truecount = base.Owner.Hp;
				base.Count = this.truecount;
			}
			base.ReactOwnerEvent<GameEventArgs>(base.Battle.RoundEnded, new EventSequencedReactor<GameEventArgs>(this.OnTurnEnding));
			base.ReactOwnerEvent<GameEventArgs>(base.Battle.BattleEnding, new EventSequencedReactor<GameEventArgs>(this.OnBattleEnding));
		}

		private IEnumerable<BattleAction> OnBattleEnding(GameEventArgs args)
		{
			seidlive seidlive;
			bool flag = base.Battle.Player.TryGetStatusEffect<seidlive>(out seidlive);
			if (flag)
			{
				base.NotifyActivating();
				base.GameRun.SetHpAndMaxHp(this.truecount, base.GameRun.Player.MaxHp, true);
			}
			yield break;
		}

		private IEnumerable<BattleAction> OnTurnEnding(GameEventArgs args)
		{
			bool battleShouldEnd = base.Battle.BattleShouldEnd;
			if (battleShouldEnd)
			{
				yield break;
			}
			bool flag = this.truecount > 0;
			if (flag)
			{
				bool flag2 = this.truecount > base.GameRun.Player.MaxHp;
				if (flag2)
				{
					this.truecount = base.GameRun.Player.MaxHp;
				}
				base.NotifyActivating();
				base.GameRun.SetHpAndMaxHp(this.truecount, base.GameRun.Player.MaxHp, true);
			}
			yield return new RemoveStatusEffectAction(this, true, 0.1f);
			yield break;
		}

		private int truecount = 0;
	}
}
