using System;
using System.Collections.Generic;
using System.Linq;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Cards;
using LBoL.EntityLib.Cards.Neutral.NoColor;
using LBoLEntitySideloader.Attributes;
using Sanae_Kochiya.Cards.Template;

namespace Sanae_Kochiya.Source.Cards.Uncommon
{
	[EntityLogic(typeof(SanaeDrawSplashDef))]
	public sealed class SanaeDrawSplash : SampleCharacterCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			yield return new DrawManyCardAction(base.Value1);
			List<Card> discard = (from hand in base.Battle.HandZone
				where hand != this
				select hand into c
				where c.Config.Type == CardType.Skill
				select c).ToList<Card>();
			List<Card> splash = new List<Card>();
			int num;
			for (int i = 0; i < discard.Count; i = num + 1)
			{
				splash.Add(Library.CreateCard(typeof(UManaCard)));
				splash[i].IsAutoExile = true;
				num = i;
			}
			yield return new DiscardManyAction(discard);
			yield return new AddCardsToHandAction(splash, AddCardsType.Normal);
			yield break;
		}
	}
}
