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
	[EntityLogic(typeof(PatchouliFiveSeasonsSeDef))]
	public sealed class PatchouliFiveSeasonsSe : StatusEffect
	{
		protected override void OnAdded(Unit unit)
		{
			base.ReactOwnerEvent<UnitEventArgs>(base.Battle.Player.TurnEnding, new EventSequencedReactor<UnitEventArgs>(this.OnPlayerTurnEnding));
		}

		private IEnumerable<BattleAction> OnPlayerTurnEnding(UnitEventArgs args)
		{
			base.NotifyActivating();
			int num;
			for (int i = 0; i < base.Level; i = num + 1)
			{
				yield return new TriggerAllSignsPassiveAction();
				num = i;
			}
			yield break;
		}
	}
}
