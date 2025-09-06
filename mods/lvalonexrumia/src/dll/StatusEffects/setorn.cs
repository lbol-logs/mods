using System;
using System.Collections.Generic;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoL.Presentation;
using LBoLEntitySideloader.Attributes;
using lvalonexrumia.Patches;

namespace lvalonexrumia.StatusEffects
{
	[EntityLogic(typeof(setornDef))]
	public sealed class setorn : StatusEffect
	{
		public int lifeneed
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
					num = toolbox.hpfrompercent(Singleton<GameMaster>.Instance.CurrentGameRun.Player, 50, true);
				}
				return num;
			}
		}

		public int increase
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
					num = base.Level * 10;
				}
				return num;
			}
		}

		public int increaselife
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
					num = toolbox.hpfrompercent(Singleton<GameMaster>.Instance.CurrentGameRun.Player, base.Level * 10, true);
				}
				return num;
			}
		}

		protected override void OnAdded(Unit unit)
		{
			base.Count = this.lifeneed;
			base.Highlight = base.Owner.Hp < this.lifeneed;
			base.ReactOwnerEvent<DamageEventArgs>(base.Battle.Player.DamageReceived, new EventSequencedReactor<DamageEventArgs>(this.OnPlayerDamageReceived));
			base.ReactOwnerEvent<ChangeLifeEventArgs>(CustomGameEventManager.PostChangeLifeEvent, new EventSequencedReactor<ChangeLifeEventArgs>(this.OnLifeChanged));
			base.ReactOwnerEvent<GameEventArgs>(base.Battle.BattleEnded, new EventSequencedReactor<GameEventArgs>(this.OnBattleEnded), (GameEventPriority)0);
			base.HandleOwnerEvent<HealEventArgs>(base.Battle.Player.HealingReceived, new GameEventHandler<HealEventArgs>(this.OnHealingReceived));
		}

		private IEnumerable<BattleAction> OnBattleEnded(GameEventArgs args)
		{
			yield return new RemoveStatusEffectAction(this, true, 0.1f);
			yield break;
		}

		private void OnHealingReceived(HealEventArgs args)
		{
			bool battleShouldEnd = base.Battle.BattleShouldEnd;
			if (!battleShouldEnd)
			{
				base.Count = this.lifeneed;
				base.Highlight = base.Owner.Hp < this.lifeneed;
			}
		}

		private IEnumerable<BattleAction> OnLifeChanged(ChangeLifeEventArgs args)
		{
			base.Count = this.lifeneed;
			base.Highlight = base.Owner.Hp < this.lifeneed;
			yield break;
		}

		private IEnumerable<BattleAction> OnPlayerDamageReceived(DamageEventArgs args)
		{
			base.Count = this.lifeneed;
			base.Highlight = base.Owner.Hp < this.lifeneed;
			bool flag = args.DamageInfo.IsGrazed && !base.Battle.BattleShouldEnd && base.Battle.Player.Hp < toolbox.hpfrompercent(Singleton<GameMaster>.Instance.CurrentGameRun.Player, 50, true);
			if (flag)
			{
				base.NotifyActivating();
				yield return new ApplyStatusEffectAction<seatkincrease>(base.Battle.Player, new int?(base.Level * 10), new int?(0), new int?(0), new int?(0), 0.2f, true);
				yield return new ChangeLifeAction(toolbox.hpfrompercent(Singleton<GameMaster>.Instance.CurrentGameRun.Player, base.Level * 10, true), null);
			}
			yield break;
		}
	}
}
