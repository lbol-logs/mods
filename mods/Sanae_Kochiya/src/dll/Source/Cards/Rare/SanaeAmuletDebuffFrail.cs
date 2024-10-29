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
	[EntityLogic(typeof(SanaeAmuletDebuffFrailDef))]
	public sealed class SanaeAmuletDebuffFrail : OptionCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			yield return base.BuffAction<Spirit>(base.Value1, 0, 0, 0, 0.1f);
			yield return base.DebuffAction<Fragil>(base.Battle.Player, 0, base.Value1, 0, 0, true, 0.1f);
			yield break;
		}
	}
}
