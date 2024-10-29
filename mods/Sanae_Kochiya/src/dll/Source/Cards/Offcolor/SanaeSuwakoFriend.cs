using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Battle.Interactions;
using LBoL.Core.Cards;
using LBoL.Core.Randoms;
using LBoL.Core.StatusEffects;
using LBoL.EntityLib.Cards.Enemy;
using LBoLEntitySideloader.Attributes;
using Sanae_Kochiya.Cards.Template;

namespace Sanae_Kochiya.Source.Cards.Offcolor
{
	[EntityLogic(typeof(SanaeSuwakoFriendDef))]
	public sealed class SanaeSuwakoFriend : SampleCharacterCard
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

		public override FriendCostInfo FriendU
		{
			get
			{
				return new FriendCostInfo(base.UltimateCost, FriendCostType.Active);
			}
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
					yield break;
				}
				List<Card> Curse = new List<Card>
				{
					Library.CreateCard(typeof(BlackResidue)),
					Library.CreateCard(typeof(BlackResidue))
				};
				yield return new AddCardsToDrawZoneAction(Curse, DrawZoneTarget.Random, AddCardsType.Normal);
				num = i;
				Curse = null;
			}
			yield break;
		}

		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			bool flag = precondition == null || ((MiniSelectCardInteraction)precondition).SelectedCard.FriendToken == FriendToken.Active;
			if (flag)
			{
				base.Loyalty += base.ActiveCost;
				yield return base.SkillAnime;
				foreach (BattleAction battleAction in base.DebuffAction<Weak>(base.Battle.AllAliveEnemies, 0, base.Value1, 0, 0, true, 0.1f))
				{
					yield return battleAction;
					battleAction = null;
				}
				IEnumerator<BattleAction> enumerator = null;
			}
			else
			{
				base.Loyalty += base.UltimateCost;
				yield return base.SkillAnime;
				Card[] Ability = base.Battle.RollCards(new CardWeightTable(RarityWeightTable.OnlyUncommon, OwnerWeightTable.Valid, CardTypeWeightTable.CanBeLoot, false), 1, (CardConfig config) => config.Type == CardType.Ability);
				foreach (Card card in Ability)
				{
					card.SetTurnCost(base.Mana);
					card.IsEthereal = true;
					card = null;
				}
				Card[] array = null;
				yield return new AddCardsToHandAction(Ability, AddCardsType.Normal);
				Ability = null;
			}
			yield break;
			yield break;
		}
	}
}
