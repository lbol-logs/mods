using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoLEntitySideloader.Attributes;
using YoumuCharacterMod.Cards.Template;
using YoumuCharacterMod.StatusEffects;

namespace YoumuCharacterMod.Cards
{
	[EntityLogic(typeof(YoumuMatsuyoiReflectingDef))]
	public sealed class YoumuMatsuyoiReflecting : YoumuCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			int riposteAmount = base.Battle.CalculateBlockShield(this, (float)base.Block.Block, 0f, BlockShieldType.Normal).Item1;
			int playerRiposte = 0;
			bool flag = base.Battle.Player.HasStatusEffect<YoumuRiposteSe>();
			if (flag)
			{
				playerRiposte = base.Battle.Player.GetStatusEffect<YoumuRiposteSe>().Level;
			}
			bool flag2 = playerRiposte > riposteAmount && playerRiposte > 0;
			if (flag2)
			{
				yield return base.BuffAction<YoumuRiposteSe>(playerRiposte, 0, 0, 0, 0.2f);
			}
			else
			{
				bool flag3 = riposteAmount > 0;
				if (flag3)
				{
					yield return base.BuffAction<YoumuRiposteSe>(riposteAmount, 0, 0, 0, 0.2f);
				}
			}
			yield break;
		}
	}
}
