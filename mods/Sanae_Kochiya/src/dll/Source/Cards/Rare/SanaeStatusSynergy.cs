using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.StatusEffects;
using LBoL.EntityLib.Cards.Enemy;
using LBoLEntitySideloader.Attributes;
using Sanae_Kochiya.Cards.Template;

namespace Sanae_Kochiya.Source.Cards.Rare
{
	[EntityLogic(typeof(SanaeStatusSynergyDef))]
	public sealed class SanaeStatusSynergy : SampleCharacterCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			yield return new GainManaAction(base.Mana);
			yield return new AddCardsToDrawZoneAction(Library.CreateCards<Riguang>(base.Value1, false), DrawZoneTarget.Random, AddCardsType.Normal);
			yield return base.BuffAction<Firepower>(base.Value2, 0, 0, 0, 0.2f);
			yield break;
		}
	}
}
