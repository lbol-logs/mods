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
using LBoL.EntityLib.EnemyUnits.Character;
using LBoL.EntityLib.EnemyUnits.Opponent;
using LBoLEntitySideloader.Attributes;
using ReimuUnifierMod.Cards.Template;

namespace ReimuUnifierMod.Cards
{
	[EntityLogic(typeof(ReimuUnifierMarisaIncidentSolverFriendDef))]
	public sealed class ReimuUnifierMarisaIncidentSolverFriend : Card
	{
		public string ActiveDamagePreview
		{
			get
			{
				bool flag = base.Battle != null;
				string text;
				if (flag)
				{
					float num = (float)base.Battle.CalculateDamage(base.Battle.Player, base.Battle.Player, null, new DamageInfo((float)base.Value1, DamageType.Attack, false, false, false));
					string colorFromDamage = ReimuUnifierCard.GetColorFromDamage(num, (float)base.Value1);
					text = string.Format("<color=#{0}>{1}</color>", colorFromDamage, num);
				}
				else
				{
					text = string.Format("<color=#B2FFFF>{0}</color>", base.Value1);
				}
				return text;
			}
		}

		public string UltimateDamagePreview
		{
			get
			{
				bool flag = base.Battle != null;
				string text;
				if (flag)
				{
					float num = (float)base.Battle.CalculateDamage(base.Battle.Player, base.Battle.Player, null, new DamageInfo((float)base.Value2, DamageType.Attack, false, false, false));
					string colorFromDamage = ReimuUnifierCard.GetColorFromDamage(num, (float)base.Value2);
					text = string.Format("<color=#{0}>{1}</color>", colorFromDamage, num);
				}
				else
				{
					text = string.Format("<color=#B2FFFF>{0}</color>", base.Value2);
				}
				return text;
			}
		}

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
						bool flag3 = unit is Marisa;
						if (flag3)
						{
							yield return PerformAction.Chat(base.Battle.Player, PC.LocShortcut("DialogueMarisa1", true, true), 2.5f, 0f, 2.5f, true);
							PC.DialogueTriggered = true;
						}
						else
						{
							bool flag4 = unit is Sakuya;
							if (flag4)
							{
								yield return PerformAction.Chat(unit, PC.LocShortcut("DialogueMarisa21", true, true), 2.5f, 0f, 2.5f, true);
								yield return PerformAction.Chat(base.Battle.Player, PC.LocShortcut("DialogueMarisa22", true, true), 2.5f, 0f, 2.5f, true);
								yield return PerformAction.Chat(unit, PC.LocShortcut("DialogueMarisa23", true, true), 2.5f, 0f, 2.5f, true);
								PC.DialogueTriggered = true;
							}
							else
							{
								bool flag5 = unit is Siji;
								if (flag5)
								{
									yield return PerformAction.Chat(base.Battle.Player, PC.LocShortcut("DialogueMarisa31", true, true), 2.5f, 0f, 2.5f, true);
									yield return PerformAction.Chat(unit, PC.LocShortcut("DialogueMarisa32", true, true), 2.5f, 0f, 2.5f, true);
									PC.DialogueTriggered = true;
								}
							}
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
					yield return base.AttackAllAliveEnemyAction(null);
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
				yield return this.AttackAction(base.Battle.AllAliveEnemies, "究极火花", DamageInfo.Attack((float)this.Value1, true));
			}
			else
			{
				this.Loyalty += this.UltimateCost;
				this.UltimateUsed = true;
				yield return base.BuffAction<Burst>(0, 0, 0, 0, 0.2f);
				yield return this.AttackAction(base.Battle.AllAliveEnemies, "究极火花B", DamageInfo.Attack((float)this.Value2, true));
			}
			yield break;
		}
	}
}
