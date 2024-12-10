using System;
using System.Collections.Generic;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoLEntitySideloader.Attributes;

namespace Momiji.Source.StatusEffects
{
	[EntityLogic(typeof(FeedOnTheWeakSeDef))]
	public sealed class FeedOnTheWeakSe : StatusEffect
	{
		protected override void OnAdded(Unit unit)
		{
			base.Owner.ReactBattleEvent<DieEventArgs>(base.Battle.EnemyDied, new Func<DieEventArgs, IEnumerable<BattleAction>>(this.OnEnemyDied));
		}

		private IEnumerable<BattleAction> OnEnemyDied(DieEventArgs args)
		{
			bool flag = !args.Unit.HasStatusEffect<Servant>();
			if (flag)
			{
				yield return new GainPowerAction(10);
				yield return new HealAction(base.Battle.Player, base.Battle.Player, 4, HealType.Normal, 0.2f);
			}
			yield break;
		}
	}
}
