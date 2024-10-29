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
	[EntityLogic(typeof(YoumuDualWielderDef))]
	public sealed class YoumuDualWielder : YoumuCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			bool flag = !base.Battle.BattleShouldEnd;
			if (flag)
			{
				bool isUpgraded = this.IsUpgraded;
				if (isUpgraded)
				{
					yield return new AddCardsToHandAction(Library.CreateCards<YoumuSlashOfPresent>(base.Value2, false), AddCardsType.Normal);
				}
				yield return base.BuffAction<YoumuDualWielderSe>(base.Value2, 0, 0, 0, 0.2f);
				yield break;
			}
			yield break;
		}
	}
}
