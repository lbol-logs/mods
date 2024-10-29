using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.StatusEffects;
using LBoLEntitySideloader.Attributes;
using Sanae_Kochiya.Cards.Template;
using Sanae_Kochiya.Source.StatusEffects;

namespace Sanae_Kochiya.Source.Cards.Offcolor
{
	[EntityLogic(typeof(SanaeGrazeWardDef))]
	public sealed class SanaeGrazeWard : SampleCharacterCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			yield return base.BuffAction<SanaeGrazeWardSe>(base.Value1, 0, 0, 0, 0.2f);
			yield return base.BuffAction<Graze>(base.Value2, 0, 0, 0, 0.2f);
			yield break;
		}
	}
}
