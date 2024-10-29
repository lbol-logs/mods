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
	[EntityLogic(typeof(YoumuMeikyoShisuiDef))]
	public sealed class YoumuMeikyoShisui : YoumuCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			int riposteAmount = base.Battle.CalculateBlockShield(this, (float)base.Block.Block, 0f, BlockShieldType.Normal).Item1;
			bool flag = riposteAmount > 0;
			if (flag)
			{
				yield return base.BuffAction<YoumuRiposteSe>(riposteAmount, 0, 0, 0, 0.2f);
			}
			bool flag2 = base.Value1 > 0;
			if (flag2)
			{
				yield return new DrawManyCardAction(base.Value1);
			}
			yield break;
		}
	}
}
