using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Cards;
using LBoLEntitySideloader.Attributes;
using Sanae_Kochiya.Cards.Template;

namespace Sanae_Kochiya.Source.Cards.Uncommon
{
	[EntityLogic(typeof(SanaeAttackCopyDef))]
	public sealed class SanaeAttackCopy : SampleCharacterCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			yield return base.AttackAction(selector, null);
			Card card = base.CloneBattleCard();
			card.IsExile = true;
			yield return new AddCardsToDrawZoneAction(new Card[] { card }, DrawZoneTarget.Top, AddCardsType.Normal);
			yield break;
		}
	}
}
