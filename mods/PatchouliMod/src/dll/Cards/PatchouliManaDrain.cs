using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.StatusEffects;
using LBoLEntitySideloader.Attributes;
using PatchouliCharacterMod.Cards.Template;

namespace PatchouliCharacterMod.Cards
{
	[EntityLogic(typeof(PatchouliManaDrainDef))]
	public sealed class PatchouliManaDrain : PatchouliBoostCard
	{
		protected override bool HasTreshold { get; set; } = true;

		protected override int BoostThreshold1 { get; set; } = 2;

		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			yield return base.AttackAction(selector, base.GunName);
			bool flag = base.Boost >= this.BoostThreshold1 && !base.Battle.BattleShouldEnd;
			if (flag)
			{
				yield return base.DebuffAction<Weak>(selector.SelectedEnemy, 0, base.Value1, 0, 0, true, 0.2f);
				base.ResetBoost();
			}
			yield break;
		}
	}
}
