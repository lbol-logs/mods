using System;
using System.Collections.Generic;
using System.Linq;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Battle.Interactions;
using LBoL.Core.Cards;
using LBoL.Core.StatusEffects;
using LBoLEntitySideloader.Attributes;
using ReimuUnifierMod.StatusEffects;

namespace ReimuUnifierMod.Cards
{
	[EntityLogic(typeof(ReimuUnifierSuikaGourdOniFriendDef))]
	public sealed class ReimuUnifierSuikaGourdOniFriend : Card
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
				this.NotifyActivating();
				this.Loyalty += this.PassiveCost;
				int i = 0;
				while (i < this.Battle.FriendPassiveTimes && !this.Battle.BattleShouldEnd)
				{
					yield return PerformAction.Sfx("FairySupport", 0f);
					Card CardToAdd = Library.CreateCard("Xiaozhuo");
					CardToAdd.SetKeyword(Keyword.Ethereal, true);
					yield return new AddCardsToHandAction(new Card[] { CardToAdd });
					CardToAdd = null;
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
				List<Card> Tipsies = base.Battle.ExileZone.Where((Card Tipsy) => Tipsy.GetType().Equals(typeof(Xiaozhuo))).ToList<Card>();
				foreach (Card card in Tipsies)
				{
					bool handIsNotFull = base.Battle.HandIsNotFull;
					if (handIsNotFull)
					{
						yield return new MoveCardAction(card, CardZone.Hand);
					}
					card = null;
				}
				List<Card>.Enumerator enumerator = default(List<Card>.Enumerator);
				Tipsies = null;
			}
			else
			{
				this.Loyalty += this.UltimateCost;
				this.UltimateUsed = true;
				yield return this.BuffAction<Invincible>(0, base.Value1, 0, 0, 0.2f);
				yield return this.BuffAction<ReimuUnifierOnHitTempFPSe>(base.Value2, 0, 0, 0, 0.2f);
			}
			yield break;
			yield break;
		}
	}
}
