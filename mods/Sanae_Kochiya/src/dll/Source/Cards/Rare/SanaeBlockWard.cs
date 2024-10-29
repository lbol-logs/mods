using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.EntityLib.StatusEffects.Basic;
using LBoLEntitySideloader.Attributes;
using Sanae_Kochiya.Cards.Template;

namespace Sanae_Kochiya.Source.Cards.Rare
{
	[EntityLogic(typeof(SanaeBlockWardDef))]
	public sealed class SanaeBlockWard : SampleCharacterCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			int num;
			for (int i = 0; i < base.Value1; i = num + 1)
			{
				yield return base.DefenseAction(true);
				num = i;
			}
			for (int j = 0; j < base.Value1; j = num + 1)
			{
				yield return base.BuffAction<AmuletForCard>(base.Value2, 0, 0, 0, 0.2f);
				num = j;
			}
			yield break;
		}
	}
}
