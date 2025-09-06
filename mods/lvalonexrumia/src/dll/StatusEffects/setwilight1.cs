using System;
using System.Collections.Generic;
using LBoL.Base;
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
	[EntityLogic(typeof(setwilight1Def))]
	public sealed class setwilight1 : StatusEffect
	{
		public int truecounter
		{
			get
			{
				return this.truecount;
			}
		}

		public int lifeneed
		{
			get
			{
				bool flag = Singleton<GameMaster>.Instance.CurrentGameRun == null;
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

		private void updatecounter()
		{
			bool flag = base.Owner.Hp < this.lifeneed;
			if (flag)
			{
				this.truecount = Convert.ToInt32(Math.Ceiling((double)(base.GameRun.Player.MaxHp - base.GameRun.Player.Hp) * (double)base.Level / 100.0));
				base.Count = this.truecount;
				base.Highlight = true;
			}
			else
			{
				this.truecount = 0;
				base.Count = 0;
				base.Highlight = false;
			}
		}

		protected override void OnAdded(Unit unit)
		{
			this.updatecounter();
			base.ReactOwnerEvent<ChangeLifeEventArgs>(CustomGameEventManager.PostChangeLifeEvent, new EventSequencedReactor<ChangeLifeEventArgs>(this.OnLifeChanged));
			foreach (Unit unit2 in base.Battle.AllAliveUnits)
			{
				base.ReactOwnerEvent<DamageEventArgs>(unit2.DamageReceived, new EventSequencedReactor<DamageEventArgs>(this.OnDamageReceived));
			}
			base.HandleOwnerEvent<UnitEventArgs>(base.Battle.EnemySpawned, new GameEventHandler<UnitEventArgs>(this.OnEnemySpawned));
			base.HandleOwnerEvent<DamageDealingEventArgs>(base.Battle.Player.DamageDealing, new GameEventHandler<DamageDealingEventArgs>(this.OnDamageDealing));
			base.HandleOwnerEvent<HealEventArgs>(base.Battle.Player.HealingReceived, new GameEventHandler<HealEventArgs>(this.OnHealingReceived));
			base.ReactOwnerEvent<GameEventArgs>(base.Battle.BattleEnded, new EventSequencedReactor<GameEventArgs>(this.OnBattleEnded), (GameEventPriority)0);
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
				this.updatecounter();
			}
		}

		private void OnDamageDealing(DamageDealingEventArgs args)
		{
			bool flag = args.DamageInfo.DamageType == DamageType.Attack && base.Count > 0;
			if (flag)
			{
				args.DamageInfo = args.DamageInfo.IncreaseBy(Convert.ToInt32(Math.Ceiling((double)(base.GameRun.Player.MaxHp - base.GameRun.Player.Hp) * (double)base.Level / 100.0)));
				args.AddModifier(this);
			}
		}

		private void OnEnemySpawned(UnitEventArgs args)
		{
			base.ReactOwnerEvent<DamageEventArgs>(args.Unit.DamageReceived, new EventSequencedReactor<DamageEventArgs>(this.OnDamageReceived));
		}

		private IEnumerable<BattleAction> OnDamageReceived(DamageEventArgs args)
		{
			this.updatecounter();
			yield break;
		}

		private IEnumerable<BattleAction> OnLifeChanged(ChangeLifeEventArgs args)
		{
			this.updatecounter();
			yield break;
		}

		private int truecount = 0;
	}
}
