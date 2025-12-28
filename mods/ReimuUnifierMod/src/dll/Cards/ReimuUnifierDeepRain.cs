using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.StatusEffects;
using LBoLEntitySideloader.Attributes;
using ReimuUnifierMod.Cards.Template;
using ReimuUnifierMod.StatusEffects;

namespace ReimuUnifierMod.Cards
{
	[EntityLogic(typeof(ReimuUnifierDeepRainDef))]
	public sealed class ReimuUnifierDeepRain : ReimuUnifierCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			yield return base.BuffAction<Graze>(base.Value1, 0, 0, 0, 0.2f);
			yield return base.BuffAction<ReimuUnifierNextAttackAccurateSe>(base.Value2, 0, 0, 0, 0.2f);
			yield break;
		}
	}
}
