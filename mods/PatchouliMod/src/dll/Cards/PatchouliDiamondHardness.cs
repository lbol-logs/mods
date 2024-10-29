using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.EntityLib.StatusEffects.Basic;
using LBoLEntitySideloader.Attributes;
using PatchouliCharacterMod.Cards.Template;

namespace PatchouliCharacterMod.Cards
{
	[EntityLogic(typeof(PatchouliDiamondHardnessDef))]
	public sealed class PatchouliDiamondHardness : PatchouliBoostCard
	{
		protected override bool HasTreshold { get; set; } = true;

		protected override int BoostThreshold1 { get; set; } = 3;

		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			yield return base.DefenseAction(true);
			yield return base.BuffAction<Reflect>(base.Value1, 0, 0, 0, 0.2f);
			bool flag = base.Battle.Player.HasStatusEffect<Reflect>();
			if (flag)
			{
				base.Battle.Player.GetStatusEffect<Reflect>().Gun = (this.IsUpgraded ? "弹幕对决B" : "弹幕对决");
			}
			bool flag2 = base.Boost >= this.BoostThreshold1;
			if (flag2)
			{
				yield return base.BuffAction<TempElectric>(base.Value2, 0, 0, 0, 0.2f);
				base.ResetBoost();
			}
			yield break;
		}
	}
}
