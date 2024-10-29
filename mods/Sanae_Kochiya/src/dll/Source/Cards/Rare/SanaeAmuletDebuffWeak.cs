using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.StatusEffects;
using LBoL.EntityLib.Cards;
using LBoLEntitySideloader.Attributes;

namespace Sanae_Kochiya.Source.Cards.Rare
{
	[EntityLogic(typeof(SanaeAmuletDebuffWeakDef))]
	public sealed class SanaeAmuletDebuffWeak : OptionCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			yield return base.BuffAction<Firepower>(base.Value1, 0, 0, 0, 0.1f);
			yield return base.DebuffAction<Weak>(base.Battle.Player, 0, base.Value1, 0, 0, true, 0.1f);
			yield break;
		}
	}
}
