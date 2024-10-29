﻿using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoLEntitySideloader.Attributes;
using PatchouliCharacterMod.Cards.Template;
using PatchouliCharacterMod.StatusEffects;

namespace PatchouliCharacterMod.Cards
{
	[EntityLogic(typeof(PatchouliGirlOfKnowledgeDef))]
	public sealed class PatchouliGirlOfKnowledge : PatchouliCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			yield return base.BuffAction<PatchouliIntelligenceSe>(base.Value1, 0, 0, 0, 0.2f);
			yield break;
		}
	}
}