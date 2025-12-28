using System;
using System.Collections.Generic;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Cards;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoLEntitySideloader.Attributes;

namespace ReimuUnifierMod.StatusEffects
{
	[EntityLogic(typeof(ReimuUnifierDarknessOfTheCrowSeDef))]
	public sealed class ReimuUnifierDarknessOfTheCrowSe : StatusEffect
	{
		private string GunName
		{
			get
			{
				return (base.Level <= 20) ? "无差别起火" : "无差别起火B";
			}
		}

		protected override void OnAdded(Unit unit)
		{
			base.ReactOwnerEvent<UnitEventArgs>(base.Owner.TurnEnded, new EventSequencedReactor<UnitEventArgs>(this.OnOwnerTurnEnded));
			base.ReactOwnerEvent<DamageEventArgs>(base.Battle.Player.DamageReceived, new EventSequencedReactor<DamageEventArgs>(this.OnPlayerDamageReceived));
		}

		private IEnumerable<BattleAction> OnOwnerTurnEnded(UnitEventArgs args)
		{
			bool flag = !base.Battle.BattleShouldEnd && base.Battle.EnemyGroup.Alives != null;
			if (flag)
			{
				base.NotifyActivating();
				yield return new DamageAction(base.Owner, base.Battle.EnemyGroup.Alives, DamageInfo.Reaction((float)base.Level, false), this.GunName, GunType.Single);
			}
			yield break;
		}

		private IEnumerable<BattleAction> OnPlayerDamageReceived(DamageEventArgs args)
		{
			bool flag = args.DamageInfo.IsGrazed && !base.Battle.BattleShouldEnd && base.Battle.EnemyGroup.Alives != null;
			if (flag)
			{
				base.NotifyActivating();
				yield return new DamageAction(base.Owner, base.Battle.EnemyGroup.Alives, DamageInfo.Reaction((float)base.Level, false), this.GunName, GunType.Single);
			}
			yield break;
		}
	}
}
