using System;
using System.Collections.Generic;
using System.Linq;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Cards;
using YoumuCharacterMod.Cards;
using YoumuCharacterMod.Cards.Template;
using YoumuCharacterMod.Patches;

namespace YoumuCharacterMod.BattleActions
{
	public sealed class UnsheatheAllInHandAction : SimpleAction
	{
		internal UnsheatheAllInHandAction()
		{
			this._args = new GameEventArgs
			{
				CanCancel = false
			};
		}

		public override IEnumerable<Phase> GetPhases()
		{
			yield return base.CreatePhase("Main", delegate
			{
				List<Card> list = base.Battle.HandZone.ToList<Card>();
				bool flag = false;
				ManaGroup manaGroup = new ManaGroup
				{
					Any = 1
				};
				foreach (Card card in list)
				{
					bool flag2 = YoumuCard.IsSlashCard(card);
					if (flag2)
					{
						bool flag3 = card is YoumuSlashOfPresent;
						if (flag3)
						{
							flag = true;
						}
						card.DecreaseTurnCost(manaGroup);
					}
				}
				bool flag4 = !flag;
				if (flag4)
				{
					base.React(new AddCardsToHandAction(new Card[] { Library.CreateCard<YoumuSlashOfPresent>() }), null, null);
				}
			}, false);
			yield return base.CreateEventPhase<GameEventArgs>("Unsheathed", this._args, CustomGameEventPatch.Unsheathed);
			yield break;
		}

		private readonly GameEventArgs _args;
	}
}
