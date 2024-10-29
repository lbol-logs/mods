using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Base.Extensions;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Battle.Interactions;
using LBoL.Core.Cards;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoLEntitySideloader.Attributes;
using Sanae_Kochiya.Cards.Template;
using Sanae_Kochiya.Source.StatusEffects;

namespace Sanae_Kochiya.Source.Cards.Offcolor
{
	[EntityLogic(typeof(SanaeKanakoFriendDef))]
	public sealed class SanaeKanakoFriend : SampleCharacterCard
	{
		public int Value3
		{
			get
			{
				bool isUpgraded = this.IsUpgraded;
				int num;
				if (isUpgraded)
				{
					num = this._upgradedValue3;
				}
				else
				{
					num = this._value3;
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

		public override IEnumerable<BattleAction> OnTurnEndingInHand()
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
				EnemyUnit enemyUnit = base.Battle.EnemyGroup.Alives.MaxBy((EnemyUnit unit) => unit.Hp);
				yield return base.AttackAction(enemyUnit, base.Damage, base.GunName);
				num = i;
				enemyUnit = null;
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
				yield return base.DefenseAction(true);
				yield return base.BuffAction<Graze>(this.Value3, 0, 0, 0, 0.2f);
			}
			else
			{
				base.Loyalty += base.UltimateCost;
				yield return base.SkillAnime;
				yield return new GainPowerAction(base.Value2);
				yield return base.BuffAction<SanaeKanakoFriendSe>(base.Value1, 0, 0, 0, 0.2f);
			}
			yield break;
		}

		private readonly int _value3 = 1;

		private readonly int _upgradedValue3 = 1;
	}
}
