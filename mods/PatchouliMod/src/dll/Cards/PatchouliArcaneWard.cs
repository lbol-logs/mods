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
	[EntityLogic(typeof(PatchouliArcaneWardDef))]
	public sealed class PatchouliArcaneWard : PatchouliBoostCard
	{
		public override int AdditionalBlock
		{
			get
			{
				return base.Boost * base.Value1;
			}
		}

		public override int AdditionalValue2
		{
			get
			{
				return base.Boost * base.Value1;
			}
		}

		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			yield return base.DefenseAction(true);
			yield return base.BuffAction<Reflect>(base.Value2, 0, 0, 0, 0.2f);
			bool flag = base.Battle.Player.HasStatusEffect<Reflect>();
			if (flag)
			{
				base.Battle.Player.GetStatusEffect<Reflect>().Gun = (this.IsUpgraded ? "弹幕对决B" : "弹幕对决");
			}
			base.ResetBoost();
			yield break;
		}
	}
}
