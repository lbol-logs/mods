using System;
using System.Collections.Generic;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoL.EntityLib.StatusEffects.Enemy;
using LBoLEntitySideloader.Attributes;

namespace YoumuCharacterMod.StatusEffects
{
	[EntityLogic(typeof(YoumuYuyukoFriendSeDef))]
	public sealed class YoumuYuyukoFriendSe : StatusEffect
	{
		protected override void OnAdded(Unit unit)
		{
			base.ReactOwnerEvent<UnitEventArgs>(base.Battle.Player.TurnEnding, new EventSequencedReactor<UnitEventArgs>(this.OnTurnEnding));
		}

		private IEnumerable<BattleAction> OnTurnEnding(UnitEventArgs args)
		{
			base.NotifyActivating();
			foreach (Unit unit in base.Battle.AllAliveEnemies)
			{
				yield return new ApplyStatusEffectAction<YuyukoDeath>(unit, new int?(base.Level), new int?(0), new int?(0), new int?(0), 0.2f, true);
				unit = null;
			}
			IEnumerator<EnemyUnit> enumerator = null;
			yield break;
			yield break;
		}
	}
}
