using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoLEntitySideloader.Attributes;
using PatchouliCharacterMod.Cards.Template;
using PatchouliCharacterMod.StatusEffects;

namespace PatchouliCharacterMod.Cards
{
	[EntityLogic(typeof(PatchouliVoileDef))]
	public sealed class PatchouliVoile : PatchouliCard
	{
		public int BoostThreshold1 { get; } = 3;

		public int BoostThreshold2 { get; } = 6;

		public int BoostThreshold3 { get; } = 9;

		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			yield return base.BuffAction<PatchouliVoileSe>(base.Value1, 0, 0, 0, 0.2f);
			yield break;
		}
	}
}
