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
	[EntityLogic(typeof(ReimuUnifierRitualofEchoingProsperityDef))]
	public sealed class ReimuUnifierRitualofEchoingProsperity : ReimuUnifierCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			yield return base.BuffAction<ReimuUnifierRitualofEchoingProsperitySe>(base.Value1, 0, 0, 0, 0.2f);
			yield break;
		}
	}
}
