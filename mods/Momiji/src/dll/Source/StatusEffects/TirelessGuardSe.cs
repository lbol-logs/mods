using System;
using System.Collections.Generic;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoL.EntityLib.StatusEffects.Basic;
using LBoLEntitySideloader.Attributes;

namespace Momiji.Source.StatusEffects
{
	[EntityLogic(typeof(TirelessGuardSeDef))]
	public sealed class TirelessGuardSe : StatusEffect
	{
		protected override void OnAdded(Unit unit)
		{
			base.ReactOwnerEvent<StatusEffectEventArgs>(base.Battle.Player.StatusEffectRemoved, new EventSequencedReactor<StatusEffectEventArgs>(this.StatusEffectRemoved));
		}

		private IEnumerable<BattleAction> StatusEffectRemoved(StatusEffectEventArgs args)
		{
			bool flag = base.Battle.Player.HasStatusEffect<TwinFangSe>();
			if (flag)
			{
				yield break;
			}
			bool flag2 = args.ActionSource is Reflect;
			if (flag2)
			{
				int reflectLevel = args.Effect.Level;
				bool flag3 = (float)reflectLevel > 0f;
				if (flag3)
				{
					reflectLevel /= 2;
					yield return new ApplyStatusEffectAction<Reflect>(base.Battle.Player, new int?(reflectLevel), new int?(0), new int?(0), new int?(0), 0.2f, true);
					bool flag4 = base.Battle.Player.HasStatusEffect<Reflect>();
					if (flag4)
					{
						base.Battle.Player.GetStatusEffect<Reflect>().Gun = "心抄斩";
					}
				}
			}
			yield break;
		}
	}
}
