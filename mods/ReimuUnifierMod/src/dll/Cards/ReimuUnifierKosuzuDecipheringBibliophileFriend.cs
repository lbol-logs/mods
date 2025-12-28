using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Battle.Interactions;
using LBoL.Core.Cards;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoLEntitySideloader.Attributes;

namespace ReimuUnifierMod.Cards
{
	[EntityLogic(typeof(ReimuUnifierKosuzuDecipheringBibliophileFriendDef))]
	public sealed class ReimuUnifierKosuzuDecipheringBibliophileFriend : Card
	{
		public string Indent { get; } = "<indent=80>";

		public string PassiveCostIcon
		{
			get
			{
				return string.Format("<indent=0><sprite=\"Passive\" name=\"{0}\">{1}", base.PassiveCost, this.Indent);
			}
		}

		public string ActiveCostIcon
		{
			get
			{
				return string.Format("<indent=0><sprite=\"Active\" name=\"{0}\">{1}", base.ActiveCost, this.Indent);
			}
		}

		public string UltimateCostIcon
		{
			get
			{
				return string.Format("<indent=0><sprite=\"Ultimate\" name=\"{0}\">{1}", base.UltimateCost, this.Indent);
			}
		}

		public override IEnumerable<BattleAction> OnTurnStartedInHand()
		{
			return this.GetPassiveActions();
		}

		public override IEnumerable<BattleAction> GetPassiveActions()
		{
			bool flag = this.Summoned && !this.Battle.BattleShouldEnd;
			if (flag)
			{
				this.NotifyActivating();
				this.Loyalty += this.PassiveCost;
				int i = 0;
				while (i < this.Battle.FriendPassiveTimes && !this.Battle.BattleShouldEnd)
				{
					yield return PerformAction.Sfx("FairySupport", 0f);
					foreach (Unit enemy in base.Battle.AllAliveEnemies)
					{
						yield return base.DebuffAction<LockedOn>(enemy, base.Value1, 0, 0, 0, true, 0.2f);
						enemy = null;
					}
					IEnumerator<EnemyUnit> enumerator = null;
					int num = i + 1;
					i = num;
				}
			}
			yield break;
			yield break;
		}

		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			bool flag = precondition == null || ((MiniSelectCardInteraction)precondition).SelectedCard.FriendToken == FriendToken.Active;
			if (flag)
			{
				this.Loyalty += this.ActiveCost;
				foreach (Unit enemy in base.Battle.AllAliveEnemies)
				{
					yield return base.DebuffAction<LockedOn>(enemy, base.Value2, 0, 0, 0, true, 0.2f);
					yield return base.DebuffAction<Vulnerable>(enemy, 0, 1, 0, 0, true, 0.2f);
					enemy = null;
				}
				IEnumerator<EnemyUnit> enumerator = null;
			}
			else
			{
				this.Loyalty += this.UltimateCost;
				this.UltimateUsed = true;
				foreach (Unit enemy2 in base.Battle.AllAliveEnemies)
				{
					bool flag2 = enemy2.HasStatusEffect<Graze>();
					if (flag2)
					{
						yield return new RemoveStatusEffectAction(enemy2.GetStatusEffect<Graze>(), true, 0.1f);
					}
					bool flag3 = enemy2.HasStatusEffect<Invincible>();
					if (flag3)
					{
						yield return new RemoveStatusEffectAction(enemy2.GetStatusEffect<Invincible>(), true, 0.1f);
					}
					bool flag4 = enemy2.HasStatusEffect<InvincibleEternal>();
					if (flag4)
					{
						yield return new RemoveStatusEffectAction(enemy2.GetStatusEffect<InvincibleEternal>(), true, 0.1f);
					}
					bool flag5 = enemy2.HasStatusEffect<GuangxueMicai>();
					if (flag5)
					{
						yield return new RemoveStatusEffectAction(enemy2.GetStatusEffect<GuangxueMicai>(), true, 0.1f);
					}
					yield return base.DebuffAction<Vulnerable>(enemy2, 0, 1, 0, 0, true, 0.2f);
					enemy2 = null;
				}
				IEnumerator<EnemyUnit> enumerator2 = null;
			}
			yield break;
			yield break;
		}
	}
}
