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
	[EntityLogic(typeof(PatchouliMoonlitChillDef))]
	public sealed class PatchouliMoonlitChill : PatchouliBoostCard
	{
		protected override bool HasTreshold { get; set; } = true;

		protected override int BoostThreshold1 { get; set; } = 4;

		protected override int BoostThreshold2 { get; set; } = 8;

		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			int firepowerBonus = 0;
			int spiritBonus = 0;
			bool flag = base.Boost >= this.BoostThreshold2;
			if (flag)
			{
				spiritBonus = base.Value1;
			}
			bool flag2 = base.Boost >= this.BoostThreshold1;
			if (flag2)
			{
				firepowerBonus = base.Value2;
				base.ResetBoost();
			}
			yield return base.BuffAction<Firepower>(base.Value1 + firepowerBonus, 0, 0, 0, 0.2f);
			yield return base.BuffAction<Spirit>(base.Value2 + spiritBonus, 0, 0, 0, 0.2f);
			yield break;
		}
	}
}
