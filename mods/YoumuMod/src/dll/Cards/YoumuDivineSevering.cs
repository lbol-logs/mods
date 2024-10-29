using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoLEntitySideloader.Attributes;
using YoumuCharacterMod.BattleActions;
using YoumuCharacterMod.Cards.Template;
using YoumuCharacterMod.StatusEffects;

namespace YoumuCharacterMod.Cards
{
	[EntityLogic(typeof(YoumuDivineSeveringDef))]
	public sealed class YoumuDivineSevering : YoumuCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			bool flag = !base.Battle.BattleShouldEnd;
			if (flag)
			{
				yield return base.BuffAction<YoumuDivineSeveringSe>(base.Value1, 0, 0, 0, 0.2f);
				int num;
				for (int i = 0; i < base.Value2; i = num + 1)
				{
					yield return new UnsheatheAllInHandAction();
					num = i;
				}
				yield break;
			}
			yield break;
		}
	}
}
