using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Battle.Interactions;
using LBoL.Core.Cards;
using LBoLEntitySideloader.Attributes;
using ReimuUnifierMod.StatusEffects;

namespace ReimuUnifierMod.Cards
{
	[EntityLogic(typeof(ReimuUnifierYukariSageOfGensokyoFriendDef))]
	public sealed class ReimuUnifierYukariSageOfGensokyoFriend : Card
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
					yield return new CastBlockShieldAction(base.Battle.Player, base.Value2, 0, BlockShieldType.Direct, false);
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
				int block = base.Battle.Player.Block;
				bool flag2 = block > 0;
				if (flag2)
				{
					yield return new LoseBlockShieldAction(base.Battle.Player, block, 0, false);
					yield return new CastBlockShieldAction(base.Battle.Player, 0, block, BlockShieldType.Direct, false);
				}
				yield return new CastBlockShieldAction(base.Battle.Player, 0, base.Battle.Player.Shield, BlockShieldType.Direct, true);
			}
			else
			{
				this.Loyalty += this.UltimateCost;
				this.UltimateUsed = true;
				yield return base.BuffAction<ReimuUnifierYukariArcanumSe>(base.Value1, 0, 0, 5, 0.2f);
			}
			yield break;
		}
	}
}
