using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoLEntitySideloader.Attributes;
using Sanae_Kochiya.Cards.Template;
using Sanae_Kochiya.Source.StatusEffects;

namespace Sanae_Kochiya.Source.Cards.Uncommon
{
	[EntityLogic(typeof(SanaeAttackBlockDef))]
	public sealed class SanaeAttackBlock : SampleCharacterCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			bool flag = base.Battle.Player.Block > 0;
			if (flag)
			{
				yield return base.BuffAction<SanaeAttackBlockSe>(base.Block.Block, 0, 0, 0, 0.2f);
			}
			else
			{
				yield return base.DefenseAction(false);
			}
			yield return new RequestEndPlayerTurnAction();
			yield break;
		}
	}
}
