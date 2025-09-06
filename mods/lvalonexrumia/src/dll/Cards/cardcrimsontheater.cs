using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.StatusEffects;
using LBoLEntitySideloader.Attributes;
using lvalonexrumia.Cards.Template;

namespace lvalonexrumia.Cards
{
	[EntityLogic(typeof(cardcrimsontheaterDef))]
	public sealed class cardcrimsontheater : lvalonexrumiaCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			yield return new ApplyStatusEffectAction<Graze>(base.Battle.Player, new int?(base.Value1), new int?(0), new int?(0), new int?(0), 0.2f, true);
			yield return new AddCardsToHandAction(Library.CreateCards<cardbloodstorm>(base.Value2, false), AddCardsType.Normal);
			yield break;
		}
	}
}
