using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoLEntitySideloader.Attributes;
using ReimuUnifierMod.BattleActions;
using ReimuUnifierMod.Cards.Template;

namespace ReimuUnifierMod.Cards
{
	[EntityLogic(typeof(ReimuUnifierCursedBoundaryDef))]
	public sealed class ReimuUnifierCursedBoundary : ReimuUnifierCard
	{
		public override ManaGroup GetXCostFromPooled(ManaGroup pooledMana)
		{
			return pooledMana;
		}

		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			int ManaSpent = consumingMana.Amount;
			bool ShionInHand = base.TeamUpCheck<ReimuUnifierShionImpoverishedDeityFriend>();
			int num;
			for (int i = 0; i < ManaSpent; i = num + 1)
			{
				bool flag = !base.Battle.BattleShouldEnd;
				if (flag)
				{
					yield return base.LoseLifeAction(1);
					yield return base.AttackAction(selector, base.GunName);
				}
				bool flag2 = ShionInHand;
				if (flag2)
				{
					yield return new GainMoneyAction(base.Value1, SpecialSourceType.None);
				}
				num = i;
			}
			bool flag3 = ShionInHand;
			if (flag3)
			{
				yield return new TeamUpAction(this, base.TeamUpCard(typeof(ReimuUnifierShionImpoverishedDeityFriend)));
			}
			yield break;
		}
	}
}
