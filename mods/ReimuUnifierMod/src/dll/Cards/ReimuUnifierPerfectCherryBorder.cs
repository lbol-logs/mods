using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Cards;
using LBoL.EntityLib.Cards.Neutral.MultiColor;
using LBoLEntitySideloader.Attributes;
using ReimuUnifierMod.BattleActions;
using ReimuUnifierMod.Cards.Template;
using ReimuUnifierMod.StatusEffects;

namespace ReimuUnifierMod.Cards
{
	[EntityLogic(typeof(ReimuUnifierPerfectCherryBorderDef))]
	public sealed class ReimuUnifierPerfectCherryBorder : ReimuUnifierCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			yield return base.BuffAction<ReimuUnifierPerfectCherryBorderSe>(base.Value1, 0, 0, 0, 0.2f);
			List<Type> PossibleTeamUps = new List<Type>
			{
				typeof(ReimuUnifierYukariYakumoFriend),
				typeof(ReimuUnifierYukariSageOfGensokyoFriend),
				typeof(YukariFriend)
			};
			Card TeamUp = base.TeamUpCard(PossibleTeamUps);
			bool flag = TeamUp != null;
			if (flag)
			{
				yield return base.BuffAction<ReimuUnifierPCBReflectSe>(base.Value1, 0, 0, 0, 0.2f);
				yield return new TeamUpAction(this, base.TeamUpCard(PossibleTeamUps));
			}
			yield break;
		}
	}
}
