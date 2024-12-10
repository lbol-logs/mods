using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoLEntitySideloader.Attributes;
using Momiji.Source.StatusEffects;

namespace Momiji.Source.Cards
{
	[EntityLogic(typeof(MountainsideTrailTrackingDef))]
	public sealed class MountainsideTrailTracking : SampleCharacterCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			yield return base.BuffAction<MountainsideTrailTrackingSe>(base.Value1, 0, 0, 0, 0.2f);
			yield break;
		}
	}
}
