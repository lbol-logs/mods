using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoLEntitySideloader.Attributes;
using lvalonexrumia.Cards.Template;
using lvalonexrumia.StatusEffects;

namespace lvalonexrumia.Cards
{
	[EntityLogic(typeof(cardcorruptedbloodDef))]
	public sealed class cardcorruptedblood : lvalonexrumiaCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			yield return new ApplyStatusEffectAction<secorruptedblood>(base.Battle.Player, new int?(base.Value1), new int?(0), new int?(0), new int?(0), 0.2f, true);
			bool isUpgraded = this.IsUpgraded;
			if (isUpgraded)
			{
				yield return new AddCardsToHandAction(Library.CreateCards<carddarkblood>(base.Value2, false), AddCardsType.Normal);
			}
			yield break;
		}
	}
}
