using System;
using System.Collections.Generic;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoLEntitySideloader.Attributes;

namespace Momiji.Source.StatusEffects
{
	[EntityLogic(typeof(SenseWeaknessSeDef))]
	public sealed class SenseWeaknessSe : StatusEffect
	{
		protected override void OnAdded(Unit unit)
		{
			base.ReactOwnerEvent<GameEventArgs>(base.Battle.BattleEnding, new EventSequencedReactor<GameEventArgs>(this.OnBattleEnding));
			base.GameRun.EnemyVulnerableExtraPercentage += base.Level;
		}

		public override bool Stack(StatusEffect other)
		{
			base.GameRun.EnemyVulnerableExtraPercentage += other.Level;
			return base.Stack(other);
		}

		private IEnumerable<BattleAction> OnBattleEnding(GameEventArgs args)
		{
			base.GameRun.EnemyVulnerableExtraPercentage -= base.Level;
			yield break;
		}
	}
}
