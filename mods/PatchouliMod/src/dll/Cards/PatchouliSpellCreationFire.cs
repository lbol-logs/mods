using System;
using System.Collections.Generic;
using LBoL.Core.Battle;
using LBoL.EntityLib.Cards;
using LBoLEntitySideloader.Attributes;
using PatchouliCharacterMod.StatusEffects;

namespace PatchouliCharacterMod.Cards
{
	[EntityLogic(typeof(PatchouliSpellCreationFireDef))]
	public sealed class PatchouliSpellCreationFire : OptionCard
	{
		public override IEnumerable<BattleAction> TakeEffectActions()
		{
			yield return base.BuffAction<PatchouliFireSignSe>(base.Value1, 0, 0, PatchouliSignSe.TurnLimit, 0.2f);
			yield break;
		}
	}
}
