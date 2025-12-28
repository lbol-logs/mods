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
	[EntityLogic(typeof(ReimuUnifierYukariYakumoFriendDef))]
	public sealed class ReimuUnifierYukariYakumoFriend : Card
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
			yield return new AddCardsToHandAction(new Card[] { Library.CreateCard<ReimuUnifierCommunicatorOrbToken>() });
			foreach (BattleAction battleAction in base.SummonActions(selector, consumingMana, precondition))
			{
				yield return battleAction;
				battleAction = null;
			}
			IEnumerator<BattleAction> enumerator = null;
			yield break;
			yield break;
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
					yield return new AddCardsToHandAction(new Card[] { Library.CreateCard<ReimuUnifierCommunicatorOrbToken>() });
					int num = i + 1;
					i = num;
				}
			}
			yield break;
		}

		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			bool flag = precondition == null || ((MiniSelectCardInteraction)precondition).SelectedCard.FriendToken == FriendToken.Active;
			if (!flag)
			{
				this.Loyalty += this.UltimateCost;
				this.UltimateUsed = true;
				yield return this.BuffAction<Invincible>(0, 1, 0, 0, 0.2f);
				yield return base.BuffAction<ReimuUnifierYukariLifeLossSe>(base.Value2, 0, 0, 0, 0.2f);
				yield break;
			}
			this.Loyalty += this.ActiveCost;
			List<Card> list = base.Battle.HandZone.Where((Card hand) => hand != this).ToList<Card>();
			bool flag2 = list.Count <= 0;
			if (flag2)
			{
				yield break;
			}
			MiniSelectCardInteraction interaction = new MiniSelectCardInteraction(list, false, false, false)
			{
				Source = this
			};
			yield return new InteractionAction(interaction, false);
			Card ExiledCard = interaction.SelectedCard;
			int ExiledCardCost = ExiledCard.BaseCost.Amount;
			yield return new ExileCardAction(ExiledCard);
			yield return new CastBlockShieldAction(base.Battle.Player, base.Battle.Player, 0, ExiledCardCost * base.Value1, BlockShieldType.Direct, true);
			interaction = null;
			yield break;
		}
	}
}
