using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoLEntitySideloader.Attributes;

namespace ReimuUnifierMod.ReimuUnifierUlt
{
	[EntityLogic(typeof(ReimuUnifierUltBDef))]
	public sealed class ReimuUnifierUltB : UltimateSkill
	{
		public ReimuUnifierUltB()
		{
			base.TargetType = TargetType.Nobody;
		}

		protected override IEnumerable<BattleAction> Actions(UnitSelector selector)
		{
			yield return PerformAction.Spell(base.Owner, "ReimuUnifierUltB");
			yield return new ApplyStatusEffectAction<Invincible>(base.Battle.Player, new int?(0), new int?(1), null, null, 0f, true);
			bool flag = base.Battle.Player.HasStatusEffect<Weak>();
			if (flag)
			{
				yield return new RemoveStatusEffectAction(base.Battle.Player.GetStatusEffect<Weak>(), true, 0.1f);
			}
			bool flag2 = base.Battle.Player.HasStatusEffect<Vulnerable>();
			if (flag2)
			{
				yield return new RemoveStatusEffectAction(base.Battle.Player.GetStatusEffect<Vulnerable>(), true, 0.1f);
			}
			bool flag3 = base.Battle.Player.HasStatusEffect<Fragil>();
			if (flag3)
			{
				yield return new RemoveStatusEffectAction(base.Battle.Player.GetStatusEffect<Fragil>(), true, 0.1f);
			}
			yield break;
		}
	}
}
