using System;
using System.Collections.Generic;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoLEntitySideloader.Attributes;

namespace lvalonexrumia.StatusEffects
{
	[EntityLogic(typeof(seaccelDef))]
	public sealed class seaccel : StatusEffect
	{
		protected override void OnAdded(Unit unit)
		{
			base.ReactOwnerEvent<UnitEventArgs>(base.Owner.TurnStarted, new EventSequencedReactor<UnitEventArgs>(this.OnOwnerTurnStarting));
		}

		private IEnumerable<BattleAction> OnOwnerTurnStarting(UnitEventArgs args)
		{
			bool flag = !base.Battle.BattleShouldEnd;
			if (flag)
			{
				base.NotifyActivating();
				Unit owner = base.Owner;
				bool flag2 = owner != null && !owner.IsDead;
				if (flag2)
				{
					bool flag3 = base.Level <= 0;
					if (flag3)
					{
						yield return new RemoveStatusEffectAction(this, true, 0.1f);
						yield break;
					}
					yield return new ApplyStatusEffectAction<Graze>(base.Owner, new int?(base.Level), new int?(0), new int?(0), new int?(0), 0.2f, true);
					yield return new RemoveStatusEffectAction(this, true, 0.1f);
				}
				owner = null;
			}
			yield break;
		}
	}
}
