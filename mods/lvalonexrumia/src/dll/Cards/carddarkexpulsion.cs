using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.EntityLib.Cards.Neutral.Black;
using LBoLEntitySideloader.Attributes;
using lvalonexrumia.Cards.Template;
using lvalonexrumia.StatusEffects;

namespace lvalonexrumia.Cards
{
	[EntityLogic(typeof(carddarkexpulsionDef))]
	public sealed class carddarkexpulsion : lvalonexrumiaCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			yield return new ApplyStatusEffectAction<sedarkblood>(base.Battle.Player, new int?(base.Value2), new int?(0), new int?(0), new int?(0), 0.2f, true);
			yield return new AddCardsToHandAction(Library.CreateCards<Shadow>(base.Value1, false), AddCardsType.Normal);
			yield break;
		}
	}
}
