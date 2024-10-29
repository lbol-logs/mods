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
	[EntityLogic(typeof(YoumuWickedSoulDef))]
	public sealed class YoumuWickedSoul : YoumuCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			EnemyUnit selectedEnemy = selector.SelectedEnemy;
			yield return base.DebuffAction<LockedOn>(selectedEnemy, base.Value1, 0, 0, 0, true, 0.2f);
			yield return base.DebuffAction<FirepowerNegative>(selectedEnemy, base.Value2, 0, 0, 0, true, 0.2f);
			yield break;
		}
	}
}
