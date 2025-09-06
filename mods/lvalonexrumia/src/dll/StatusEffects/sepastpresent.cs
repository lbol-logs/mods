using System;
using System.Collections.Generic;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Cards;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoLEntitySideloader.Attributes;

namespace lvalonexrumia.StatusEffects
{
	[EntityLogic(typeof(sepastpresentDef))]
	public sealed class sepastpresent : StatusEffect
	{
		public override bool ForceNotShowDownText
		{
			get
			{
				return true;
			}
		}

		protected override void OnAdded(Unit unit)
		{
			this.go = false;
			base.HandleOwnerEvent<CardUsingEventArgs>(base.Battle.CardUsed, new GameEventHandler<CardUsingEventArgs>(this.OnCardUsed));
			base.ReactOwnerEvent<UnitEventArgs>(base.Battle.Player.TurnStarted, new EventSequencedReactor<UnitEventArgs>(this.OnTurnStarted));
			base.HandleOwnerEvent<UnitEventArgs>(base.Battle.Player.TurnEnded, new GameEventHandler<UnitEventArgs>(this.OnTurnEnded));
		}

		private void OnTurnEnded(UnitEventArgs args)
		{
			this.go = true;
		}

		private void OnCardUsed(CardUsingEventArgs args)
		{
			Card card = args.Card.CloneTwiceToken();
			card.IsPlayTwiceToken = true;
			card.PlayTwiceSourceCard = args.Card;
			this.AttackEchoArgs.Add(new ValueTuple<Card, CardUsingEventArgs>(card, args.Clone()));
		}

		private IEnumerable<BattleAction> OnTurnStarted(UnitEventArgs args)
		{
			bool flag = !this.go;
			if (flag)
			{
				yield break;
			}
			base.Highlight = true;
			foreach (ValueTuple<Card, CardUsingEventArgs> valueTuple in this.AttackEchoArgs)
			{
				Card card = valueTuple.Item1;
				CardUsingEventArgs aargs = valueTuple.Item2;
				bool battleShouldEnd = base.Battle.BattleShouldEnd;
				if (battleShouldEnd)
				{
					yield break;
				}
				base.NotifyActivating();
				yield return new PlayTwiceAction(card, aargs);
				card = null;
				aargs = null;
			}
			List<ValueTuple<Card, CardUsingEventArgs>>.Enumerator enumerator = default(List<ValueTuple<Card, CardUsingEventArgs>>.Enumerator);
			this.AttackEchoArgs.Clear();
			yield return new RemoveStatusEffectAction(this, true, 0.1f);
			yield break;
			yield break;
		}

		private bool go = false;

		private readonly List<ValueTuple<Card, CardUsingEventArgs>> AttackEchoArgs = new List<ValueTuple<Card, CardUsingEventArgs>>();
	}
}
