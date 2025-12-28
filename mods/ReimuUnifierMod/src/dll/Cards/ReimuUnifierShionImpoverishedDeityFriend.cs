using System;
using System.Collections.Generic;
using System.Linq;
using LBoL.Base;
using LBoL.Base.Extensions;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Battle.Interactions;
using LBoL.Core.Cards;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoL.EntityLib.Cards.Misfortune;
using LBoL.EntityLib.EnemyUnits.Character;
using LBoLEntitySideloader.Attributes;

namespace ReimuUnifierMod.Cards
{
	[EntityLogic(typeof(ReimuUnifierShionImpoverishedDeityFriendDef))]
	public sealed class ReimuUnifierShionImpoverishedDeityFriend : Card
	{
		public string Indent { get; } = "<indent=80>";

		public float ActiveDamagePreview
		{
			get
			{
				return DamageInfo.Attack(15f, true).Amount;
			}
		}

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
			yield return new GainMoneyAction(15, SpecialSourceType.None);
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
						bool flag3 = unit is Tianzi;
						if (flag3)
						{
							yield return PerformAction.Chat(base.Battle.Player, PC.LocShortcut("DialogueShion1", true, true), 2.5f, 0f, 2.5f, true);
							yield return PerformAction.Chat(unit, PC.LocShortcut("DialogueShion2", true, true), 2.5f, 0f, 2.5f, true);
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

		public override IEnumerable<BattleAction> OnTurnEndingInHand()
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
					EnemyUnit target = this.Battle.EnemyGroup.Alives.MinBy((EnemyUnit unit) => unit.Hp);
					yield return new LoseMoneyAction(5);
					DamageInfo AccurateAttack = this.Damage;
					AccurateAttack.IsAccuracy = true;
					yield return base.AttackAction(target, AccurateAttack, base.GunName);
					bool isAlive = target.IsAlive;
					if (isAlive)
					{
						yield return base.AttackAction(target, AccurateAttack, base.GunName);
					}
					target = null;
					AccurateAttack = default(DamageInfo);
					int num = i + 1;
					i = num;
				}
			}
			yield break;
		}

		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			bool flag = precondition == null || ((MiniSelectCardInteraction)precondition).SelectedCard.FriendToken == FriendToken.Active;
			if (flag)
			{
				this.Loyalty += this.ActiveCost;
				int livingEnemies = base.Battle.AllAliveEnemies.Count<EnemyUnit>();
				yield return new LoseMoneyAction(5 * livingEnemies);
				yield return base.AttackAction(base.Battle.AllAliveEnemies, base.GunName, DamageInfo.Attack(15f, true));
				yield return base.BuffAction<Graze>(livingEnemies, 0, 0, 0, 0.2f);
			}
			else
			{
				this.Loyalty += this.UltimateCost;
				this.UltimateUsed = true;
				base.GameRun.AddDeckCard(Library.CreateCard<BuyPeace>(), true, null);
				foreach (EnemyUnit unit in base.Battle.AllAliveEnemies)
				{
					bool flag2 = !unit.Config.RealName;
					if (flag2)
					{
						yield return new ForceKillAction(base.Battle.Player, unit);
					}
					unit = null;
				}
				IEnumerator<EnemyUnit> enumerator = null;
			}
			yield break;
			yield break;
		}
	}
}
