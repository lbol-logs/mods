using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.StatusEffects;
using LBoLEntitySideloader.Attributes;

namespace Momiji.Source.Cards
{
	[EntityLogic(typeof(RipApartDef))]
	public sealed class RipApart : SampleCharacterCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			yield return base.AttackAction(selector, base.GunName);
			bool isUpgraded = this.IsUpgraded;
			if (isUpgraded)
			{
				yield return base.AttackAction(selector, base.GunName);
			}
			bool battleShouldEnd = base.Battle.BattleShouldEnd;
			if (battleShouldEnd)
			{
				yield break;
			}
			foreach (BattleAction battleAction in base.DebuffAction<Vulnerable>(base.Battle.AllAliveEnemies, 0, base.Value1, 0, 0, true, 0.03f))
			{
				yield return battleAction;
				battleAction = null;
			}
			IEnumerator<BattleAction> enumerator = null;
			yield break;
			yield break;
		}
	}
}
