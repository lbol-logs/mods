using System;
using System.Collections.Generic;
using LBoL.Base.Extensions;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Cards;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoLEntitySideloader.Attributes;
using YoumuCharacterMod.Cards.Template;

namespace YoumuCharacterMod.StatusEffects
{
	[EntityLogic(typeof(YoumuInfiniteKalpasSeDef))]
	public sealed class YoumuInfiniteKalpasSe : StatusEffect
	{
		protected override void OnAdded(Unit unit)
		{
			base.ReactOwnerEvent<UnitEventArgs>(base.Battle.Player.TurnStarted, new EventSequencedReactor<UnitEventArgs>(this.OnTurnStarted));
		}

		private IEnumerable<BattleAction> OnTurnStarted(UnitEventArgs args)
		{
			base.NotifyActivating();
			bool battleShouldEnd = base.Battle.BattleShouldEnd;
			if (battleShouldEnd)
			{
				yield break;
			}
			base.NotifyActivating();
			Type[] array = YoumuCard.AllEthereal.SampleManyOrAll(base.Level, base.GameRun.BattleCardRng);
			int num;
			for (int i = 0; i < array.Length; i = num + 1)
			{
				YoumuCard card = (YoumuCard)Library.CreateCard(array[i]);
				card.IsExile = true;
				yield return new AddCardsToHandAction(new Card[] { card });
				card = null;
				num = i;
			}
			yield break;
		}
	}
}
