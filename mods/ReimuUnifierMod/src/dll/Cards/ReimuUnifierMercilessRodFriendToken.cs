using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Base.Extensions;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Cards;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoLEntitySideloader.Attributes;
using ReimuUnifierMod.Cards.Template;

namespace ReimuUnifierMod.Cards
{
	[EntityLogic(typeof(ReimuUnifierMercilessRodFriendTokenDef))]
	public sealed class ReimuUnifierMercilessRodFriendToken : ReimuUnifierCard
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

		protected override void OnEnterBattle(BattleController battle)
		{
			base.ReactBattleEvent<CardUsingEventArgs>(base.Battle.CardUsed, new EventSequencedReactor<CardUsingEventArgs>(this.OnCardUsed));
		}

		private IEnumerable<BattleAction> OnCardUsed(CardUsingEventArgs args)
		{
			bool battleShouldEnd = base.Battle.BattleShouldEnd;
			if (battleShouldEnd)
			{
				yield break;
			}
			Card card = args.Card;
			bool flag = card.Config.Rarity == Rarity.Common && base.Summoned;
			if (flag)
			{
				base.NotifyActivating();
				yield return base.BuffAction<Firepower>(base.Value1, 0, 0, 0, 0.2f);
				bool isUpgraded = this.IsUpgraded;
				if (isUpgraded)
				{
					yield return base.BuffAction<TempFirepower>(base.Value1, 0, 0, 0, 0.2f);
				}
			}
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
					this.CardGuns = new Guns(base.GunName, 3, true);
					foreach (GunPair gunPair in this.CardGuns.GunPairs)
					{
						EnemyUnit target = this.Battle.EnemyGroup.Alives.MaxBy((EnemyUnit unit) => unit.Hp);
						yield return this.AttackAction(target, this.Damage, gunPair.GunName);
						target = null;
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
			base.Loyalty += base.UltimateCost;
			this.UltimateUsed = true;
			this.CardGuns = new Guns("梦想封印瞬", 8, false);
			foreach (GunPair gunPair in this.CardGuns.GunPairs)
			{
				yield return this.AttackAllAliveEnemyAction(gunPair);
				gunPair = null;
			}
			List<GunPair>.Enumerator enumerator = default(List<GunPair>.Enumerator);
			yield break;
			yield break;
		}
	}
}
