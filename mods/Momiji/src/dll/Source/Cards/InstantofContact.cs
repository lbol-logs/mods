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
using Momiji.Source.StatusEffects;

namespace Momiji.Source.Cards
{
	[EntityLogic(typeof(InstantofContactDef))]
	public sealed class InstantofContact : LimitedStopTimeCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			yield return new ApplyStatusEffectAction<RetaliationSe>(base.Battle.Player, new int?(base.Value1), new int?(0), new int?(0), new int?(0), 0.2f, true);
			yield return base.BuffAction<ExtraTurn>(1, 0, 0, 0, 0.2f);
			yield return new RequestEndPlayerTurnAction();
			bool limited = base.Limited;
			if (limited)
			{
				yield return base.DebuffAction<TimeIsLimited>(base.Battle.Player, 1, 0, 0, 0, true, 0.2f);
				yield return new ApplyStatusEffectAction<InstantofContactSe>(base.Battle.Player, new int?(base.Value2), new int?(1), new int?(0), new int?(0), 0.2f, true);
			}
			yield break;
		}
	}
}
