using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.StatusEffects;
using LBoLEntitySideloader.Attributes;
using Sanae_Kochiya.Cards.Template;

namespace Sanae_Kochiya.Source.Cards.Uncommon
{
	[EntityLogic(typeof(SanaeSpiritShuffleDef))]
	public sealed class SanaeSpiritShuffle : SampleCharacterCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			yield return base.BuffAction<TempSpirit>(base.Value1, 0, 0, 0, 0.2f);
			yield return new ReshuffleAction();
			yield return new DrawManyCardAction(base.Value2);
			yield break;
		}
	}
}
