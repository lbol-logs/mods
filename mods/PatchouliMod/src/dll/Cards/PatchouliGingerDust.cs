using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoLEntitySideloader.Attributes;
using PatchouliCharacterMod.Cards.Template;
using PatchouliCharacterMod.StatusEffects;

namespace PatchouliCharacterMod.Cards
{
	[EntityLogic(typeof(PatchouliGingerDustDef))]
	public sealed class PatchouliGingerDust : PatchouliBoostCard
	{
		protected override bool HasTreshold { get; set; } = true;

		protected override int BoostThreshold1 { get; set; } = 3;

		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			yield return new DrawManyCardAction(base.Value2);
			yield return base.BuffAction<PatchouliEarthSignSe>(base.Value1, 0, 0, PatchouliSignSe.TurnLimit, 0.2f);
			bool flag = base.Boost >= this.BoostThreshold1;
			if (flag)
			{
				yield return base.BuffAction<PatchouliMetalSignSe>(base.Value1, 0, 0, PatchouliSignSe.TurnLimit, 0.2f);
				base.ResetBoost();
			}
			yield break;
		}
	}
}
