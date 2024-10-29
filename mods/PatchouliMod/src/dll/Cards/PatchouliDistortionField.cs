using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.StatusEffects;
using LBoLEntitySideloader.Attributes;
using PatchouliCharacterMod.BattleActions;
using PatchouliCharacterMod.Cards.Template;

namespace PatchouliCharacterMod.Cards
{
	[EntityLogic(typeof(PatchouliDistortionFieldDef))]
	public sealed class PatchouliDistortionField : PatchouliCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			yield return base.BuffAction<Graze>(base.Value1, 0, 0, 0, 0.2f);
			yield return new BoostAllInHandAction(base.Value2);
			bool isUpgraded = this.IsUpgraded;
			if (isUpgraded)
			{
				yield return new BoostAllInHandAction(base.Value2);
			}
			yield break;
		}
	}
}
