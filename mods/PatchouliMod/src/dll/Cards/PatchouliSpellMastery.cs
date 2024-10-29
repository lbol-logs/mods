using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Cards;
using LBoL.EntityLib.Cards.Neutral.NoColor;
using LBoLEntitySideloader.Attributes;
using PatchouliCharacterMod.Cards.Template;

namespace PatchouliCharacterMod.Cards
{
	[EntityLogic(typeof(PatchouliSpellMasteryDef))]
	public sealed class PatchouliSpellMastery : PatchouliBoostCard
	{
		protected override bool HasTreshold { get; set; } = true;

		protected override int BoostThreshold1 { get; set; } = 3;

		protected override int BoostThreshold2 { get; set; } = 5;

		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			yield return base.AttackAction(selector, base.GunName);
			bool flag = base.Boost >= this.BoostThreshold1 && !base.Battle.BattleShouldEnd;
			if (flag)
			{
				Card card = null;
				bool flag2 = !this.IsUpgraded;
				if (flag2)
				{
					card = Library.CreateCard<UManaCard>();
				}
				else
				{
					card = Library.CreateCard<PManaCard>();
				}
				bool flag3 = base.Boost >= this.BoostThreshold2;
				if (flag3)
				{
					card.IsUpgraded = true;
				}
				yield return new AddCardsToHandAction(new Card[] { card });
				base.ResetBoost();
				card = null;
			}
			yield break;
		}
	}
}
