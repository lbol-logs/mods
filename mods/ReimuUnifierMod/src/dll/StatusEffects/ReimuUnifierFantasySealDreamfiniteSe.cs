using System;
using System.Collections.Generic;
using LBoL.Base.Extensions;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Cards;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoLEntitySideloader.Attributes;

namespace ReimuUnifierMod.StatusEffects
{
	[EntityLogic(typeof(ReimuUnifierFantasySealDreamfiniteSeDef))]
	public sealed class ReimuUnifierFantasySealDreamfiniteSe : StatusEffect
	{
		protected override void OnAdded(Unit unit)
		{
			base.ReactOwnerEvent<UnitEventArgs>(base.Owner.TurnStarted, new EventSequencedReactor<UnitEventArgs>(this.OnOwnerTurnStarted));
		}

		private IEnumerable<BattleAction> OnOwnerTurnStarted(UnitEventArgs args)
		{
			base.NotifyActivating();
			int num;
			for (int i = 0; i < base.Count; i = num + 1)
			{
				EnemyUnit target = base.Battle.EnemyGroup.Alives.SampleOrDefault(base.Battle.GameRun.BattleRng);
				yield return new DamageAction(base.Battle.Player, target, DamageInfo.Reaction((float)base.Level, false), "退魔符乱舞", GunType.Single);
				target = null;
				num = i;
			}
			yield break;
		}
	}
}
