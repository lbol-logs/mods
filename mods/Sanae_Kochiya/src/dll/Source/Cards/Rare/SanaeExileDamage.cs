using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoLEntitySideloader.Attributes;
using Sanae_Kochiya.Cards.Template;
using Sanae_Kochiya.Source.Cards.Starter;
using Sanae_Kochiya.Source.StatusEffects;

namespace Sanae_Kochiya.Source.Cards.Rare
{
	[EntityLogic(typeof(SanaeExileDamageDef))]
	public sealed class SanaeExileDamage : SampleCharacterCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			yield return base.BuffAction<SanaeExileDamageSe>(base.Value1, 0, 0, 0, 0.2f);
			bool isUpgraded = this.IsUpgraded;
			if (isUpgraded)
			{
				yield return new AddCardsToHandAction(Library.CreateCards<SanaeStatus>(base.Value2, false), AddCardsType.Normal);
			}
			yield break;
		}
	}
}
