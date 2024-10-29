using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.EntityLib.StatusEffects.Basic;
using LBoLEntitySideloader.Attributes;
using PatchouliCharacterMod.Cards.Template;

namespace PatchouliCharacterMod.Cards
{
	[EntityLogic(typeof(PatchouliTidalWaveDef))]
	public sealed class PatchouliTidalWave : PatchouliBoostCard
	{
		protected override bool HasTreshold { get; set; } = true;

		protected override int BoostThreshold1 { get; set; } = 3;

		public override int AdditionalValue1
		{
			get
			{
				int num = 0;
				bool flag = base.Battle != null;
				int num2;
				if (flag)
				{
					bool flag2 = base.Boost >= this.BoostThreshold1;
					if (flag2)
					{
						num = base.Value2;
					}
					num2 = num;
				}
				else
				{
					num2 = 0;
				}
				return num2;
			}
		}

		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			int drowning = base.Value1;
			bool flag = selector.SelectedEnemy.HasStatusEffect<Drowning>();
			if (flag)
			{
				drowning = selector.SelectedEnemy.GetStatusEffect<Drowning>().Level + base.Value1;
			}
			yield return base.DebuffAction<Drowning>(selector.SelectedEnemy, drowning, 0, 0, 0, true, 0.2f);
			yield return DamageAction.Reaction(selector.SelectedEnemy, drowning, (drowning >= 15) ? "溺水BuffB" : "溺水BuffA");
			bool flag2 = base.Boost >= this.BoostThreshold1;
			if (flag2)
			{
				base.ResetBoost();
			}
			yield break;
		}
	}
}
