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
	[EntityLogic(typeof(ReimuUnifierNitoriLochNessSeDef))]
	public sealed class ReimuUnifierNitoriLochNessSe : StatusEffect
	{
		private int SePreviewTurns
		{
			get
			{
				return base.Level * base.Battle.Player.TurnCounter;
			}
		}

		protected override void OnAdded(Unit unit)
		{
			base.ReactOwnerEvent<UnitEventArgs>(base.Owner.TurnEnded, new EventSequencedReactor<UnitEventArgs>(this.OnOwnerTurnEnded));
		}

		private IEnumerable<BattleAction> OnOwnerTurnEnded(UnitEventArgs args)
		{
			bool flag = !base.Battle.BattleShouldEnd && base.Battle.EnemyGroup.Alives != null;
			if (flag)
			{
				base.NotifyActivating();
				yield return new DamageAction(base.Owner, base.Battle.EnemyGroup.Alives, DamageInfo.Reaction((float)base.Level * (float)base.Battle.Player.TurnCounter, false), "溺水B", GunType.Single);
			}
			yield break;
		}
	}
}
