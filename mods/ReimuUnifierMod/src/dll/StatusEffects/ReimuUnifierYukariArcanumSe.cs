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
	[EntityLogic(typeof(ReimuUnifierYukariArcanumSeDef))]
	public sealed class ReimuUnifierYukariArcanumSe : StatusEffect
	{
		protected override void OnAdded(Unit unit)
		{
			base.ReactOwnerEvent<UnitEventArgs>(base.Owner.TurnStarted, new EventSequencedReactor<UnitEventArgs>(this.OnOwnerTurnStarted));
			base.ReactOwnerEvent<UnitEventArgs>(base.Owner.TurnEnded, new EventSequencedReactor<UnitEventArgs>(this.OnOwnerTurnEnded));
		}

		private IEnumerable<BattleAction> OnOwnerTurnStarted(UnitEventArgs args)
		{
			base.NotifyActivating();
			int count = base.Count;
			base.Count = count - 1;
			bool flag = base.Count <= 0;
			if (flag)
			{
				yield return new RemoveStatusEffectAction(this, true, 0.1f);
			}
			yield break;
		}

		private IEnumerable<BattleAction> OnOwnerTurnEnded(UnitEventArgs args)
		{
			base.NotifyActivating();
			yield return new CastBlockShieldAction(base.Battle.Player, 0, base.Level, BlockShieldType.Direct, false);
			bool flag = !base.Battle.BattleShouldEnd;
			if (flag)
			{
				EnemyUnit target = base.Battle.EnemyGroup.Alives.SampleOrDefault(base.Battle.GameRun.BattleRng);
				yield return new DamageAction(base.Battle.Player, target, DamageInfo.Reaction((float)base.Battle.Player.Shield, false), "结界猛击", GunType.Single);
				target = null;
			}
			yield break;
		}
	}
}
