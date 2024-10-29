using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoLEntitySideloader.Attributes;
using PatchouliCharacterMod.BattleActions;
using PatchouliCharacterMod.Cards.Template;
using PatchouliCharacterMod.StatusEffects;

namespace PatchouliCharacterMod.Cards
{
	[EntityLogic(typeof(PatchouliSpellPowerGraspDef))]
	public sealed class PatchouliSpellPowerGrasp : PatchouliCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			bool isUpgraded = this.IsUpgraded;
			if (isUpgraded)
			{
				yield return new BoostAllInHandAction(base.Value2);
			}
			yield return base.BuffAction<PatchouliSpellPowerGraspSe>(base.Value1, 0, 0, 0, 0.2f);
			yield break;
		}
	}
}
