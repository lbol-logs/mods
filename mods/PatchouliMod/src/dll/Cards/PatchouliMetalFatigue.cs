using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.StatusEffects;
using LBoLEntitySideloader.Attributes;
using PatchouliCharacterMod.Cards.Template;
using PatchouliCharacterMod.StatusEffects;

namespace PatchouliCharacterMod.Cards
{
	[EntityLogic(typeof(PatchouliMetalFatigueDef))]
	public sealed class PatchouliMetalFatigue : PatchouliBoostCard
	{
		protected override bool HasTreshold { get; set; } = true;

		protected override int BoostThreshold1 { get; set; } = 4;

		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			yield return base.BuffAction<PatchouliMetalSignSe>(base.Value1, 0, 0, PatchouliSignSe.TurnLimit, 0.2f);
			yield return base.DebuffAction<TempFirepowerNegative>(selector.SelectedEnemy, base.Value2, 0, 0, 0, true, 0.2f);
			bool flag = base.Boost >= this.BoostThreshold1;
			if (flag)
			{
				yield return base.DebuffAction<FirepowerNegative>(selector.SelectedEnemy, base.Value2, 0, 0, 0, true, 0.2f);
				yield return new ExileCardAction(this);
				base.ResetBoost();
			}
			yield break;
		}
	}
}
