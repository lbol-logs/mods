using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Base.Extensions;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Battle.Interactions;
using LBoL.Core.Cards;
using LBoL.EntityLib.Cards.Character.Reimu;
using LBoLEntitySideloader.Attributes;
using LBoLEntitySideloader.Utils;
using Sanae_Kochiya.Cards.Template;

namespace Sanae_Kochiya.Source.Cards.Offcolor
{
	[EntityLogic(typeof(SanaeReimuAbilityDef))]
	public sealed class SanaeReimuAbility : SampleCharacterCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			List<Type> array = ObjectExtensions.Copy<List<Type>>(SanaeReimuAbility.ReimuRares);
			array.Shuffle(base.BattleRng);
			List<Card> cards = new List<Card>();
			int num;
			for (int i = 0; i < base.Value1; i = num + 1)
			{
				cards.Add(Library.CreateCard(array[i]));
				num = i;
			}
			bool flag = cards.Count > 0;
			if (flag)
			{
				MiniSelectCardInteraction interaction = new MiniSelectCardInteraction(cards, false, false, false)
				{
					Source = this
				};
				yield return new InteractionAction(interaction, false);
				Card selectedCard = interaction.SelectedCard;
				selectedCard.SetTurnCost(base.Mana);
				yield return new AddCardsToHandAction(new Card[] { selectedCard });
				interaction = null;
				selectedCard = null;
			}
			yield return new LockRandomTurnManaAction(base.Value2);
			yield break;
		}

		public static List<Type> ReimuRares = new List<Type>
		{
			typeof(MomentPower),
			typeof(TaijiLiangyi),
			typeof(ReimuSilence),
			typeof(Jiangshen),
			typeof(BoliDajiejie),
			typeof(DoubleLianhuadie),
			typeof(BoliPhantom),
			typeof(DanceAroundLake)
		};
	}
}
