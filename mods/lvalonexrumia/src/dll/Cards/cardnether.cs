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
	[EntityLogic(typeof(cardnetherDef))]
	public sealed class cardnether : lvalonexrumiaCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			yield return base.DefenseAction(true);
			bool battleShouldEnd = base.Battle.BattleShouldEnd;
			if (battleShouldEnd)
			{
				yield break;
			}
			yield return new ApplyStatusEffectAction<sebloodclot>(base.Battle.Player, new int?(base.Value1), new int?(0), new int?(0), new int?(0), 0.2f, true);
			bool battleShouldEnd2 = base.Battle.BattleShouldEnd;
			if (battleShouldEnd2)
			{
				yield break;
			}
			yield return new AddCardsToHandAction(Library.CreateCards<Shadow>(base.Value2, false), AddCardsType.Normal);
			yield break;
		}
	}
}
