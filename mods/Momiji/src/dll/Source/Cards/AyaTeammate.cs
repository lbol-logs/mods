using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Battle.Interactions;
using LBoL.Core.Cards;
using LBoL.Core.StatusEffects;
using LBoL.EntityLib.StatusEffects.Enemy;
using LBoLEntitySideloader.Attributes;

namespace Momiji.Source.Cards
{
	[EntityLogic(typeof(AyaTeammateDef))]
	public sealed class AyaTeammate : SampleCharacterCard
	{
		public int Graze
		{
			get
			{
				bool flag = !this.IsUpgraded;
				int num;
				if (flag)
				{
					num = 2;
				}
				else
				{
					num = 3;
				}
				return num;
			}
		}

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
				bool flag2 = base.Battle.Player.HasStatusEffect<Graze>();
				if (flag2)
				{
					yield return base.BuffAction<Graze>(1, 0, 0, 0, 0.2f);
				}
				num = i;
			}
			yield break;
		}

		public override IEnumerable<BattleAction> SummonActions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			yield return base.BuffAction<Graze>(this.Graze, 0, 0, 0, 0.2f);
			foreach (BattleAction battleAction in base.SummonActions(selector, consumingMana, precondition))
			{
				yield return battleAction;
				battleAction = null;
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
				foreach (BattleAction battleAction in base.DebuffAction<LockedOn>(base.Battle.AllAliveEnemies, base.Value2, 0, 0, 0, true, 0.2f))
				{
					yield return battleAction;
					battleAction = null;
				}
				IEnumerator<BattleAction> enumerator = null;
				yield return new AddCardsToHandAction(Library.CreateCards<MapleLeaf>(base.Value1, false), AddCardsType.Normal);
				yield return base.SkillAnime;
			}
			else
			{
				base.Loyalty += base.UltimateCost;
				base.UltimateUsed = true;
				yield return base.BuffAction<WindGirl>(1, 0, 0, 0, 0.2f);
				yield return new ApplyStatusEffectAction<AccuracyModule>(base.Battle.Player, new int?(1), new int?(0), new int?(0), new int?(0), 0.2f, true);
				yield return base.SkillAnime;
			}
			yield break;
			yield break;
		}
	}
}
