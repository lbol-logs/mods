using System;
using System.Collections.Generic;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoLEntitySideloader.Attributes;
using YoumuCharacterMod.BattleActions;

namespace YoumuCharacterMod.StatusEffects
{
	[EntityLogic(typeof(YoumuGreatEnlightenmentSeDef))]
	public sealed class YoumuGreatEnlightenmentSe : StatusEffect
	{
		protected override void OnAdded(Unit unit)
		{
			base.ReactOwnerEvent<UnitEventArgs>(base.Battle.Player.TurnStarted, new EventSequencedReactor<UnitEventArgs>(this.OnTurnStarted));
		}

		private IEnumerable<BattleAction> OnTurnStarted(UnitEventArgs args)
		{
			base.NotifyActivating();
			int num;
			for (int i = 0; i < base.Level; i = num + 1)
			{
				yield return new UnsheatheAllInHandAction();
				num = i;
			}
			yield break;
		}
	}
}
