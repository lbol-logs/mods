using System;
using System.Collections.Generic;
using System.Linq;
using LBoL.Base;
using LBoL.Base.Extensions;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Cards;
using LBoL.Core.Units;
using LBoL.EntityLib.Cards.Character.Sakuya;
using LBoLEntitySideloader.Attributes;

namespace Momiji.Source
{
	[EntityLogic(typeof(TrainingRecordDef))]
	public sealed class TrainingRecord : SampleCharacterCard
	{
		private bool Active
		{
			get
			{
				bool flag = base.Battle != null;
				bool flag2;
				if (flag)
				{
					flag2 = !base.Battle.BattleCardUsageHistory.Any((Card card) => card is TimeWalk);
				}
				else
				{
					flag2 = true;
				}
				return flag2;
			}
		}

		private static bool CheckForCardTypeAndIntention(Card card, int intention)
		{
			bool flag = card.CardType == CardType.Attack && (intention == 1 || intention == 3 || intention == 5 || intention == 7);
			bool flag2;
			if (flag)
			{
				flag2 = true;
			}
			else
			{
				bool flag3 = card.CardType == CardType.Defense && (intention == 2 || intention == 3 || intention == 6 || intention == 7);
				if (flag3)
				{
					flag2 = true;
				}
				else
				{
					bool flag4 = (card.CardType == CardType.Ability || card.CardType == CardType.Skill) && intention >= 4;
					flag2 = flag4;
				}
			}
			return flag2;
		}

		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			bool active = this.Active;
			if (active)
			{
				TrainingRecord.<>c__DisplayClass4_0 CS$<>8__locals1 = new TrainingRecord.<>c__DisplayClass4_0();
				Card cardToUpgrade = null;
				EnemyUnit selectedEnemy = selector.SelectedEnemy;
				this.intention = base.IntentionCheck(selectedEnemy);
				IEnumerable<Card> eligibleCards = from c in base.GameRun.BaseDeck
					where c.CanUpgradeAndPositive
					where TrainingRecord.CheckForCardTypeAndIntention(c, this.intention)
					select c;
				bool flag = eligibleCards.Count<Card>() > 0;
				if (flag)
				{
					cardToUpgrade = eligibleCards.Sample(base.GameRun.GameRunEventRng);
				}
				CS$<>8__locals1.cardInDeckToUpgrade = cardToUpgrade;
				bool flag2 = CS$<>8__locals1.cardInDeckToUpgrade != null;
				if (flag2)
				{
					base.GameRun.UpgradeDeckCard(CS$<>8__locals1.cardInDeckToUpgrade, false);
				}
				Card cardInBattleToUpgrade = (from c in base.Battle.EnumerateAllCards()
					where c.CanUpgrade && c.InstanceId == CS$<>8__locals1.cardInDeckToUpgrade.InstanceId
					select c).FirstOrDefault<Card>();
				bool flag3 = cardInBattleToUpgrade != null;
				if (flag3)
				{
					yield return new UpgradeCardAction(cardInBattleToUpgrade);
				}
				CS$<>8__locals1 = null;
				cardToUpgrade = null;
				selectedEnemy = null;
				eligibleCards = null;
				cardInBattleToUpgrade = null;
			}
			yield return base.AttackAction(selector, base.GunName);
			yield break;
		}

		private int intention = 0;
	}
}
