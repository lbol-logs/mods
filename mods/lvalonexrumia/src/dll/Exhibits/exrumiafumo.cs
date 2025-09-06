using System;
using System.Collections.Generic;
using System.Linq;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Cards;
using LBoL.Core.StatusEffects;
using LBoLEntitySideloader.Attributes;

namespace lvalonexrumia.Exhibits
{
	[EntityLogic(typeof(exrumiafumoDef))]
	[ExhibitInfo(WeighterType = typeof(exrumiafumo.exrumiafumoWeighter))]
	public sealed class exrumiafumo : Exhibit
	{
		protected override void OnEnterBattle()
		{
			base.ReactBattleEvent<CardUsingEventArgs>(base.Battle.CardUsed, new EventSequencedReactor<CardUsingEventArgs>(this.OnCardUsed));
		}

		private IEnumerable<BattleAction> OnCardUsed(CardUsingEventArgs args)
		{
			bool flag = args.Card.Id == "cardredblood" || args.Card.Id == "carddarkblood";
			if (flag)
			{
				base.NotifyActivating();
				yield return new ApplyStatusEffectAction<TempFirepower>(base.Battle.Player, new int?(base.Value1), new int?(0), new int?(0), new int?(0), 0.2f, true);
			}
			yield break;
		}

		public class exrumiafumoWeighter : IExhibitWeighter
		{
			public float WeightFor(Type type, GameRunController gameRun)
			{
				return (float)(gameRun.BaseDeck.Any((Card card) => card.Config.RelativeCards.Contains("cardredblood") || card.Config.RelativeCards.Contains("carddarkblood") || card.Config.UpgradedRelativeCards.Contains("cardredblood") || card.Config.UpgradedRelativeCards.Contains("carddarkblood") || card.Config.RelativeEffects.Contains("sedarkblood") || card.Config.UpgradedRelativeEffects.Contains("sedarkblood")) ? 1 : 0);
			}
		}
	}
}
