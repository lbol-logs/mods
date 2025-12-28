using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Cards;
using LBoLEntitySideloader.Attributes;
using ReimuUnifierMod.BattleActions;
using ReimuUnifierMod.Cards.Template;
using ReimuUnifierMod.StatusEffects;

namespace ReimuUnifierMod.Cards
{
	[EntityLogic(typeof(ReimuUnifierNeedleSparkSealDef))]
	public sealed class ReimuUnifierNeedleSparkSeal : ReimuUnifierCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			bool flag = !base.Battle.Player.HasStatusEffect<ReimuUnifierNeedleSparkSealSe>();
			if (flag)
			{
				yield return base.BuffAction<ReimuUnifierNeedleSparkSealSe>(0, 0, 0, 0, 0.2f);
			}
			yield return new AddCardsToHandAction(new Card[] { Library.CreateCard<ReimuUnifierYoukaiForgedNeedle>(this.IsUpgraded) });
			bool flag2 = base.TeamUpCheck<ReimuUnifierMarisaIncidentSolverFriend>() || base.TeamUpCheck<ReimuUnifierMarisaKirisameFriend>();
			if (flag2)
			{
				yield return new AddCardsToHandAction(new Card[] { Library.CreateCard<ReimuUnifierYoukaiForgedNeedle>(this.IsUpgraded) });
				List<Type> PossibleTeamUps = new List<Type>
				{
					typeof(ReimuUnifierMarisaIncidentSolverFriend),
					typeof(ReimuUnifierMarisaKirisameFriend)
				};
				yield return new TeamUpAction(this, base.TeamUpCard(PossibleTeamUps));
				PossibleTeamUps = null;
			}
			yield break;
		}
	}
}
