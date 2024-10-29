using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoLEntitySideloader.Attributes;
using PatchouliCharacterMod.Cards.Template;

namespace PatchouliCharacterMod.Cards
{
	[EntityLogic(typeof(PatchouliNoachianDelugeDef))]
	public sealed class PatchouliNoachianDeluge : PatchouliBoostCard
	{
		protected override int BoostMax { get; } = 999;

		public override int AdditionalDamage
		{
			get
			{
				return base.Boost * base.Value1;
			}
		}

		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			yield return base.AttackAction(selector.SelectedEnemy);
			base.ResetBoost();
			yield break;
		}
	}
}
