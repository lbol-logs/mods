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
using LBoLEntitySideloader.Attributes;

namespace ReimuUnifierMod.Cards
{
	[EntityLogic(typeof(ReimuUnifierKasenWildhornFriendDef))]
	public sealed class ReimuUnifierKasenWildhornFriend : Card
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
						bool flag3 = unit is Tianzi;
						if (flag3)
						{
							yield return PerformAction.Chat(base.Battle.Player, PC.LocShortcut("DialogueKasen1", true, true), 2.5f, 0f, 2.5f, true);
							yield return PerformAction.Chat(unit, PC.LocShortcut("DialogueKasen2", true, true), 2.5f, 0f, 2.5f, true);
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
					this.CardGuns = new Guns(base.GunName, base.Value1, true);
					foreach (GunPair gunPair in this.CardGuns.GunPairs)
					{
						bool flag2 = !base.Battle.BattleShouldEnd;
						if (flag2)
						{
							EnemyUnit target = this.Battle.EnemyGroup.Alives.MinBy((EnemyUnit unit) => unit.Hp);
							yield return this.AttackAction(target, this.Damage, gunPair.GunName);
							target = null;
						}
						gunPair = null;
					}
					List<GunPair>.Enumerator enumerator = default(List<GunPair>.Enumerator);
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
				yield return this.BuffAction<Firepower>(2, 0, 0, 0, 0.2f);
				yield return this.BuffAction<Spirit>(2, 0, 0, 0, 0.2f);
				bool isUpgraded = this.IsUpgraded;
				if (isUpgraded)
				{
					yield return this.BuffAction<Graze>(2, 0, 0, 0, 0.2f);
				}
			}
			else
			{
				this.Loyalty += this.UltimateCost;
				this.UltimateUsed = true;
				int CardsToAdd = base.Battle.MaxHand - base.Battle.HandZone.Count;
				List<Card> AvailableAttacks = (from card in base.Battle.DrawZone.Concat(base.Battle.DiscardZone)
					where card.CardType == CardType.Attack
					select card).ToList<Card>();
				AvailableAttacks.Shuffle(new RandomGen());
				int i = 0;
				while (i < CardsToAdd && i < AvailableAttacks.Count)
				{
					yield return new MoveCardAction(AvailableAttacks.ToArray()[i], CardZone.Hand);
					AvailableAttacks.ToArray()[i].SetTurnCost(new ManaGroup
					{
						Any = 0
					});
					int num = i;
					i = num + 1;
				}
				AvailableAttacks = null;
			}
			yield break;
		}
	}
}
