using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.StatusEffects;
using LBoLEntitySideloader.Attributes;

namespace Momiji.Source.Cards
{
	[EntityLogic(typeof(FollowUpDef))]
	public sealed class FollowUp : SampleCharacterCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			yield return base.AttackAction(selector, base.GunName);
			bool flag = base.PendingTarget.HasStatusEffect<Vulnerable>();
			if (flag)
			{
				yield return new GainManaAction(base.Mana);
			}
			yield break;
		}
	}
}
