using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Cards;
using LBoL.EntityLib.StatusEffects.Sakuya;
using LBoLEntitySideloader.Attributes;
using YoumuCharacterMod.Cards.Template;

namespace YoumuCharacterMod.Cards
{
	[EntityLogic(typeof(YoumuEmbercleaveDef))]
	public sealed class YoumuEmbercleave : YoumuCard
	{
		protected override void OnEnterBattle(BattleController battle)
		{
			base.ReactBattleEvent<CardUsingEventArgs>(base.Battle.CardUsed, new EventSequencedReactor<CardUsingEventArgs>(this.OnCardUsed));
		}

		private IEnumerable<BattleAction> OnCardUsed(CardUsingEventArgs args)
		{
			bool flag = base.Zone == CardZone.Hand && args.Card.CardType == CardType.Attack && !base.Battle.BattleShouldEnd;
			if (flag)
			{
				base.DecreaseBaseCost(base.Mana);
			}
			yield break;
		}

		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			bool flag = base.Value1 > 0 && !base.Battle.BattleShouldEnd;
			if (flag)
			{
				yield return base.BuffAction<EvilMaidDoubleAttack>(0, base.Value1, 0, 0, 0.2f);
			}
			yield break;
		}
	}
}
