using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.StatusEffects;
using LBoL.EntityLib.Cards;
using LBoL.EntityLib.StatusEffects.ExtraTurn;
using LBoLEntitySideloader.Attributes;
using Sanae_Kochiya.Source.StatusEffects;

namespace Sanae_Kochiya.Source.Cards.Rare
{
	[EntityLogic(typeof(SanaeSpellManaDef))]
	public sealed class SanaeSpellMana : LimitedStopTimeCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			bool isUpgraded = this.IsUpgraded;
			if (isUpgraded)
			{
				yield return new GainPowerAction(base.Value2);
				yield return base.BuffAction<SanaeSpellManaPhiloSe>(base.Value1, 0, 0, 0, 0.2f);
			}
			else
			{
				yield return base.BuffAction<SanaeSpellManaGreenSe>(base.Value1, 0, 0, 0, 0.2f);
			}
			yield return base.BuffAction<ExtraTurn>(1, 0, 0, 0, 0.2f);
			bool limited = base.Limited;
			if (limited)
			{
				yield return base.DebuffAction<TimeIsLimited>(base.Battle.Player, 1, 0, 0, 0, true, 0.2f);
			}
			yield return new RequestEndPlayerTurnAction();
			yield break;
		}
	}
}
