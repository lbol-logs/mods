using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoLEntitySideloader.Attributes;

namespace Momiji.Source
{
	[EntityLogic(typeof(CleavingSwipeDef))]
	public sealed class CleavingSwipe : SampleCharacterCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			yield return base.AttackAction(selector, base.GunName);
			bool isUpgraded = this.IsUpgraded;
			if (isUpgraded)
			{
				yield return base.AttackAction(selector, base.GunName);
			}
			bool battleShouldEnd = base.Battle.BattleShouldEnd;
			if (battleShouldEnd)
			{
				yield break;
			}
			yield return new DrawManyCardAction(base.Value1);
			yield break;
		}
	}
}
