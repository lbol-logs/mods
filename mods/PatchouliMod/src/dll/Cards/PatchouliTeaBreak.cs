using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.StatusEffects;
using LBoLEntitySideloader.Attributes;
using PatchouliCharacterMod.Cards.Template;

namespace PatchouliCharacterMod.Cards
{
	[EntityLogic(typeof(PatchouliTeaBreakDef))]
	public sealed class PatchouliTeaBreak : PatchouliCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			yield return base.HealAction(base.Value1);
			Vulnerable vulnerable = base.Battle.Player.GetStatusEffect<Vulnerable>();
			bool flag = vulnerable != null;
			if (flag)
			{
				yield return new RemoveStatusEffectAction(vulnerable, true, 0.1f);
			}
			bool isUpgraded = this.IsUpgraded;
			if (isUpgraded)
			{
				Weak weak = base.Battle.Player.GetStatusEffect<Weak>();
				bool flag2 = weak != null;
				if (flag2)
				{
					yield return new RemoveStatusEffectAction(weak, true, 0.1f);
				}
				LockedOn lockedOn = base.Battle.Player.GetStatusEffect<LockedOn>();
				bool flag3 = lockedOn != null;
				if (flag3)
				{
					yield return new RemoveStatusEffectAction(lockedOn, true, 0.1f);
				}
				weak = null;
				lockedOn = null;
			}
			yield break;
		}
	}
}
