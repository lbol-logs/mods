using System;
using System.Collections.Generic;
using System.Linq;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Battle.Interactions;
using LBoLEntitySideloader.Attributes;
using PatchouliCharacterMod.Cards.Template;
using PatchouliCharacterMod.StatusEffects;

namespace PatchouliCharacterMod.Cards
{
	[EntityLogic(typeof(PatchouliDiamondRingDef))]
	public sealed class PatchouliDiamondRing : PatchouliCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			yield return base.AttackAction(selector, base.GunName);
			bool flag = !base.Battle.BattleShouldEnd;
			if (flag)
			{
				List<PatchouliDiamondRing> list = Library.CreateCards<PatchouliDiamondRing>(2, this.IsUpgraded).ToList<PatchouliDiamondRing>();
				PatchouliDiamondRing first = list[0];
				PatchouliDiamondRing PatchouliDiamondRing = list[1];
				first.ShowWhichDescription = 1;
				PatchouliDiamondRing.ShowWhichDescription = 2;
				first.SetBattle(base.Battle);
				PatchouliDiamondRing.SetBattle(base.Battle);
				MiniSelectCardInteraction interaction = new MiniSelectCardInteraction(list, false, false, false)
				{
					Source = this
				};
				yield return new InteractionAction(interaction, false);
				bool flag2 = interaction.SelectedCard == first;
				if (flag2)
				{
					yield return base.BuffAction<PatchouliSunSignSe>(base.Value1, 0, 0, PatchouliSignSe.TurnLimit, 0.2f);
				}
				else
				{
					yield return base.BuffAction<PatchouliMoonSignSe>(base.Value1, 0, 0, PatchouliSignSe.TurnLimit, 0.2f);
				}
				list = null;
				first = null;
				PatchouliDiamondRing = null;
				interaction = null;
			}
			yield break;
		}
	}
}
