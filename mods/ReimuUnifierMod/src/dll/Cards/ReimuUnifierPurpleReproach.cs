using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoLEntitySideloader.Attributes;
using ReimuUnifierMod.Cards.Template;

namespace ReimuUnifierMod.Cards
{
	[EntityLogic(typeof(ReimuUnifierPurpleReproachDef))]
	public sealed class ReimuUnifierPurpleReproach : ReimuUnifierCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			yield return new AddCardsToHandAction(Library.CreateCards<ReimuUnifierYoukaiForgedNeedle>(base.Value1, this.IsUpgraded), AddCardsType.Normal, false);
			yield break;
		}
	}
}
