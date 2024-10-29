using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.StatusEffects;
using LBoLEntitySideloader.Attributes;
using YoumuCharacterMod.Cards.Template;

namespace YoumuCharacterMod.Cards
{
	[EntityLogic(typeof(YoumuStrangeBirdDef))]
	public sealed class YoumuStrangeBird : YoumuCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			yield return base.DebuffAction<LockedOn>(selector.SelectedEnemy, base.Value1, 0, 0, 0, true, 0.2f);
			yield return base.BuffAction<Graze>(base.Value1, 0, 0, 0, 0.2f);
			yield break;
		}
	}
}
