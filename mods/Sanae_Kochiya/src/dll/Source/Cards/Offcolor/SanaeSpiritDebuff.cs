﻿using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.StatusEffects;
using LBoL.EntityLib.StatusEffects.Neutral.White;
using LBoLEntitySideloader.Attributes;
using Sanae_Kochiya.Cards.Template;

namespace Sanae_Kochiya.Source.Cards.Offcolor
{
	[EntityLogic(typeof(SanaeSpiritDebuffDef))]
	public sealed class SanaeSpiritDebuff : SampleCharacterCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			yield return base.BuffAction<Spirit>(base.Value1, 0, 0, 0, 0.2f);
			yield return base.DebuffAction<LoseSpiritSe>(base.Battle.Player, base.Value2, 0, 0, 0, true, 0.2f);
			yield break;
		}
	}
}
