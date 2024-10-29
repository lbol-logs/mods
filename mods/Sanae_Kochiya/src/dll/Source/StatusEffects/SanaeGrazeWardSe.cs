using System;
using System.Collections.Generic;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoL.EntityLib.StatusEffects.Basic;
using LBoLEntitySideloader.Attributes;

namespace Sanae_Kochiya.Source.StatusEffects
{
	[EntityLogic(typeof(SanaeGrazeWardSeDef))]
	public sealed class SanaeGrazeWardSe : StatusEffect
	{
		protected override void OnAdded(Unit unit)
		{
			base.ReactOwnerEvent<DamageEventArgs>(base.Battle.Player.DamageReceived, new EventSequencedReactor<DamageEventArgs>(this.OnPlayerDamageReceived));
		}

		private IEnumerable<BattleAction> OnPlayerDamageReceived(DamageEventArgs args)
		{
			bool isGrazed = args.DamageInfo.IsGrazed;
			if (isGrazed)
			{
				base.NotifyActivating();
				yield return new ApplyStatusEffectAction<AmuletForCard>(base.Owner, new int?(base.Level), null, null, null, 0f, true);
			}
			yield break;
		}
	}
}
