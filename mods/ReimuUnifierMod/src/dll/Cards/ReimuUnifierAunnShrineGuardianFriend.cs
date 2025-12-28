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
using LBoL.EntityLib.EnemyUnits.Character;
using LBoL.EntityLib.EnemyUnits.Opponent;
using LBoL.EntityLib.StatusEffects.Basic;
using LBoL.EntityLib.StatusEffects.Others;
using LBoLEntitySideloader.Attributes;
using ReimuUnifierMod.StatusEffects;

namespace ReimuUnifierMod.Cards
{
	[EntityLogic(typeof(ReimuUnifierAunnShrineGuardianFriendDef))]
	public sealed class ReimuUnifierAunnShrineGuardianFriend : Card
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
						bool flag3 = unit is Reimu;
						if (flag3)
						{
							yield return PerformAction.Chat(base.Battle.Player, PC.LocShortcut("DialogueAunn1", true, true), 2.5f, 0f, 2.5f, true);
							PC.DialogueTriggered = true;
						}
						else
						{
							bool flag4 = unit is Sanae;
							if (flag4)
							{
								yield return PerformAction.Chat(base.Battle.Player, PC.LocShortcut("DialogueAunn2", true, true), 2.5f, 0f, 2.5f, true);
								PC.DialogueTriggered = true;
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
					List<Card> list = (from card in base.Battle.HandZone.Concat(base.Battle.DiscardZone).Concat(base.Battle.DrawZone)
						where card != this && card.CardType == CardType.Misfortune
						select card).ToList<Card>();
					bool flag2 = list.NotEmpty<Card>();
					if (flag2)
					{
						list.Shuffle(new RandomGen());
						yield return new ExileCardAction(list.First<Card>());
					}
					list = null;
					int num = i;
					i = num + 1;
				}
				bool flag3 = base.Loyalty <= 0;
				if (flag3)
				{
					yield return new RemoveCardAction(this);
				}
				yield break;
			}
			yield break;
		}

		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			bool flag = precondition == null || ((MiniSelectCardInteraction)precondition).SelectedCard.FriendToken == FriendToken.Active;
			if (flag)
			{
				base.Loyalty += base.ActiveCost;
				yield return new CastBlockShieldAction(base.Battle.Player, this.Block, base.Shield, false);
				yield return base.BuffAction<Graze>(base.Value1, 0, 0, 0, 0.2f);
				yield return base.BuffAction<Amulet>(base.Value1, 0, 0, 0, 0.2f);
				yield return base.BuffAction<AmuletForCard>(base.Value1, 0, 0, 0, 0.2f);
				yield return base.BuffAction<TempSpirit>(base.Value1, 0, 0, 0, 0.2f);
			}
			else
			{
				base.Loyalty += base.UltimateCost;
				this.UltimateUsed = true;
				yield return base.DebuffAction<Fengyin>(base.Battle.Player, 0, 2, 0, 0, true, 0.2f);
				yield return base.BuffAction<ReimuUnifierAunnProtectionSe>(base.Value2, 0, 0, 0, 0.2f);
			}
			yield break;
		}
	}
}
