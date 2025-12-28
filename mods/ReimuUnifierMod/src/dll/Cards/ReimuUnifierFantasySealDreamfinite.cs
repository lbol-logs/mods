using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoLEntitySideloader.Attributes;
using ReimuUnifierMod.Cards.Template;
using ReimuUnifierMod.StatusEffects;

namespace ReimuUnifierMod.Cards
{
	[EntityLogic(typeof(ReimuUnifierFantasySealDreamfiniteDef))]
	public sealed class ReimuUnifierFantasySealDreamfinite : ReimuUnifierCard
	{
		public override ManaGroup GetXCostFromPooled(ManaGroup pooledMana)
		{
			return pooledMana;
		}

		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			int ManaSpent = consumingMana.Amount;
			yield return base.BuffAction<ReimuUnifierFantasySealDreamfiniteSe>(base.Value1, 0, 0, ManaSpent, 0.2f);
			yield break;
		}
	}
}
