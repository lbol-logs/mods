using System;
using System.Collections.Generic;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Cards;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoLEntitySideloader.Attributes;
using lvalonexrumia.Cards;

namespace lvalonexrumia.StatusEffects
{
	[EntityLogic(typeof(semixedbloodDef))]
	public sealed class semixedblood : StatusEffect
	{
		protected override void OnAdded(Unit unit)
		{
			base.ReactOwnerEvent<CardUsingEventArgs>(base.Battle.CardUsed, new EventSequencedReactor<CardUsingEventArgs>(this.OnCardUsed));
			base.ReactOwnerEvent<UnitEventArgs>(base.Battle.Player.TurnEnded, new EventSequencedReactor<UnitEventArgs>(this.OnTurnEnded));
		}

		private IEnumerable<BattleAction> OnTurnEnded(UnitEventArgs args)
		{
			yield return new RemoveStatusEffectAction(this, true, 0.1f);
			yield break;
		}

		private IEnumerable<BattleAction> OnCardUsed(CardUsingEventArgs args)
		{
			bool flag = args.Card is carddarkblood;
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
			bool flag2 = args.ActionSource != this && args.Card is cardredblood;
			if (flag2)
			{
				base.NotifyActivating();
				yield return new ApplyStatusEffectAction<sedarkblood>(base.Battle.Player, new int?(base.Level), new int?(0), new int?(0), new int?(0), 0.2f, true);
			}
			this.AttackEchoArgs.Clear();
			yield break;
			yield break;
		}

		private readonly List<ValueTuple<Card, CardUsingEventArgs>> AttackEchoArgs = new List<ValueTuple<Card, CardUsingEventArgs>>();
	}
}
