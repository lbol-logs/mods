using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.StatusEffects;
using LBoL.EntityLib.StatusEffects.Basic;
using LBoLEntitySideloader.Attributes;

namespace Momiji.Source.Cards
{
	[EntityLogic(typeof(BloodScentDef))]
	public sealed class BloodScent : SampleCharacterCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			bool flag = base.PendingTarget.HasStatusEffect<Vulnerable>();
			if (flag)
			{
				yield return base.BuffAction<Reflect>(base.Value1, 0, 0, 0, 0.2f);
				bool flag2 = base.Battle.Player.HasStatusEffect<Reflect>();
				if (flag2)
				{
					base.Battle.Player.GetStatusEffect<Reflect>().Gun = (this.IsUpgraded ? "金刚体B" : "金刚体");
				}
			}
			yield return base.AttackAction(selector, base.GunName);
			yield break;
		}
	}
}
