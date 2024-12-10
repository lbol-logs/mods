using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.EntityLib.StatusEffects.Basic;
using LBoLEntitySideloader.Attributes;

namespace Momiji.Source.Cards
{
	[EntityLogic(typeof(PreparedDefenseDef))]
	public sealed class PreparedDefense : SampleCharacterCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			yield return base.BuffAction<Reflect>(base.Value1, 0, 0, 0, 0.2f);
			int tempelec = base.Battle.Player.GetStatusEffect<Reflect>().Level;
			yield return new RemoveStatusEffectAction(base.Battle.Player.GetStatusEffect<Reflect>(), true, 0.1f);
			yield return base.BuffAction<TempElectric>(tempelec, 0, 0, 0, 0.2f);
			yield break;
		}
	}
}
