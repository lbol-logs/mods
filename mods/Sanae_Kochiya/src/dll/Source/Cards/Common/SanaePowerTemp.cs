using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.StatusEffects;
using LBoLEntitySideloader.Attributes;
using Sanae_Kochiya.Cards.Template;
using Sanae_Kochiya.Source.StatusEffects;

namespace Sanae_Kochiya.Source.Cards.Common
{
	[EntityLogic(typeof(SanaePowerTempDef))]
	public sealed class SanaePowerTemp : SampleCharacterCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			yield return base.BuffAction<Firepower>(base.Value1, 0, 0, 0, 0.2f);
			yield return base.DebuffAction<NextTurnLoseFire>(base.Battle.Player, base.Value1, 0, 0, 0, true, 0.2f);
			yield return new GainPowerAction(base.Value1);
			yield break;
		}
	}
}
