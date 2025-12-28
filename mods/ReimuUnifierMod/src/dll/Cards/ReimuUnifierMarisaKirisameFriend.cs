using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Base.Extensions;
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
using ReimuUnifierMod.StatusEffects;

namespace ReimuUnifierMod.Cards
{
	[EntityLogic(typeof(ReimuUnifierMarisaKirisameFriendDef))]
	public sealed class ReimuUnifierMarisaKirisameFriend : Card
	{
		public Unit target
		{
			get
			{
				bool flag = base.Battle != null;
				Unit unit2;
				if (flag)
				{
					bool battleShouldEnd = base.Battle.BattleShouldEnd;
					if (battleShouldEnd)
					{
						unit2 = null;
					}
					else
					{
						unit2 = base.Battle.EnemyGroup.Alives.MinBy((EnemyUnit unit) => unit.Hp);
					}
				}
				else
				{
					unit2 = null;
				}
				return unit2;
			}
		}

		public string ActiveDamagePreview
		{
			get
			{
				bool flag = base.Battle != null;
				string text;
				if (flag)
				{
					bool flag2 = this.target != null;
					if (flag2)
					{
						int num = base.Battle.CalculateDamage(this, base.Battle.Player, this.target, new DamageInfo((float)base.Value1, DamageType.Attack, false, false, false));
						bool flag3 = this.target == null;
						if (flag3)
						{
							text = 0.ToString();
						}
						else
						{
							string colorFromDamage = ReimuUnifierCard.GetColorFromDamage((float)num, (float)base.Value1);
							text = string.Format("<color=#{0}>{1}</color>", colorFromDamage, num);
						}
					}
					else
					{
						text = string.Format("<color=#B2FFFF>{0}</color>", base.Value1);
					}
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
					EnemyUnit target = this.Battle.EnemyGroup.Alives.MinBy((EnemyUnit unit) => unit.Hp);
					yield return this.AttackAction(target, this.Damage, base.GunName);
					bool flag2 = !base.Battle.BattleShouldEnd;
					if (flag2)
					{
						yield return base.BuffAction<ReimuUnifierDelayedChargingSe>(1, 0, 0, 0, 0.2f);
					}
					target = null;
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
				EnemyUnit target = this.Battle.EnemyGroup.Alives.MinBy((EnemyUnit unit) => unit.Hp);
				bool isUpgraded = this.IsUpgraded;
				if (isUpgraded)
				{
					this.CardGuns = new Guns("火激光", 2, true);
					foreach (GunPair gunPair in this.CardGuns.GunPairs)
					{
						yield return this.AttackAction(target, DamageInfo.Attack((float)this.Value1, false), gunPair.GunName);
						gunPair = null;
					}
					List<GunPair>.Enumerator enumerator = default(List<GunPair>.Enumerator);
				}
				else
				{
					yield return this.AttackAction(target, DamageInfo.Attack((float)this.Value1, false), "火激光");
				}
				bool flag2 = !base.Battle.BattleShouldEnd;
				if (flag2)
				{
					yield return this.DebuffAction<Vulnerable>(target, 0, 1, 0, 0, true, 0.2f);
					yield return base.BuffAction<Charging>(2, 0, 0, 0, 0.2f);
				}
				target = null;
			}
			else
			{
				this.Loyalty += this.UltimateCost;
				this.UltimateUsed = true;
				yield return this.AttackAction(base.Battle.AllAliveEnemies, "究极火花", DamageInfo.Attack((float)this.Value2, true));
			}
			yield break;
			yield break;
		}
	}
}
