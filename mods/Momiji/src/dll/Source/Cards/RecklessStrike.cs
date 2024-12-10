using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoLEntitySideloader.Attributes;

namespace Momiji.Source.Cards
{
	[EntityLogic(typeof(RecklessStrikeDef))]
	public sealed class RecklessStrike : SampleCharacterCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			EnemyUnit selectedEnemy = selector.SelectedEnemy;
			yield return base.AttackAction(selector, base.GunName);
			yield return new ApplyStatusEffectAction<Vulnerable>(selectedEnemy, new int?(0), new int?(base.Value1), new int?(0), new int?(0), 0.2f, true);
			yield return new ApplyStatusEffectAction<Fragil>(base.Battle.Player, new int?(0), new int?(base.Value2), new int?(0), new int?(0), 0.2f, true);
			yield break;
		}
	}
}
