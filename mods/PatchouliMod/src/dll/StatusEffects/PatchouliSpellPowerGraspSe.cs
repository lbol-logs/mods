using System;
using System.Collections.Generic;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoLEntitySideloader.Attributes;
using PatchouliCharacterMod.BattleActions;

namespace PatchouliCharacterMod.StatusEffects
{
	[EntityLogic(typeof(PatchouliSpellPowerGraspSeDef))]
	public sealed class PatchouliSpellPowerGraspSe : StatusEffect
	{
		protected override void OnAdded(Unit unit)
		{
			base.ReactOwnerEvent<UnitEventArgs>(base.Battle.Player.TurnStarted, new EventSequencedReactor<UnitEventArgs>(this.OnPlayerTurnStarted));
		}

		private IEnumerable<BattleAction> OnPlayerTurnStarted(UnitEventArgs args)
		{
			base.NotifyActivating();
			yield return new BoostAllInHandAction(base.Level);
			yield break;
		}
	}
}
