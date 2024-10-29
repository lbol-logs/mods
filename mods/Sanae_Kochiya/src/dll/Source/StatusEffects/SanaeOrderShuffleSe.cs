using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoLEntitySideloader.Attributes;
using Sanae_Kochiya.Source.Cards.Rare;

namespace Sanae_Kochiya.Source.StatusEffects
{
	[EntityLogic(typeof(SanaeOrderShuffleSeDef))]
	public sealed class SanaeOrderShuffleSe : StatusEffect
	{
		public ManaGroup Mana
		{
			get
			{
				return new ManaGroup
				{
					Philosophy = 1
				};
			}
		}

		protected override void OnAdded(Unit unit)
		{
			GameRunController gameRun = base.GameRun;
			int num = gameRun.CanViewDrawZoneActualOrder + 1;
			gameRun.CanViewDrawZoneActualOrder = num;
			base.ReactOwnerEvent<CardUsingEventArgs>(base.Battle.CardUsed, new EventSequencedReactor<CardUsingEventArgs>(this.OnCardUsed));
			base.ReactOwnerEvent<GameEventArgs>(base.Battle.BattleEnding, new EventSequencedReactor<GameEventArgs>(this.OnBattleEnding));
		}

		private IEnumerable<BattleAction> OnCardUsed(CardUsingEventArgs args)
		{
			bool flag = args.Card.CardType != CardType.Skill && args.Card != Library.CreateCard(typeof(SanaeOrderShuffle));
			if (flag)
			{
				yield return new GainManaAction(this.Mana);
				yield return new ReshuffleAction();
			}
			yield break;
		}

		private IEnumerable<BattleAction> OnBattleEnding(GameEventArgs args)
		{
			bool isAlive = base.Battle.Player.IsAlive;
			if (isAlive)
			{
				GameRunController gameRun = base.GameRun;
				int num = gameRun.CanViewDrawZoneActualOrder - 1;
				gameRun.CanViewDrawZoneActualOrder = num;
				gameRun = null;
			}
			yield break;
		}
	}
}
