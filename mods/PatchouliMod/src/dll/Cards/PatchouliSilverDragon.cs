using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoLEntitySideloader.Attributes;
using PatchouliCharacterMod.BattleActions;
using PatchouliCharacterMod.Cards.Template;
using PatchouliCharacterMod.StatusEffects;

namespace PatchouliCharacterMod.Cards
{
	[EntityLogic(typeof(PatchouliSilverDragonDef))]
	public sealed class PatchouliSilverDragon : PatchouliCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			yield return base.DefenseAction(true);
			yield return base.BuffAction<PatchouliMetalSignSe>(base.Value1, 0, 0, PatchouliSignSe.TurnLimit, 0.2f);
			bool isUpgraded = this.IsUpgraded;
			if (isUpgraded)
			{
				yield return new TriggerSignPassiveAction(3);
			}
			yield break;
		}
	}
}
