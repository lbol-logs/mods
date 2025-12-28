using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Battle.Interactions;
using LBoL.Core.Cards;
using LBoL.Core.Units;
using LBoL.EntityLib.EnemyUnits.Character;
using LBoL.EntityLib.EnemyUnits.Opponent;
using LBoLEntitySideloader.Attributes;

namespace ReimuUnifierMod.Cards
{
	[EntityLogic(typeof(ReimuUnifierFourFairiesFriendDef))]
	public sealed class ReimuUnifierFourFairiesFriend : Card
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
						bool flag3 = unit is Star || unit is Sunny || unit is Luna;
						if (flag3)
						{
							yield return PerformAction.Chat(base.Battle.Player, PC.LocShortcut("DialogueFairies11", true, true), 2.5f, 0f, 2.5f, true);
							PC.DialogueTriggered = true;
						}
						else
						{
							bool flag4 = unit is Clownpiece;
							if (flag4)
							{
								yield return PerformAction.Chat(base.Battle.Player, PC.LocShortcut("DialogueFairies21", true, true), 2.5f, 0f, 2.5f, true);
								yield return PerformAction.Chat(unit, PC.LocShortcut("DialogueFairies22", true, true), 2.5f, 0f, 2.5f, true);
								PC.DialogueTriggered = true;
							}
							else
							{
								bool flag5 = unit is Cirno;
								if (flag5)
								{
									yield return PerformAction.Chat(base.Battle.Player, PC.LocShortcut("DialogueFairies31", true, true), 2.5f, 0f, 2.5f, true);
									yield return PerformAction.Chat(unit, PC.LocShortcut("DialogueFairies32", true, true), 2.5f, 0f, 2.5f, true);
									PC.DialogueTriggered = true;
								}
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
					int AttackIndex = 0;
					List<string> EffectList = new List<string>();
					EffectList.Add("StarFairy");
					EffectList.Add("LunaFairy");
					EffectList.Add("SunnyFairy");
					bool isUpgraded = this.IsUpgraded;
					if (isUpgraded)
					{
						EffectList.Add("MaidFairy");
					}
					List<string> GunList = new List<string>();
					GunList.Add("StarPas");
					GunList.Add("LunaAct");
					GunList.Add("SunnyPas");
					bool isUpgraded2 = this.IsUpgraded;
					if (isUpgraded2)
					{
						GunList.Add("Clownpiece1");
					}
					this.CardGuns = new Guns(GunList);
					int num;
					foreach (GunPair gunPair in this.CardGuns.GunPairs)
					{
						bool flag2 = EffectList.Count <= AttackIndex;
						if (!flag2)
						{
							yield return PerformAction.Effect(this.Battle.Player, EffectList[AttackIndex], 0f, null, 0f, PerformAction.EffectBehavior.PlayOneShot, 0f);
						}
						yield return this.AttackRandomAliveEnemyAction(gunPair);
						num = AttackIndex;
						AttackIndex = num + 1;
						gunPair = null;
					}
					List<GunPair>.Enumerator enumerator = default(List<GunPair>.Enumerator);
					EffectList = null;
					GunList = null;
					num = i + 1;
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
				List<Card> PickableTeammates = new List<Card>();
				PickableTeammates.Add(Library.CreateCard("LunaFriend"));
				PickableTeammates.Add(Library.CreateCard("StarFriend"));
				PickableTeammates.Add(Library.CreateCard("SunnyFriend"));
				bool isUpgraded = this.IsUpgraded;
				if (isUpgraded)
				{
					PickableTeammates.Add(Library.CreateCard("ClownpieceFriend"));
				}
				foreach (Card card in PickableTeammates)
				{
					card.Summon();
					card = null;
				}
				List<Card>.Enumerator enumerator = default(List<Card>.Enumerator);
				bool flag2 = PickableTeammates.Count > 0;
				if (flag2)
				{
					MiniSelectCardInteraction interaction = new MiniSelectCardInteraction(PickableTeammates, false, false, false)
					{
						Source = this
					};
					yield return new InteractionAction(interaction, false);
					Card selectedCard = interaction.SelectedCard;
					yield return new AddCardsToHandAction(new Card[] { selectedCard });
					interaction = null;
					interaction = null;
					selectedCard = null;
				}
				yield break;
			}
			this.Loyalty += this.UltimateCost;
			this.UltimateUsed = true;
			List<Card> PickableTeammates2 = new List<Card>();
			PickableTeammates2.Add(Library.CreateCard("LunaFriend"));
			PickableTeammates2.Add(Library.CreateCard("StarFriend"));
			PickableTeammates2.Add(Library.CreateCard("SunnyFriend"));
			bool isUpgraded2 = this.IsUpgraded;
			if (isUpgraded2)
			{
				PickableTeammates2.Add(Library.CreateCard("ClownpieceFriend"));
			}
			foreach (Card card2 in PickableTeammates2)
			{
				card2.Summon();
				card2.Loyalty = 9;
				card2 = null;
			}
			List<Card>.Enumerator enumerator2 = default(List<Card>.Enumerator);
			yield return new AddCardsToHandAction(PickableTeammates2, AddCardsType.Normal, false);
			PickableTeammates2 = null;
			yield break;
		}
	}
}
