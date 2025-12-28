using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Cards;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoL.EntityLib.Cards.Character.Cirno;
using LBoLEntitySideloader.Attributes;

namespace ReimuUnifierMod.StatusEffects
{
	[EntityLogic(typeof(ReimuUnifierFlowerViewingPartySeDef))]
	public sealed class ReimuUnifierFlowerViewingPartySe : StatusEffect
	{
		private ManaGroup SePreviewMana
		{
			get
			{
				return ManaGroup.Colorlesses(1);
			}
		}

		protected override void OnAdded(Unit unit)
		{
			base.ReactOwnerEvent<CardUsingEventArgs>(base.Battle.CardUsed, new EventSequencedReactor<CardUsingEventArgs>(this.OnCardUsed));
			base.ReactOwnerEvent<UnitEventArgs>(base.Owner.TurnStarted, new EventSequencedReactor<UnitEventArgs>(this.OnTurnStarted));
		}

		private IEnumerable<BattleAction> OnTurnStarted(UnitEventArgs args)
		{
			base.Count = base.Level;
			yield break;
		}

		private IEnumerable<BattleAction> OnCardUsed(CardUsingEventArgs args)
		{
			bool flag = !this.Battle.BattleShouldEnd;
			if (flag)
			{
				Card card = args.Card;
				bool flag2 = card.CardType == CardType.Friend && card.Summoning;
				if (flag2)
				{
					this.NotifyActivating();
					yield return new AddCardsToHandAction(Library.CreateCards<SummerFlower>(base.Level, false), AddCardsType.Normal, false);
					bool flag3 = base.Count > 0;
					if (flag3)
					{
						yield return new GainManaAction(ManaGroup.Single(ManaColor.Colorless));
						int count = base.Count;
						base.Count = count - 1;
					}
					yield break;
				}
				card = null;
			}
			yield break;
		}
	}
}
