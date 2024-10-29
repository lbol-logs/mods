using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoLEntitySideloader.Attributes;
using YoumuCharacterMod.Cards.Template;
using YoumuCharacterMod.StatusEffects;

namespace YoumuCharacterMod.Cards
{
	[EntityLogic(typeof(YoumuTenKingsRetributionDef))]
	public sealed class YoumuTenKingsRetribution : YoumuCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			int riposteAmount = base.Battle.CalculateBlockShield(this, (float)base.Block.Block, 0f, BlockShieldType.Normal).Item1;
			yield return base.DefenseAction(true);
			int block = base.Battle.Player.Block;
			bool flag = block > 0;
			if (flag)
			{
				yield return new LoseBlockShieldAction(base.Battle.Player, block, 0, false);
				yield return base.BuffAction<YoumuRiposteSe>(block, 0, 0, 0, 0.2f);
			}
			yield break;
		}
	}
}
