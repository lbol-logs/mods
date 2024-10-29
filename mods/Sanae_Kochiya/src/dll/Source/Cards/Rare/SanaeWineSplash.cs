using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Cards;
using LBoL.EntityLib.Cards.Neutral.NoColor;
using LBoLEntitySideloader.Attributes;
using Sanae_Kochiya.Cards.Template;

namespace Sanae_Kochiya.Source.Cards.Rare
{
	[EntityLogic(typeof(SanaeWineSplashDef))]
	public sealed class SanaeWineSplash : SampleCharacterCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			List<Card> cards = new List<Card>
			{
				Library.CreateCard<Xiaozhuo>(this.IsUpgraded),
				Library.CreateCard<UManaCard>(this.IsUpgraded)
			};
			yield return new AddCardsToHandAction(cards, AddCardsType.Normal);
			yield break;
		}
	}
}
