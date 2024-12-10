using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoLEntitySideloader.Attributes;
using Momiji.Source.StatusEffects;

namespace Momiji.Source.Cards
{
	[EntityLogic(typeof(HowlingMountainWindDef))]
	public sealed class HowlingMountainWind : SampleCharacterCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			yield return new AddCardsToHandAction(Library.CreateCards<AirCutter>(base.Value2, false), AddCardsType.Normal);
			yield return new ApplyStatusEffectAction<HowlingMountainWindSe>(base.Battle.Player, new int?(1), new int?(0), new int?(0), new int?(0), 0.2f, true);
			yield break;
		}
	}
}
