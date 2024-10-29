using System;
using System.Collections.Generic;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Cards;
using LBoL.EntityLib.Exhibits;
using LBoLEntitySideloader.Attributes;
using PatchouliCharacterMod.Cards;
using PatchouliCharacterMod.Cards.Template;

namespace PatchouliCharacterMod.Exhibits
{
	[EntityLogic(typeof(PatchouliExhibitUDef))]
	public sealed class PatchouliExhibitU : ShiningExhibit
	{
		public int BoostThreshold1 { get; } = 8;

		protected override void OnEnterBattle()
		{
			base.ReactBattleEvent<UnitEventArgs>(base.Battle.Player.TurnStarted, new EventSequencedReactor<UnitEventArgs>(this.OnPlayerTurnStarted));
			base.ReactBattleEvent<CardUsingEventArgs>(base.Battle.CardUsing, new EventSequencedReactor<CardUsingEventArgs>(this.OnCardUsing));
			base.ReactBattleEvent<CardUsingEventArgs>(base.Battle.CardUsed, new EventSequencedReactor<CardUsingEventArgs>(this.OnCardUsed));
		}

		private IEnumerable<BattleAction> OnCardUsing(CardUsingEventArgs args)
		{
			Card card = args.Card;
			PatchouliBoostCard boostCard = card as PatchouliBoostCard;
			bool flag = boostCard != null;
			if (flag)
			{
				this.Boost = boostCard.Boost;
			}
			yield break;
		}

		private IEnumerable<BattleAction> OnCardUsed(CardUsingEventArgs args)
		{
			bool flag = args.Card is PatchouliBoostCard;
			if (flag)
			{
				bool flag2 = this.Boost >= this.BoostThreshold1;
				if (flag2)
				{
					base.NotifyActivating();
					yield return new CastBlockShieldAction(base.Battle.Player, base.Battle.Player, base.Value2, 0, BlockShieldType.Direct, true);
				}
			}
			yield break;
		}

		private IEnumerable<BattleAction> OnPlayerTurnStarted(UnitEventArgs args)
		{
			bool flag = base.Battle.Player.TurnCounter == 1;
			if (flag)
			{
				base.NotifyActivating();
				yield return new AddCardsToHandAction(new Card[] { Library.CreateCard<PatchouliAstronomy>() });
			}
			yield break;
		}

		private int Boost = 0;
	}
}
