using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.StatusEffects;
using LBoLEntitySideloader.Attributes;
using ReimuUnifierMod.Cards.Template;
using ReimuUnifierMod.StatusEffects;

namespace ReimuUnifierMod.Cards
{
	[EntityLogic(typeof(ReimuUnifierInnateDreamDef))]
	public sealed class ReimuUnifierInnateDream : ReimuUnifierCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			bool flag = base.Battle.Player.HasStatusEffect<ReimuUnifierInnateDreamCounterSe>();
			if (flag)
			{
				bool flag2 = base.Battle.Player.GetStatusEffect<ReimuUnifierInnateDreamCounterSe>().Level >= 7;
				if (flag2)
				{
					base.IsExile = true;
					yield return base.BuffAction<Invincible>(0, 99, 0, 0, 0.2f);
					yield return new RemoveStatusEffectAction(base.Battle.Player.GetStatusEffect<ReimuUnifierInnateDreamCounterSe>(), true, 0.1f);
					yield break;
				}
			}
			yield return base.BuffAction<ReimuUnifierInnateDreamCounterSe>(1, 0, 0, 0, 0.2f);
			yield break;
		}
	}
}
