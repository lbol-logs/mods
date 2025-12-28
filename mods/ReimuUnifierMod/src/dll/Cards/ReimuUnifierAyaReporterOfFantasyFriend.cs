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
using LBoL.Core.Units;
using LBoL.EntityLib.Cards.Enemy;
using LBoL.EntityLib.EnemyUnits.Character;
using LBoLEntitySideloader.Attributes;
using ReimuUnifierMod.StatusEffects;

namespace ReimuUnifierMod.Cards
{
	[EntityLogic(typeof(ReimuUnifierAyaReporterOfFantasyFriendDef))]
	public sealed class ReimuUnifierAyaReporterOfFantasyFriend : Card
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
			bool flag = card.CardType == CardType.Status && base.Summoned;
			if (flag)
			{
				base.NotifyActivating();
				yield return base.BuffAction<Graze>(1, 0, 0, 0, 0.2f);
			}
			yield break;
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
				bool flag = unit is Aya;
				if (flag)
				{
					PlayerUnit player = base.Battle.Player;
					ReimuUnifierModDef.ReimuUnifierMod PC = player as ReimuUnifierModDef.ReimuUnifierMod;
					bool flag2 = PC != null;
					if (flag2)
					{
						bool flag3 = !PC.DialogueTriggered;
						if (flag3)
						{
							yield return PerformAction.Chat(base.Battle.Player, PC.LocShortcut("DialogueAya1", true, true), 2.5f, 0f, 2.5f, true);
							yield return PerformAction.Chat(unit, PC.LocShortcut("DialogueAya2", true, true), 2.5f, 0f, 2.5f, true);
							PC.DialogueTriggered = true;
						}
					}
					PC = null;
				}
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
					List<Card> CardsToAdd = new List<Card>(Library.CreateCards<AyaNews>(2, false));
					foreach (Card card in CardsToAdd)
					{
						card.DecreaseBaseCost(ManaGroup.Anys(base.Value1));
						card.SetKeyword(Keyword.Replenish, true);
						card.SetKeyword(Keyword.AutoExile, true);
						card = null;
					}
					List<Card>.Enumerator enumerator = default(List<Card>.Enumerator);
					yield return new AddCardsToDrawZoneAction(CardsToAdd, DrawZoneTarget.Random, AddCardsType.Normal);
					CardsToAdd = null;
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
				List<Card> Statuses = new List<Card>();
				bool flag2 = !this.IsUpgraded;
				if (flag2)
				{
					Statuses = base.Battle.HandZone.Where((Card card) => card.CardType == CardType.Status).ToList<Card>();
				}
				else
				{
					Statuses = (from card in base.Battle.HandZone.Concat(base.Battle.DiscardZone).Concat(base.Battle.DrawZone)
						where card.CardType == CardType.Status
						select card).ToList<Card>();
				}
				int GrazeToGain = Statuses.Count;
				bool flag3 = Statuses.Count > 0;
				if (flag3)
				{
					yield return new ExileManyCardAction(Statuses);
					yield return base.BuffAction<Graze>(GrazeToGain, 0, 0, 0, 0.2f);
				}
				Statuses = null;
			}
			else
			{
				this.Loyalty += this.UltimateCost;
				this.UltimateUsed = true;
				yield return base.BuffAction<ReimuUnifierAyaDominanceSe>(base.Value2, 0, 0, 0, 0.2f);
			}
			yield break;
		}
	}
}
