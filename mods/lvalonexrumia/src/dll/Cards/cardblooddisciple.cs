using System;
using System.Collections.Generic;
using System.Linq;
using LBoL.Base;
using LBoL.Base.Extensions;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Battle.Interactions;
using LBoL.Core.Cards;
using LBoL.Presentation;
using LBoLEntitySideloader.Attributes;
using lvalonexrumia.Cards.Template;
using lvalonexrumia.Patches;
using lvalonexrumia.StatusEffects;

namespace lvalonexrumia.Cards
{
	[EntityLogic(typeof(cardblooddiscipleDef))]
	public sealed class cardblooddisciple : lvalonexrumiaCard
	{
		protected override int heal
		{
			get
			{
				return toolbox.hpfrompercent(Singleton<GameMaster>.Instance.CurrentGameRun.Player, base.Value1, true);
			}
		}

		public override Interaction Precondition()
		{
			List<Card> list = base.Battle.HandZone.Where((Card card) => card != this).ToList<Card>();
			bool flag = !list.Empty<Card>();
			Interaction interaction;
			if (flag)
			{
				interaction = new SelectCardInteraction(0, base.Value2, list, SelectedCardHandling.DoNothing);
			}
			else
			{
				interaction = null;
			}
			return interaction;
		}

		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			yield return new ChangeLifeAction(-this.heal, null);
			bool battleShouldEnd = base.Battle.BattleShouldEnd;
			if (battleShouldEnd)
			{
				yield break;
			}
			bool flag = precondition != null;
			if (flag)
			{
				IReadOnlyList<Card> cards = ((SelectCardInteraction)precondition).SelectedCards;
				bool flag2 = cards.Count > 0;
				if (flag2)
				{
					yield return new ExileManyCardAction(cards);
					yield return new ApplyStatusEffectAction<sebloodclot>(base.Battle.Player, new int?(cards.Count), new int?(0), new int?(0), new int?(0), 0f, true);
					yield return new AddCardsToHandAction(Library.CreateCards<cardredblood>(cards.Count, false), AddCardsType.Normal);
				}
				cards = null;
			}
			yield break;
		}
	}
}
