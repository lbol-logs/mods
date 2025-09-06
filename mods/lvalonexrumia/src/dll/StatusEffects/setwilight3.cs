using System;
using System.Collections.Generic;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Cards;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoL.Presentation;
using LBoLEntitySideloader.Attributes;
using lvalonexrumia.Patches;

namespace lvalonexrumia.StatusEffects
{
	[EntityLogic(typeof(setwilight3Def))]
	public sealed class setwilight3 : StatusEffect
	{
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
					num = toolbox.hpfrompercent(Singleton<GameMaster>.Instance.CurrentGameRun.Player, 15, true);
				}
				return num;
			}
		}

		private void updatecounter()
		{
			base.Count = this.lifeneed;
			base.Highlight = base.Owner.Hp < this.lifeneed;
		}

		protected override void OnAdded(Unit unit)
		{
			this.go = false;
			this.updatecounter();
			base.ReactOwnerEvent<CardUsingEventArgs>(base.Battle.CardUsed, new EventSequencedReactor<CardUsingEventArgs>(this.OnCardUsed));
			base.HandleOwnerEvent<DamageEventArgs>(base.Battle.Player.DamageReceived, new GameEventHandler<DamageEventArgs>(this.OnDamageReceived));
			base.HandleOwnerEvent<ChangeLifeEventArgs>(CustomGameEventManager.PostChangeLifeEvent, new GameEventHandler<ChangeLifeEventArgs>(this.OnLifeChanged));
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
			bool flag = this.go || base.Battle.BattleShouldEnd;
			if (!flag)
			{
				this.updatecounter();
			}
		}

		private void OnLifeChanged(ChangeLifeEventArgs args)
		{
			bool flag = this.go;
			if (!flag)
			{
				this.updatecounter();
			}
		}

		private void OnDamageReceived(DamageEventArgs args)
		{
			bool flag = this.go;
			if (!flag)
			{
				this.updatecounter();
			}
		}

		private IEnumerable<BattleAction> OnCardUsed(CardUsingEventArgs args)
		{
			this.go = base.Owner.Hp < this.lifeneed;
			bool flag = this.go;
			if (flag)
			{
				yield return new ApplyStatusEffectAction<Charging>(base.Battle.Player, new int?(base.Level), new int?(0), new int?(0), new int?(0), 0.2f, true);
			}
			this.go = false;
			this.updatecounter();
			yield break;
		}

		private bool go = false;

		private readonly List<ValueTuple<Card, CardUsingEventArgs>> AttackEchoArgs = new List<ValueTuple<Card, CardUsingEventArgs>>();
	}
}
