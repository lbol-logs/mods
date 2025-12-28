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
	[EntityLogic(typeof(ReimuUnifierShinmyoumaruInchlingPrincessFriendDef))]
	public sealed class ReimuUnifierShinmyoumaruInchlingPrincessFriend : Card
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
				bool flag = unit is Seija;
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
							yield return PerformAction.Chat(base.Battle.Player, PC.LocShortcut("DialogueShinmyoumaru1", true, true), 2.5f, 0f, 2.5f, true);
							yield return PerformAction.Chat(base.Battle.RandomAliveEnemy, PC.LocShortcut("DialogueShinmyoumaru2", true, true), 2.5f, 0f, 2.5f, true);
							yield return PerformAction.Chat(base.Battle.Player, PC.LocShortcut("DialogueShinmyoumaru3", true, true), 2.5f, 0f, 2.5f, true);
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
				int loyalty = base.Loyalty;
				base.Loyalty = loyalty + 1;
			}
			yield break;
		}

		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			bool flag = precondition == null || ((MiniSelectCardInteraction)precondition).SelectedCard.FriendToken == FriendToken.Active;
			if (flag)
			{
				base.Loyalty += base.ActiveCost;
				yield return base.BuffAction<Firepower>(base.Value1, 0, 0, 0, 0.2f);
			}
			else
			{
				bool flag2 = ((MiniSelectCardInteraction)precondition).SelectedCard.FriendToken == FriendToken.Active2;
				if (flag2)
				{
					base.Loyalty += base.ActiveCost2;
					yield return base.SkillAnime;
					int Handspace = base.Battle.MaxHand - base.Battle.HandZone.Count;
					List<Card> CommonCards = base.Battle.DrawZone.Where((Card card) => card.Config.Rarity == Rarity.Common).ToList<Card>();
					bool flag3 = CommonCards.Count<Card>() > 0 && Handspace > 0;
					if (flag3)
					{
						foreach (Card card2 in CommonCards.SampleManyOrAll(Handspace, base.GameRun.BattleRng))
						{
							yield return new MoveCardAction(card2, CardZone.Hand);
							card2 = null;
						}
						Card[] array = null;
					}
					yield return new GainManaAction(base.Mana);
					CommonCards = null;
				}
				else
				{
					base.Loyalty += base.UltimateCost;
					Card rod = Library.CreateCard<ReimuUnifierMercilessRodFriendToken>(this.IsUpgraded);
					rod.Summon();
					yield return new AddCardsToHandAction(new Card[] { rod });
					rod = null;
				}
			}
			yield break;
		}
	}
}
