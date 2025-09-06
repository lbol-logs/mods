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
using lvalonexrumia.Cards;
using lvalonexrumia.Patches;

namespace lvalonexrumia.StatusEffects
{
	[EntityLogic(typeof(setwilight2Def))]
	public sealed class setwilight2 : StatusEffect
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
					num = toolbox.hpfrompercent(Singleton<GameMaster>.Instance.CurrentGameRun.Player, 25, true);
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
			this.between = true;
			this.go = true;
			this.updatecounter();
			base.ReactOwnerEvent<CardUsingEventArgs>(base.Battle.CardUsed, new EventSequencedReactor<CardUsingEventArgs>(this.OnCardUsed));
			base.HandleOwnerEvent<DamageEventArgs>(base.Battle.Player.DamageReceived, new GameEventHandler<DamageEventArgs>(this.OnDamageReceived));
			base.HandleOwnerEvent<ChangeLifeEventArgs>(CustomGameEventManager.PostChangeLifeEvent, new GameEventHandler<ChangeLifeEventArgs>(this.OnLifeChanged));
			base.HandleOwnerEvent<ChangeLifeEventArgs>(CustomGameEventManager.PreChangeLifeEvent, new GameEventHandler<ChangeLifeEventArgs>(this.OnLifeChanging));
			base.HandleOwnerEvent<HealEventArgs>(base.Battle.Player.HealingReceived, new GameEventHandler<HealEventArgs>(this.OnHealingReceived));
			base.ReactOwnerEvent<GameEventArgs>(base.Battle.BattleEnded, new EventSequencedReactor<GameEventArgs>(this.OnBattleEnded), (GameEventPriority)0);
		}

		private IEnumerable<BattleAction> OnBattleEnded(GameEventArgs args)
		{
			yield return new RemoveStatusEffectAction(this, true, 0.1f);
			yield break;
		}

		private void OnLifeChanging(ChangeLifeEventArgs args)
		{
			bool flag = args.Cause == ActionCause.Card && !this.between;
			if (flag)
			{
				Card card = args.ActionSource as Card;
				bool flag2 = card is cardredblood;
				if (flag2)
				{
					args.CancelBy(this);
				}
			}
		}

		private void OnHealingReceived(HealEventArgs args)
		{
			bool flag = !this.go || base.Battle.BattleShouldEnd;
			if (!flag)
			{
				this.updatecounter();
			}
		}

		private void OnLifeChanged(ChangeLifeEventArgs args)
		{
			bool flag = !this.go;
			if (!flag)
			{
				this.updatecounter();
			}
		}

		private void OnDamageReceived(DamageEventArgs args)
		{
			bool flag = !this.go;
			if (!flag)
			{
				this.updatecounter();
			}
		}

		private IEnumerable<BattleAction> OnCardUsed(CardUsingEventArgs args)
		{
			this.go = false;
			bool flag = base.Owner.Hp < this.lifeneed;
			if (flag)
			{
				int num;
				for (int i = 0; i < base.Level; i = num + 1)
				{
					Card token = Library.CreateCard<cardredblood>();
					token.IsPlayTwiceToken = true;
					token.PlayTwiceSourceCard = args.Card;
					this.AttackEchoArgs.Add(new ValueTuple<Card, CardUsingEventArgs>(token, args.Clone()));
					token = null;
					num = i;
				}
			}
			this.between = false;
			foreach (ValueTuple<Card, CardUsingEventArgs> valueTuple in this.AttackEchoArgs)
			{
				Card card = valueTuple.Item1;
				CardUsingEventArgs aargs = valueTuple.Item2;
				base.NotifyActivating();
				yield return new PlayTwiceAction(card, aargs);
				card = null;
				aargs = null;
			}
			List<ValueTuple<Card, CardUsingEventArgs>>.Enumerator enumerator = default(List<ValueTuple<Card, CardUsingEventArgs>>.Enumerator);
			this.AttackEchoArgs.Clear();
			this.go = true;
			this.between = true;
			this.updatecounter();
			yield break;
			yield break;
		}

		private bool between = true;

		private bool go = true;

		private readonly List<ValueTuple<Card, CardUsingEventArgs>> AttackEchoArgs = new List<ValueTuple<Card, CardUsingEventArgs>>();
	}
}
