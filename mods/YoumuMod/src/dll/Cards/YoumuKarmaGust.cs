using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoLEntitySideloader.Attributes;
using YoumuCharacterMod.Cards.Template;

namespace YoumuCharacterMod.Cards
{
	[EntityLogic(typeof(YoumuKarmaGustDef))]
	public sealed class YoumuKarmaGust : YoumuCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			foreach (Unit unit in base.Battle.AllAliveEnemies)
			{
				yield return base.DebuffAction<LockedOn>(unit, base.Value1, 0, 0, 0, true, 0.2f);
				yield return base.DebuffAction<Weak>(unit, 0, base.Value1, 0, 0, true, 0.2f);
				unit = null;
			}
			IEnumerator<EnemyUnit> enumerator = null;
			yield break;
			yield break;
		}
	}
}
