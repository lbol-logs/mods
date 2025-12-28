using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoLEntitySideloader.Attributes;
using ReimuUnifierMod.Cards.Template;
using ReimuUnifierMod.StatusEffects;

namespace ReimuUnifierMod.Cards
{
	[EntityLogic(typeof(ReimuUnifierDimensionalRiftBoundaryDef))]
	public sealed class ReimuUnifierDimensionalRiftBoundary : ReimuUnifierCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			yield return base.BuffAction<ReimuUnifierDimensionalRiftBoundarySe>(base.Value1, 0, 0, 1, 0.2f);
			yield break;
		}
	}
}
