using System;
using System.Collections.Generic;
using System.Linq;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Cards;
using LBoLEntitySideloader.Attributes;
using Sanae_Kochiya.Cards.Template;

namespace Sanae_Kochiya.Source.Cards.Rare
{
	[EntityLogic(typeof(SanaeAttackOrderDef))]
	public sealed class SanaeAttackOrder : SampleCharacterCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			yield return base.AttackAction(selector, base.GunName);
			bool isUpgraded = this.IsUpgraded;
			if (isUpgraded)
			{
				yield return new GainManaAction(base.Mana);
			}
			Card target = base.Battle.DrawZone.FirstOrDefault<Card>();
			Card card = target.CloneBattleCard();
			card.SetTurnCost(default(ManaGroup));
			card.IsExile = true;
			yield return new AddCardsToHandAction(new Card[] { card });
			yield break;
		}
	}
}
