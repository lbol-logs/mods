using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Cards;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoLEntitySideloader.Attributes;
using ReimuUnifierMod.Cards.Template;
using ReimuUnifierMod.StatusEffects;

namespace ReimuUnifierMod.Cards
{
	[EntityLogic(typeof(ReimuUnifierYoukaiForgedNeedleDef))]
	public sealed class ReimuUnifierYoukaiForgedNeedle : ReimuUnifierCard
	{
		protected override void OnEnterBattle(BattleController battle)
		{
			base.HandleBattleEvent<UnitEventArgs>(base.Battle.Player.TurnStarted, new GameEventHandler<UnitEventArgs>(this.OnPlayerTurnStarted), (GameEventPriority)0);
			base.HandleBattleEvent<CardUsingEventArgs>(base.Battle.CardUsed, new GameEventHandler<CardUsingEventArgs>(this.OnCardUsed), (GameEventPriority)0);
			foreach (Card card in base.Battle.TurnCardUsageHistory)
			{
				bool flag = card.CardType == CardType.Friend && !card.Summoning;
				if (flag)
				{
					base.SetTurnCost(ManaGroup.Empty);
				}
			}
		}

		private void OnPlayerTurnStarted(UnitEventArgs args)
		{
			bool flag = base.Zone == CardZone.Hand;
			if (flag)
			{
				this.NotifyChanged();
			}
			base.SetTurnCost(base.BaseCost);
		}

		private void OnCardUsed(CardUsingEventArgs args)
		{
			bool battleShouldEnd = base.Battle.BattleShouldEnd;
			if (!battleShouldEnd)
			{
				Card card = args.Card;
				bool flag = card.CardType == CardType.Friend && !card.Summoning;
				if (flag)
				{
					base.NotifyActivating();
					base.SetTurnCost(ManaGroup.Empty);
				}
			}
		}

		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			bool flag = base.Battle.Player.HasStatusEffect<ReimuUnifierNeedleSparkSealSe>();
			if (flag)
			{
				bool isUpgraded = this.IsUpgraded;
				if (isUpgraded)
				{
					yield return base.AttackAllAliveEnemyAction(null);
					foreach (EnemyUnit enemy in base.Battle.AllAliveEnemies)
					{
						yield return base.DebuffAction<LockedOn>(enemy, 2, 0, 0, 0, true, 0.2f);
						yield return base.DebuffAction<LockedOn>(enemy, base.Value1, 0, 0, 0, true, 0.2f);
						enemy = null;
					}
					IEnumerator<EnemyUnit> enumerator = null;
					yield break;
				}
				yield return base.AttackAllAliveEnemyAction(null);
				foreach (EnemyUnit enemy2 in base.Battle.AllAliveEnemies)
				{
					yield return base.DebuffAction<LockedOn>(enemy2, 2, 0, 0, 0, true, 0.2f);
					enemy2 = null;
				}
				IEnumerator<EnemyUnit> enumerator2 = null;
				yield break;
			}
			else
			{
				bool isUpgraded2 = this.IsUpgraded;
				if (isUpgraded2)
				{
					yield return base.AttackAction(selector, base.GunName);
					yield return base.DebuffAction<LockedOn>(selector.SelectedEnemy, base.Value1, 0, 0, 0, true, 0.2f);
					yield break;
				}
				yield return base.AttackAction(selector, base.GunName);
				yield break;
			}
			yield break;
		}
	}
}
