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
	[EntityLogic(typeof(YoumuInfiniteKalpasDef))]
	public sealed class YoumuInfiniteKalpas : YoumuCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			bool flag = !base.Battle.BattleShouldEnd;
			if (flag)
			{
				yield return base.BuffAction<YoumuInfiniteKalpasSe>(base.Value1, 0, 0, 0, 0.2f);
				yield break;
			}
			yield break;
		}
	}
}
