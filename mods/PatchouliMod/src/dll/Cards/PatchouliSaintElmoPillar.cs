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
	[EntityLogic(typeof(PatchouliSaintElmoPillarDef))]
	public sealed class PatchouliSaintElmoPillar : PatchouliCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			yield return base.BuffAction<PatchouliMetalSignSe>(base.Value1, 0, 0, PatchouliSignSe.TurnLimit, 0.2f);
			yield return base.BuffAction<PatchouliSaintElmoPillarSe>(base.Value2, 0, 0, 0, 0.2f);
			yield break;
		}
	}
}
