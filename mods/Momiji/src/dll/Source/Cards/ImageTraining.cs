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
	[EntityLogic(typeof(ImageTrainingDef))]
	public sealed class ImageTraining : SampleCharacterCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			yield return new AddCardsToHandAction(Library.CreateCards<AirCutter>(1, false), AddCardsType.Normal);
			yield return base.BuffAction<ImageTrainingSe>(1, 0, 0, 0, 0.2f);
			yield break;
		}
	}
}
