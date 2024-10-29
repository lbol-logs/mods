using System;
using System.Collections.Generic;
using System.Linq;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Battle.Interactions;
using LBoL.Core.StatusEffects;
using LBoLEntitySideloader.Attributes;
using PatchouliCharacterMod.Cards.Template;

namespace PatchouliCharacterMod.Cards
{
	[EntityLogic(typeof(PatchouliSungrazerCometDef))]
	public sealed class PatchouliSungrazerComet : PatchouliBoostCard
	{
		protected override bool HasTreshold { get; set; } = true;

		protected override int BoostThreshold1 { get; set; } = 4;

		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			bool flag = base.Boost >= this.BoostThreshold1;
			if (flag)
			{
				yield return base.BuffAction<Graze>(base.Value1, 0, 0, 0, 0.2f);
				yield return base.DefenseAction(true);
				base.ResetBoost();
			}
			else
			{
				List<PatchouliSungrazerComet> list = Library.CreateCards<PatchouliSungrazerComet>(2, this.IsUpgraded).ToList<PatchouliSungrazerComet>();
				PatchouliSungrazerComet first = list[0];
				PatchouliSungrazerComet PatchouliSungrazerComet = list[1];
				first.ShowWhichDescription = 1;
				PatchouliSungrazerComet.ShowWhichDescription = 2;
				first.SetBattle(base.Battle);
				PatchouliSungrazerComet.SetBattle(base.Battle);
				MiniSelectCardInteraction interaction = new MiniSelectCardInteraction(list, false, false, false)
				{
					Source = this
				};
				yield return new InteractionAction(interaction, false);
				bool flag2 = interaction.SelectedCard == first;
				if (flag2)
				{
					yield return base.BuffAction<Graze>(base.Value1, 0, 0, 0, 0.2f);
				}
				else
				{
					yield return base.DefenseAction(true);
				}
				list = null;
				first = null;
				PatchouliSungrazerComet = null;
				interaction = null;
			}
			yield break;
		}
	}
}
