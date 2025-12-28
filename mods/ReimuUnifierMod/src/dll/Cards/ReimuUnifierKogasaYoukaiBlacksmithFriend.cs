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
using LBoLEntitySideloader.Attributes;

namespace ReimuUnifierMod.Cards
{
	[EntityLogic(typeof(ReimuUnifierKogasaYoukaiBlacksmithFriendDef))]
	public sealed class ReimuUnifierKogasaYoukaiBlacksmithFriend : Card
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
				List<Card> UpgradeableCardsInHand = new List<Card>();
				this.NotifyActivating();
				this.Loyalty += this.PassiveCost;
				int i = 0;
				while (i < this.Battle.FriendPassiveTimes && !this.Battle.BattleShouldEnd)
				{
					UpgradeableCardsInHand = base.Battle.HandZone.Where((Card hand) => hand != this && hand.CanUpgrade).ToList<Card>();
					bool flag2 = UpgradeableCardsInHand.NotEmpty<Card>();
					if (flag2)
					{
						bool flag3 = this.IsUpgraded && UpgradeableCardsInHand.Count > 1;
						if (flag3)
						{
							yield return new UpgradeCardsAction(UpgradeableCardsInHand.SampleManyOrAll(2, base.BattleRng));
						}
						else
						{
							yield return new UpgradeCardAction(UpgradeableCardsInHand.Sample(base.BattleRng));
						}
					}
					int num = i + 1;
					i = num;
				}
				UpgradeableCardsInHand = null;
			}
			yield break;
		}

		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			bool flag = precondition == null || ((MiniSelectCardInteraction)precondition).SelectedCard.FriendToken == FriendToken.Active;
			if (flag)
			{
				this.Loyalty += this.ActiveCost;
				int AttackNumber = base.Battle.HandZone.Where((Card hand) => hand.IsUpgraded).Count<Card>();
				bool isUpgraded = this.IsUpgraded;
				if (isUpgraded)
				{
					int num = AttackNumber;
					AttackNumber = num + 1;
				}
				bool flag2 = AttackNumber <= 0;
				if (flag2)
				{
					yield break;
				}
				this.CardGuns = new Guns("反击弹幕", AttackNumber, true);
				foreach (GunPair gunPair in this.CardGuns.GunPairs)
				{
					yield return this.AttackAction(base.Battle.RandomAliveEnemy, this.Damage, gunPair.GunName);
					gunPair = null;
				}
				List<GunPair>.Enumerator enumerator = default(List<GunPair>.Enumerator);
			}
			else
			{
				this.Loyalty += this.UltimateCost;
				this.UltimateUsed = true;
				int CardsToAdd = base.Battle.MaxHand - base.Battle.HandZone.Count;
				yield return new AddCardsToHandAction(Library.CreateCards<ReimuUnifierYoukaiForgedNeedle>(CardsToAdd, this.IsUpgraded), AddCardsType.Normal, false);
			}
			yield break;
			yield break;
		}
	}
}
