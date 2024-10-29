using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.StatusEffects;
using LBoLEntitySideloader.Attributes;
using YoumuCharacterMod.Cards.Template;
using YoumuCharacterMod.StatusEffects;

namespace YoumuCharacterMod.Cards
{
	[EntityLogic(typeof(YoumuAgelessObsessionDef))]
	public sealed class YoumuAgelessObsession : YoumuCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			foreach (BattleAction battleAction in base.DebuffAction<LockedOn>(base.Battle.AllAliveEnemies, base.Value1, 0, 0, 0, true, 0.2f))
			{
				yield return battleAction;
				battleAction = null;
			}
			IEnumerator<BattleAction> enumerator = null;
			bool flag = !base.Battle.BattleShouldEnd;
			if (flag)
			{
				yield return base.BuffAction<YoumuAgelessObsessionSe>(base.Value2, 0, 0, 0, 0.2f);
				yield break;
			}
			yield break;
			yield break;
		}
	}
}
