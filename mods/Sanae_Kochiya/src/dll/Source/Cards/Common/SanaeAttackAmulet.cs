using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.EntityLib.StatusEffects.Basic;
using LBoLEntitySideloader.Attributes;
using Sanae_Kochiya.Cards.Template;

namespace Sanae_Kochiya.Source.Cards.Common
{
	[EntityLogic(typeof(SanaeAttackAmuletDef))]
	public sealed class SanaeAttackAmulet : SampleCharacterCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			yield return base.AttackAction(selector, null);
			bool flag = !base.Battle.Player.HasStatusEffect<Amulet>();
			if (flag)
			{
				yield return base.BuffAction<Amulet>(base.Value1, 0, 0, 0, 0.2f);
			}
			yield break;
		}
	}
}
