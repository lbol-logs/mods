using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoLEntitySideloader.Attributes;
using PatchouliCharacterMod.Cards.Template;

namespace PatchouliCharacterMod.Cards
{
	[EntityLogic(typeof(PatchouliElementalHarvesterDef))]
	public sealed class PatchouliElementalHarvester : PatchouliBoostCard
	{
		public ManaGroup BonusMana
		{
			get
			{
				return new ManaGroup
				{
					Philosophy = base.Value2
				};
			}
		}

		protected override bool HasTreshold { get; set; } = true;

		protected override int BoostThreshold1 { get; set; } = 5;

		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			ManaGroup mana = base.Mana;
			bool flag = base.Boost >= this.BoostThreshold1;
			if (flag)
			{
				mana += this.BonusMana;
				base.ResetBoost();
			}
			yield return new GainManaAction(mana);
			yield break;
		}
	}
}
