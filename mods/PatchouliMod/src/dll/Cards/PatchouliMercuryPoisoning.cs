using System;
using System.Collections.Generic;
using System.Linq;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Battle.Interactions;
using LBoL.Core.StatusEffects;
using LBoL.EntityLib.StatusEffects.Others;
using LBoLEntitySideloader.Attributes;
using PatchouliCharacterMod.Cards.Template;
using PatchouliCharacterMod.StatusEffects;

namespace PatchouliCharacterMod.Cards
{
	[EntityLogic(typeof(PatchouliMercuryPoisoningDef))]
	public sealed class PatchouliMercuryPoisoning : PatchouliCard
	{
		public int Value3 { get; set; } = 1;

		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			yield return base.BuffAction<PatchouliMetalSignSe>(this.Value3, 0, 0, PatchouliSignSe.TurnLimit, 0.2f);
			List<PatchouliMercuryPoisoning> list = Library.CreateCards<PatchouliMercuryPoisoning>(2, this.IsUpgraded).ToList<PatchouliMercuryPoisoning>();
			PatchouliMercuryPoisoning first = list[0];
			PatchouliMercuryPoisoning PatchouliMercuryPoisoning = list[1];
			first.ShowWhichDescription = 1;
			PatchouliMercuryPoisoning.ShowWhichDescription = 2;
			first.SetBattle(base.Battle);
			PatchouliMercuryPoisoning.SetBattle(base.Battle);
			MiniSelectCardInteraction interaction = new MiniSelectCardInteraction(list, false, false, false)
			{
				Source = this
			};
			yield return new InteractionAction(interaction, false);
			bool flag = interaction.SelectedCard == first;
			if (flag)
			{
				yield return base.DebuffAction<Poison>(selector.SelectedEnemy, base.Value1, 0, 0, 0, true, 0.2f);
			}
			else
			{
				yield return base.DebuffAction<Weak>(selector.SelectedEnemy, 0, base.Value2, 0, 0, true, 0.2f);
			}
			yield break;
		}
	}
}
