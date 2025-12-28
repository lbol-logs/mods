using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.StatusEffects;
using LBoLEntitySideloader.Attributes;
using ReimuUnifierMod.BattleActions;
using ReimuUnifierMod.Cards.Template;

namespace ReimuUnifierMod.Cards
{
	[EntityLogic(typeof(ReimuUnifierHermitsTrainingDef))]
	public sealed class ReimuUnifierHermitsTraining : ReimuUnifierCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			bool flag = base.TeamUpCheck<ReimuUnifierKasenWildhornFriend>();
			if (flag)
			{
				yield return base.BuffAction<TempFirepower>(base.Value1, 0, 0, 0, 0.2f);
				yield return new TeamUpAction(this, base.TeamUpCard(typeof(ReimuUnifierKasenWildhornFriend)));
			}
			bool flag2 = base.Battle.Player.HasStatusEffect<TempFirepower>();
			if (flag2)
			{
				yield return new CastBlockShieldAction(base.Battle.Player, base.Shield.Shield, base.Shield.Shield, BlockShieldType.Normal, true);
			}
			else
			{
				yield return new CastBlockShieldAction(base.Battle.Player, this.Block.Block, 0, BlockShieldType.Normal, true);
			}
			yield break;
		}
	}
}
