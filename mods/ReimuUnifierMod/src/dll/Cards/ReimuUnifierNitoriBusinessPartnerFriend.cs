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
using LBoLEntitySideloader.Attributes;
using ReimuUnifierMod.StatusEffects;

namespace ReimuUnifierMod.Cards
{
	[EntityLogic(typeof(ReimuUnifierNitoriBusinessPartnerFriendDef))]
	public sealed class ReimuUnifierNitoriBusinessPartnerFriend : Card
	{
		public string usedGun
		{
			get
			{
				return this.IsUpgraded ? base.Config.GunNameBurst : base.GunName;
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
			yield return new GainMoneyAction(10, SpecialSourceType.None);
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
						bool flag3 = unit is Nitori;
						if (flag3)
						{
							yield return PerformAction.Chat(base.Battle.Player, PC.LocShortcut("DialogueNitori1", true, true), 2.5f, 0f, 2.5f, true);
							yield return PerformAction.Chat(base.Battle.Player, PC.LocShortcut("DialogueNitori2", true, true), 2.5f, 0f, 2.5f, true);
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

		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			bool flag = precondition == null || ((MiniSelectCardInteraction)precondition).SelectedCard.FriendToken == FriendToken.Active;
			if (flag)
			{
				this.Loyalty += this.ActiveCost;
				bool flag2 = base.Battle.Player.HasStatusEffect<Weak>();
				if (flag2)
				{
					yield return new RemoveStatusEffectAction(base.Battle.Player.GetStatusEffect<Weak>(), true, 0.1f);
				}
				bool flag3 = base.Battle.Player.HasStatusEffect<Vulnerable>();
				if (flag3)
				{
					yield return new RemoveStatusEffectAction(base.Battle.Player.GetStatusEffect<Vulnerable>(), true, 0.1f);
				}
				bool isUpgraded = this.IsUpgraded;
				if (isUpgraded)
				{
					bool flag4 = base.Battle.Player.HasStatusEffect<Fragil>();
					if (flag4)
					{
						yield return new RemoveStatusEffectAction(base.Battle.Player.GetStatusEffect<Fragil>(), true, 0.1f);
					}
					bool flag5 = base.Battle.Player.HasStatusEffect<LockedOn>();
					if (flag5)
					{
						yield return new RemoveStatusEffectAction(base.Battle.Player.GetStatusEffect<LockedOn>(), true, 0.1f);
					}
				}
			}
			else
			{
				bool flag6 = ((MiniSelectCardInteraction)precondition).SelectedCard.FriendToken == FriendToken.Active2;
				if (flag6)
				{
					base.Loyalty += base.ActiveCost2;
					Guns guns = new Guns(base.GunName, base.Value1, true);
					foreach (GunPair gunPair in guns.GunPairs)
					{
						yield return base.AttackRandomAliveEnemyAction(gunPair);
						gunPair = null;
					}
					List<GunPair>.Enumerator enumerator = default(List<GunPair>.Enumerator);
					yield return new DrawCardAction();
					guns = null;
				}
				else
				{
					this.Loyalty += this.UltimateCost;
					this.UltimateUsed = true;
					yield return this.BuffAction<ReimuUnifierNitoriLochNessSe>(base.Value2, 0, 0, 0, 0.2f);
				}
			}
			yield break;
			yield break;
		}
	}
}
