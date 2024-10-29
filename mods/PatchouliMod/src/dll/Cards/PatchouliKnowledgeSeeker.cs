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
	[EntityLogic(typeof(PatchouliKnowledgeSeekerDef))]
	public sealed class PatchouliKnowledgeSeeker : PatchouliBoostCard
	{
		protected override bool HasTreshold { get; set; } = true;

		protected override int BoostThreshold1 { get; set; } = 3;

		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			yield return base.BuffAction<PatchouliIntelligenceSe>(base.Value1, 0, 0, 0, 0.2f);
			bool flag = base.Boost >= this.BoostThreshold1;
			if (flag)
			{
				base.IsExile = false;
				base.ResetBoost();
			}
			yield break;
		}
	}
}
