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
	[EntityLogic(typeof(PatchouliWaterElfDef))]
	public sealed class PatchouliWaterElf : PatchouliBoostCard
	{
		public override ManaGroup AdditionalCost
		{
			get
			{
				return base.Mana * -base.Boost;
			}
		}

		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			yield return base.AttackAction(selector, base.GunName);
			bool flag = !base.Battle.BattleShouldEnd;
			if (flag)
			{
				yield return base.BuffAction<PatchouliWaterSignSe>(base.Value1, 0, 0, PatchouliSignSe.TurnLimit, 0.2f);
				yield return base.BuffAction<PatchouliWoodSignSe>(base.Value1, 0, 0, PatchouliSignSe.TurnLimit, 0.2f);
			}
			base.ResetBoost();
			yield break;
		}
	}
}
