using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.StatusEffects;
using LBoLEntitySideloader.Attributes;
using Sanae_Kochiya.Cards.Template;

namespace Sanae_Kochiya.Source.Cards.Common
{
	[EntityLogic(typeof(SanaeAttackSpiritDef))]
	public sealed class SanaeAttackSpirit : SampleCharacterCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			yield return base.AttackAction(selector, null);
			yield return base.BuffAction<TempSpirit>(base.Value1, 0, 0, 0, 0.2f);
			yield break;
		}
	}
}
