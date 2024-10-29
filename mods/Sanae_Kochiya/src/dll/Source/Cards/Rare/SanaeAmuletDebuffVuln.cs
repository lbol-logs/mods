using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.StatusEffects;
using LBoL.EntityLib.Cards;
using LBoL.EntityLib.StatusEffects.Others;
using LBoLEntitySideloader.Attributes;

namespace Sanae_Kochiya.Source.Cards.Rare
{
	[EntityLogic(typeof(SanaeAmuletDebuffVulnDef))]
	public sealed class SanaeAmuletDebuffVuln : OptionCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			base.GameRun.GainMaxHp(base.Value1, true, true);
			yield return base.DebuffAction<Vulnerable>(base.Battle.Player, 0, base.Value1, 0, 0, true, 0.1f);
			yield return base.DebuffAction<Poison>(base.Battle.Player, base.Value1, 0, 0, 0, true, 0.1f);
			yield break;
		}
	}
}
