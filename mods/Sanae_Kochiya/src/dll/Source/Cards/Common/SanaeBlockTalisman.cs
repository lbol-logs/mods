using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Cards;
using LBoLEntitySideloader.Attributes;
using Sanae_Kochiya.Cards.Template;
using Sanae_Kochiya.Source.Cards.Starter;

namespace Sanae_Kochiya.Source.Cards.Common
{
	[EntityLogic(typeof(SanaeBlockTalismanDef))]
	public sealed class SanaeBlockTalisman : SampleCharacterCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			yield return base.DefenseAction(true);
			List<Card> list = new List<Card>();
			int num;
			for (int i = 0; i < base.Value1; i = num + 1)
			{
				list.Add(Library.CreateCard(typeof(SanaeStatus)));
				num = i;
			}
			yield return new AddCardsToDiscardAction(list, AddCardsType.Normal);
			yield break;
		}
	}
}
