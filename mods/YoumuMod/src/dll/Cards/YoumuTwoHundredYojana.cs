using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoLEntitySideloader.Attributes;
using YoumuCharacterMod.BattleActions;
using YoumuCharacterMod.Cards.Template;

namespace YoumuCharacterMod.Cards
{
	[EntityLogic(typeof(YoumuTwoHundredYojanaDef))]
	public sealed class YoumuTwoHundredYojana : YoumuCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			yield return new AddCardsToHandAction(Library.CreateCards<YoumuSlashOfPresent>(base.Value1, this.IsUpgraded), AddCardsType.Normal);
			yield return new UnsheatheAllInHandAction();
			yield break;
		}
	}
}
