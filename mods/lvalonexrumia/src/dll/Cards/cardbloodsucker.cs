using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoLEntitySideloader.Attributes;
using lvalonexrumia.Cards.Template;

namespace lvalonexrumia.Cards
{
	[EntityLogic(typeof(cardbloodsuckerDef))]
	public sealed class cardbloodsucker : lvalonexrumiaCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			yield return base.AttackAction(selector, base.GunName);
			bool battleShouldEnd = base.Battle.BattleShouldEnd;
			if (battleShouldEnd)
			{
				yield break;
			}
			yield return new AddCardsToHandAction(Library.CreateCards<cardredblood>(base.Value1, false), AddCardsType.Normal);
			yield break;
		}
	}
}
