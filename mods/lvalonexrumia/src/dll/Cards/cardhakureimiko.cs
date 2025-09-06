using System;
using System.Collections.Generic;
using System.Linq;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Battle.Interactions;
using LBoL.Core.Cards;
using LBoL.Presentation;
using LBoLEntitySideloader.Attributes;
using lvalonexrumia.Cards.Template;
using lvalonexrumia.Patches;

namespace lvalonexrumia.Cards
{
	[EntityLogic(typeof(cardhakureimikoDef))]
	public sealed class cardhakureimiko : lvalonexrumiaCard
	{
		protected override int heal
		{
			get
			{
				return toolbox.hpfrompercent(Singleton<GameMaster>.Instance.CurrentGameRun.Player, base.Value1, true);
			}
		}

		protected override void OnEnterBattle(BattleController battle)
		{
			base.ReactBattleEvent<CardsEventArgs>(base.Battle.CardsAddedToDiscard, new EventSequencedReactor<CardsEventArgs>(this.OnAddCard));
			base.ReactBattleEvent<CardsEventArgs>(base.Battle.CardsAddedToHand, new EventSequencedReactor<CardsEventArgs>(this.OnAddCard));
			base.ReactBattleEvent<CardsEventArgs>(base.Battle.CardsAddedToExile, new EventSequencedReactor<CardsEventArgs>(this.OnAddCard));
			base.ReactBattleEvent<CardsAddingToDrawZoneEventArgs>(base.Battle.CardsAddedToDrawZone, new EventSequencedReactor<CardsAddingToDrawZoneEventArgs>(this.OnCardsAddedToDrawZone));
		}

		private IEnumerable<BattleAction> OnCardsAddedToDrawZone(CardsAddingToDrawZoneEventArgs args)
		{
			bool flag = base.Zone == CardZone.Hand;
			if (flag)
			{
				yield return this.Upgrade(args.Cards);
			}
			yield break;
		}

		private IEnumerable<BattleAction> OnAddCard(CardsEventArgs args)
		{
			bool flag = base.Zone == CardZone.Hand;
			if (flag)
			{
				yield return this.Upgrade(args.Cards);
			}
			yield break;
		}

		private BattleAction Upgrade(IEnumerable<Card> cards)
		{
			List<Card> list = cards.Where((Card card) => card.CanUpgradeAndPositive).ToList<Card>();
			bool flag = list.Count == 0;
			BattleAction battleAction;
			if (flag)
			{
				battleAction = null;
			}
			else
			{
				base.NotifyActivating();
				battleAction = new UpgradeCardsAction(list);
			}
			return battleAction;
		}

		public override IEnumerable<BattleAction> OnTurnStartedInHand()
		{
			return this.GetPassiveActions();
		}

		public override IEnumerable<BattleAction> GetPassiveActions()
		{
			bool flag = !base.Summoned || base.Battle.BattleShouldEnd;
			if (flag)
			{
				yield break;
			}
			base.NotifyActivating();
			base.Loyalty += base.PassiveCost;
			int num;
			for (int i = 0; i < base.Battle.FriendPassiveTimes; i = num + 1)
			{
				bool battleShouldEnd = base.Battle.BattleShouldEnd;
				if (battleShouldEnd)
				{
					break;
				}
				yield return PerformAction.Sfx("FairySupport", 0f);
				yield return new ChangeLifeAction(this.heal, null);
				num = i;
			}
			yield break;
		}

		public override IEnumerable<BattleAction> SummonActions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			foreach (BattleAction item in base.SummonActions(selector, consumingMana, precondition))
			{
				yield return item;
				item = null;
			}
			IEnumerator<BattleAction> enumerator = null;
			yield break;
			yield break;
		}

		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			bool flag = precondition == null || ((MiniSelectCardInteraction)precondition).SelectedCard.FriendToken == FriendToken.Active;
			if (flag)
			{
				base.Loyalty += base.ActiveCost;
				yield return base.SkillAnime;
				bool flag2 = base.Battle.ExileZone.Count > 0;
				if (flag2)
				{
					SelectCardInteraction interaction = new SelectCardInteraction(1, 1, base.Battle.ExileZone, SelectedCardHandling.DoNothing)
					{
						Source = this
					};
					yield return new InteractionAction(interaction, false);
					Card card = interaction.SelectedCards.FirstOrDefault<Card>();
					bool flag3 = card != null;
					if (flag3)
					{
						bool canUpgradeAndPositive = card.CanUpgradeAndPositive;
						if (canUpgradeAndPositive)
						{
							yield return new UpgradeCardAction(card);
						}
						yield return new MoveCardAction(card, CardZone.Hand);
					}
					interaction = null;
					card = null;
				}
				yield return new MoveCardAction(this, CardZone.Hand);
			}
			else
			{
				base.Loyalty += base.UltimateCost;
				base.UltimateUsed = true;
				bool flag4 = !base.Battle.BattleShouldEnd;
				if (flag4)
				{
					List<Card> list = (from c in base.Battle.EnumerateAllCards()
						where c.IsExile && c != this
						select c).ToList<Card>();
					bool flag5 = list.Count > 0;
					if (flag5)
					{
						foreach (Card card2 in list)
						{
							card2.IsExile = false;
							card2 = null;
						}
						List<Card>.Enumerator enumerator = default(List<Card>.Enumerator);
					}
					List<Card> list2 = (from c in base.Battle.EnumerateAllCards()
						where c.IsEthereal && c != this
						select c).ToList<Card>();
					bool flag6 = list2.Count > 0;
					if (flag6)
					{
						foreach (Card card3 in list2)
						{
							card3.IsEthereal = false;
							card3 = null;
						}
						List<Card>.Enumerator enumerator2 = default(List<Card>.Enumerator);
					}
					list = null;
					list2 = null;
				}
			}
			yield break;
		}
	}
}
