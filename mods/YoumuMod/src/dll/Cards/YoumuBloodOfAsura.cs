﻿using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoLEntitySideloader.Attributes;
using YoumuCharacterMod.Cards.Template;
using YoumuCharacterMod.StatusEffects;

namespace YoumuCharacterMod.Cards
{
	[EntityLogic(typeof(YoumuBloodOfAsuraDef))]
	public sealed class YoumuBloodOfAsura : YoumuCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			yield return base.BuffAction<YoumuBloodOfAsuraSe>(base.Value1, 0, 0, 0, 0.2f);
			yield break;
		}
	}
}
