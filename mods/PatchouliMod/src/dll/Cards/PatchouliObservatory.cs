using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoLEntitySideloader.Attributes;
using PatchouliCharacterMod.BattleActions;
using PatchouliCharacterMod.Cards.Template;

namespace PatchouliCharacterMod.Cards
{
	[EntityLogic(typeof(PatchouliObservatoryDef))]
	public sealed class PatchouliObservatory : PatchouliCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			yield return base.AttackAction(selector, base.GunName);
			bool flag = !base.Battle.BattleShouldEnd;
			if (flag)
			{
				yield return new AddCardsToHandAction(Library.CreateCards<PatchouliAstronomy>(base.Value1, false), AddCardsType.Normal);
				bool isUpgraded = this.IsUpgraded;
				if (isUpgraded)
				{
					yield return new BoostAllInHandAction(base.Value2);
				}
			}
			yield break;
		}
	}
}
