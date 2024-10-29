using System;
using System.Collections.Generic;
using System.Linq;
using LBoL.Base;
using LBoL.Base.Extensions;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Units;
using LBoLEntitySideloader.Attributes;
using Sanae_Kochiya.Cards.Template;

namespace Sanae_Kochiya.Source.Cards.Common
{
	[EntityLogic(typeof(SanaeAttackGrazeDef))]
	public sealed class SanaeAttackGraze : SampleCharacterCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			int Count = base.Battle.AllAliveEnemies.Count<EnemyUnit>();
			int num = Math.Min(base.Value1, Count);
			List<EnemyUnit> List = base.Battle.AllAliveEnemies.ToList<EnemyUnit>();
			int num2;
			for (int i = 0; i < num; i = num2 + 1)
			{
				EnemyUnit Enemy = List.Sample(base.BattleRng);
				yield return base.AttackAction(Enemy);
				List.Remove(Enemy);
				Enemy = null;
				num2 = i;
			}
			yield return new GainManaAction(new ManaGroup
			{
				Green = num
			});
			yield break;
		}
	}
}
