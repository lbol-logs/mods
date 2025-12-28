using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Base.Extensions;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Battle.Interactions;
using LBoL.Core.Cards;
using LBoL.Core.Units;
using LBoL.EntityLib.EnemyUnits.Character;
using LBoLEntitySideloader.Attributes;
using ReimuUnifierMod.StatusEffects;

namespace ReimuUnifierMod.Cards
{
	[EntityLogic(typeof(ReimuUnifierSumirekoDreamVisitorFriendDef))]
	public sealed class ReimuUnifierSumirekoDreamVisitorFriend : Card
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

		protected override IEnumerable<BattleAction> SummonActions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			foreach (BattleAction battleAction in base.SummonActions(selector, consumingMana, precondition))
			{
				yield return battleAction;
				battleAction = null;
			}
			IEnumerator<BattleAction> enumerator = null;
			foreach (EnemyUnit unit in base.Battle.AllAliveEnemies)
			{
				PlayerUnit player = base.Battle.Player;
				ReimuUnifierModDef.ReimuUnifierMod PC = player as ReimuUnifierModDef.ReimuUnifierMod;
				bool flag = PC != null;
				if (flag)
				{
					bool flag2 = !PC.DialogueTriggered;
					if (flag2)
					{
						bool flag3 = unit is Doremy;
						if (flag3)
						{
							yield return PerformAction.Chat(base.Battle.Player, PC.LocShortcut("DialogueSumireko", true, true), 2.5f, 0f, 2.5f, true);
							PC.DialogueTriggered = true;
						}
					}
				}
				PC = null;
				unit = null;
			}
			IEnumerator<EnemyUnit> enumerator2 = null;
			yield break;
			yield break;
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
					yield return base.BuffAction<ReimuUnifierOccultBallSe>(0, 0, 0, 1, 0.2f);
					int num = i + 1;
					i = num;
				}
			}
			yield break;
		}

		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			int OccultBalls = 0;
			bool flag = base.Battle.Player.HasStatusEffect<ReimuUnifierOccultBallSe>();
			if (flag)
			{
				OccultBalls = base.Battle.Player.GetStatusEffect<ReimuUnifierOccultBallSe>().Count;
			}
			bool flag2 = precondition == null || ((MiniSelectCardInteraction)precondition).SelectedCard.FriendToken == FriendToken.Active;
			if (flag2)
			{
				this.Loyalty += this.ActiveCost;
				Unit target = base.Battle.EnemyGroup.Alives.MinBy((EnemyUnit unit) => unit.Hp);
				yield return base.AttackAction(target, DamageInfo.Attack(this.Damage.Damage * (float)OccultBalls, false), "追查真凶1");
				target = null;
			}
			else
			{
				bool flag3 = ((MiniSelectCardInteraction)precondition).SelectedCard.FriendToken == FriendToken.Active2;
				if (flag3)
				{
					base.Loyalty += base.ActiveCost2;
					bool flag4 = OccultBalls > 0;
					if (flag4)
					{
						yield return base.LoseLifeAction(OccultBalls);
						yield return new GainManaAction(ManaGroup.Blacks(OccultBalls));
						yield return new DrawManyCardAction(OccultBalls);
					}
					yield break;
				}
				this.Loyalty += this.UltimateCost;
				this.UltimateUsed = true;
				bool flag5 = OccultBalls >= 9;
				if (flag5)
				{
					bool isUpgraded = this.IsUpgraded;
					if (isUpgraded)
					{
						int cardsToDraw = base.Battle.MaxHand - base.Battle.HandZone.Count;
						yield return new DrawManyCardAction(cardsToDraw);
					}
					yield return this.BuffAction<ReimuUnifierSumirekoDoppelgangerSe>(0, 0, 0, 0, 0.2f);
					yield return new RemoveStatusEffectAction(base.Battle.Player.GetStatusEffect<ReimuUnifierOccultBallSe>(), true, 0.1f);
				}
			}
			yield break;
		}
	}
}
