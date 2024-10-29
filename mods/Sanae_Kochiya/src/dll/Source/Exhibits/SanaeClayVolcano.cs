using System;
using System.Collections.Generic;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.StatusEffects;
using LBoLEntitySideloader.Attributes;

namespace Sanae_Kochiya.Source.Exhibits
{
	[EntityLogic(typeof(SanaeClayVolcanoDef))]
	public sealed class SanaeClayVolcano : Exhibit
	{
		protected override void OnEnterBattle()
		{
			base.ReactBattleEvent<GameEventArgs>(base.Battle.Reshuffled, new EventSequencedReactor<GameEventArgs>(this.OnReshuffled));
		}

		private IEnumerable<BattleAction> OnReshuffled(GameEventArgs args)
		{
			base.NotifyActivating();
			yield return new ApplyStatusEffectAction<TempSpirit>(base.Owner, new int?(base.Value1), new int?(0), new int?(0), new int?(0), 0.2f, true);
			yield break;
		}
	}
}
