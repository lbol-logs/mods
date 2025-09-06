using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoLEntitySideloader.Attributes;
using lvalonexrumia.Cards.Template;
using lvalonexrumia.StatusEffects;

namespace lvalonexrumia.Cards
{
	[EntityLogic(typeof(cardtwilightDef))]
	public sealed class cardtwilight : lvalonexrumiaCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			yield return new ApplyStatusEffectAction<setwilight1>(base.Battle.Player, new int?(10), new int?(0), new int?(0), new int?(0), 0.2f, true);
			yield return new ApplyStatusEffectAction<setwilight2>(base.Battle.Player, new int?(1), new int?(0), new int?(0), new int?(0), 0.2f, true);
			yield return new ApplyStatusEffectAction<setwilight3>(base.Battle.Player, new int?(2), new int?(0), new int?(0), new int?(0), 0.2f, true);
			yield break;
		}
	}
}
