using System;
using System.Collections.Generic;
using LBoL.Core.Battle;
using LBoL.EntityLib.Cards;
using LBoLEntitySideloader.Attributes;
using PatchouliCharacterMod.StatusEffects;

namespace PatchouliCharacterMod.Cards
{
	[EntityLogic(typeof(PatchouliElementalTriangleWaterDef))]
	public sealed class PatchouliElementalTriangleWater : OptionCard
	{
		public override IEnumerable<BattleAction> TakeEffectActions()
		{
			yield return base.BuffAction<PatchouliWaterSignSe>(base.Value1, 0, 0, PatchouliSignSe.TurnLimit, 0.2f);
			yield break;
		}
	}
}
