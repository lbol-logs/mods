using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.StatusEffects;
using LBoL.EntityLib.Cards.Neutral.Black;
using LBoLEntitySideloader.Attributes;
using lvalonexrumia.Cards.Template;
using lvalonexrumia.StatusEffects;

namespace lvalonexrumia.Cards
{
	[EntityLogic(typeof(cardshadowcutDef))]
	public sealed class cardshadowcut : lvalonexrumiaCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			yield return PerformAction.Spell(base.Battle.Player, "exshadowcut");
			yield return new AddCardsToHandAction(Library.CreateCards<Shadow>(base.Value1, false), AddCardsType.Normal);
			yield return PerformAction.Effect(base.Battle.Player, "ExtraTime", 0f, null, 0f, PerformAction.EffectBehavior.PlayOneShot, 0f);
			yield return PerformAction.Sfx("ExtraTurnLaunch", 0f);
			yield return PerformAction.Animation(base.Battle.Player, "spell", 1.6f, null, 0f, -1);
			yield return base.BuffAction<ExtraTurn>(1, 0, 0, 0, 0.2f);
			yield return new ApplyStatusEffectAction<seshadowcut>(base.Battle.Player, new int?(base.Value2), new int?(0), new int?(0), new int?(0), 0.2f, true);
			yield return new RequestEndPlayerTurnAction();
			yield break;
		}
	}
}
