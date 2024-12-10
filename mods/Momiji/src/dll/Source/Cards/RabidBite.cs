using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Units;
using LBoLEntitySideloader.Attributes;

namespace Momiji.Source.Cards
{
	[EntityLogic(typeof(RabidBiteDef))]
	public sealed class RabidBite : SampleCharacterCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			EnemyUnit selectedEnemy = selector.SelectedEnemy;
			yield return base.AttackAction(selector, base.GunName);
			yield return base.HealAction(base.Value1);
			yield break;
		}
	}
}
