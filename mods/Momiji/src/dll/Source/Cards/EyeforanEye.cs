using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Cards;
using LBoL.Core.Units;
using LBoLEntitySideloader.Attributes;

namespace Momiji.Source.Cards
{
	[EntityLogic(typeof(EyeforanEyeDef))]
	public sealed class EyeforanEye : SampleCharacterCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			EnemyUnit selectedEnemy = selector.SelectedEnemy;
			yield return base.AttackAction(selector, base.GunName);
			bool flag = !selectedEnemy.IsAlive;
			if (flag)
			{
				yield break;
			}
			yield return new DamageAction(selectedEnemy, base.Battle.Player, DamageInfo.Attack((float)base.Value1, false), "Instant", GunType.Single);
			yield break;
		}
	}
}
