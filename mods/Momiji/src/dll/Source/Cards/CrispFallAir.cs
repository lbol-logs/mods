using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoLEntitySideloader.Attributes;
using Momiji.Source.StatusEffects;

namespace Momiji.Source.Cards
{
	[EntityLogic(typeof(CrispFallAirDef))]
	public sealed class CrispFallAir : SampleCharacterCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			bool flag = !this.IsUpgraded;
			if (flag)
			{
				yield return new AddCardsToHandAction(Library.CreateCards<AirCutter>(base.Value1, false), AddCardsType.Normal);
				yield return new GainTurnManaAction(base.Mana);
			}
			else
			{
				yield return new AddCardsToHandAction(Library.CreateCards<AirCutter>(base.Value1, false), AddCardsType.Normal);
				yield return new GainManaAction(base.Mana);
				yield return new GainTurnManaAction(base.Mana);
				yield return new ApplyStatusEffectAction<CrispFallAirSe>(base.Battle.Player, new int?(base.Value1), new int?(1), new int?(0), new int?(0), 0.2f, true);
			}
			yield break;
		}
	}
}
