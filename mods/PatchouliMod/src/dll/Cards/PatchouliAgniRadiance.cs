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
	[EntityLogic(typeof(PatchouliAgniRadianceDef))]
	public sealed class PatchouliAgniRadiance : PatchouliBoostCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			yield return base.BuffAction<PatchouliFireSignSe>(base.Boost + base.Value1, 0, 0, PatchouliSignSe.TurnLimit, 0.2f);
			base.ResetBoost();
			yield break;
		}
	}
}
