using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Cards;
using LBoLEntitySideloader.Attributes;
using YoumuCharacterMod.BattleActions;
using YoumuCharacterMod.Cards.Template;

namespace YoumuCharacterMod.Cards
{
	[EntityLogic(typeof(YoumuPreachingAviciDef))]
	public sealed class YoumuPreachingAvici : YoumuCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			yield return new AddCardsToHandAction(Library.CreateCards<YoumuSlashOfPresent>(base.Value1, false), AddCardsType.Normal);
			yield break;
		}

		public override IEnumerable<BattleAction> OnExile(CardZone srcZone)
		{
			bool battleShouldEnd = base.Battle.BattleShouldEnd;
			if (battleShouldEnd)
			{
				yield break;
			}
			yield return new UnsheatheAllInHandAction();
			yield break;
		}
	}
}
