using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoLEntitySideloader.Attributes;
using Sanae_Kochiya.Cards.Template;
using Sanae_Kochiya.Source.StatusEffects;

namespace Sanae_Kochiya.Source.Cards.Common
{
	[EntityLogic(typeof(SanaePowerPotatoDef))]
	public sealed class SanaePowerPotato : SampleCharacterCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			yield return base.BuffAction<SanaePowerPotatoSe>(base.Value1, 0, 0, 0, 0.2f);
			yield break;
		}
	}
}
