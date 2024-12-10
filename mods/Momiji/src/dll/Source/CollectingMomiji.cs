using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoLEntitySideloader.Attributes;

namespace Momiji.Source
{
	[EntityLogic(typeof(CollectingMomijiDef))]
	public sealed class CollectingMomiji : SampleCharacterCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			yield return new AddCardsToHandAction(Library.CreateCards<MapleLeaf>(base.Value1, false), AddCardsType.Normal);
			yield break;
		}
	}
}
