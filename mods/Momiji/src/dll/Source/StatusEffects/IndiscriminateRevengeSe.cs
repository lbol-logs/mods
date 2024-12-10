using System;
using System.Collections.Generic;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Cards;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoL.EntityLib.StatusEffects.Basic;
using LBoLEntitySideloader.Attributes;

namespace Momiji.Source.StatusEffects
{
	[EntityLogic(typeof(IndiscriminateRevengeSeDef))]
	public sealed class IndiscriminateRevengeSe : StatusEffect
	{
		protected override void OnAdded(Unit unit)
		{
			base.ReactOwnerEvent<StatusEffectEventArgs>(base.Battle.Player.StatusEffectRemoved, new EventSequencedReactor<StatusEffectEventArgs>(this.StatusEffectRemoved));
		}

		private IEnumerable<BattleAction> StatusEffectRemoved(StatusEffectEventArgs args)
		{
			bool flag = args.ActionSource is Reflect;
			if (flag)
			{
				int retalLevel = base.Battle.Player.GetStatusEffect<RetaliationSe>().Level;
				bool flag2 = (float)retalLevel > 0f;
				if (flag2)
				{
					yield return new DamageAction(base.Battle.Player, base.Battle.EnemyGroup.Alives, DamageInfo.Reaction((float)retalLevel, false), "Instant", GunType.Single);
				}
			}
			yield break;
		}

		private bool hasActivated = false;
	}
}
