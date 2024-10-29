using System;
using System.Collections.Generic;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoLEntitySideloader.Attributes;

namespace Sanae_Kochiya.Source.StatusEffects
{
	[EntityLogic(typeof(SanaePowerPotatoSeDef))]
	public sealed class SanaePowerPotatoSe : StatusEffect
	{
		protected override void OnAdded(Unit unit)
		{
			base.ReactOwnerEvent<GameEventArgs>(base.Battle.BattleEnding, new EventSequencedReactor<GameEventArgs>(this.OnBattleEnding));
		}

		private IEnumerable<BattleAction> OnBattleEnding(GameEventArgs args)
		{
			bool isAlive = base.Battle.Player.IsAlive;
			if (isAlive)
			{
				base.NotifyActivating();
				base.GameRun.GainPower(base.Level, false);
			}
			yield break;
		}
	}
}
