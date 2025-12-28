using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.StatusEffects;
using LBoLEntitySideloader.Attributes;
using ReimuUnifierMod.BattleActions;
using ReimuUnifierMod.Cards.Template;
using ReimuUnifierMod.StatusEffects;

namespace ReimuUnifierMod.Cards
{
	[EntityLogic(typeof(ReimuUnifierDarknessOfTheCrowDef))]
	public sealed class ReimuUnifierDarknessOfTheCrow : ReimuUnifierCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			yield return base.BuffAction<ReimuUnifierDarknessOfTheCrowSe>(base.Value1, 0, 0, 0, 0.2f);
			bool flag = base.TeamUpCheck<ReimuUnifierAyaReporterOfFantasyFriend>();
			if (flag)
			{
				yield return base.BuffAction<Graze>(base.Value2, 0, 0, 0, 0.2f);
				yield return new TeamUpAction(this, base.TeamUpCard(typeof(ReimuUnifierAyaReporterOfFantasyFriend)));
			}
			yield break;
		}
	}
}
