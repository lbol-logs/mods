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
	[EntityLogic(typeof(ReimuUnifierRetributiveBoundaryDef))]
	public sealed class ReimuUnifierRetributiveBoundary : ReimuUnifierCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			yield return base.DefenseAction(true);
			bool isUpgraded = this.IsUpgraded;
			if (isUpgraded)
			{
				yield return base.BuffAction<ReimuUnifierRetributiveBoundaryUpgSe>(base.Value1, 0, 0, 0, 0.2f);
			}
			else
			{
				yield return base.BuffAction<ReimuUnifierRetributiveBoundarySe>(base.Value1, 0, 0, 0, 0.2f);
			}
			yield break;
		}
	}
}
