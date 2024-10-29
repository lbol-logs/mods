using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Cards;
using LBoL.EntityLib.Cards.Neutral.Black;
using LBoLEntitySideloader.Attributes;
using PatchouliCharacterMod.Cards.Template;
using PatchouliCharacterMod.StatusEffects;

namespace PatchouliCharacterMod.Cards
{
	[EntityLogic(typeof(PatchouliGirlOfShadeDef))]
	public sealed class PatchouliGirlOfShade : PatchouliCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			IEnumerable<Card> shadows = Library.CreateCards<Shadow>(base.Value1, false);
			foreach (Card shadow in shadows)
			{
				shadow.IsReplenish = true;
				shadow = null;
			}
			IEnumerator<Card> enumerator = null;
			yield return new AddCardsToDiscardAction(shadows, AddCardsType.Normal);
			yield return base.BuffAction<PatchouliGirlOfShadeSe>(base.Value2, 0, 0, 0, 0.2f);
			yield break;
		}
	}
}
