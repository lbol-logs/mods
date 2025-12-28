using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.StatusEffects;
using LBoLEntitySideloader.Attributes;
using ReimuUnifierMod.Cards.Template;

namespace ReimuUnifierMod.Cards
{
	[EntityLogic(typeof(ReimuUnifierCooperativeBarrierDef))]
	public sealed class ReimuUnifierCooperativeBarrier : ReimuUnifierCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			yield return base.BuffAction<TempSpirit>(base.Value1 * base.SummonedTeammatesInHand + base.Value2, 0, 0, 0, 0.2f);
			yield return base.DefenseAction(true);
			yield break;
		}
	}
}
