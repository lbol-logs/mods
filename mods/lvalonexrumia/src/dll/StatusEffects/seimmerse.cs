using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoLEntitySideloader.Attributes;

namespace lvalonexrumia.StatusEffects
{
	[EntityLogic(typeof(seimmerseDef))]
	public sealed class seimmerse : StatusEffect
	{
		protected override void OnAdded(Unit unit)
		{
			base.ReactOwnerEvent<CardUsingEventArgs>(base.Battle.CardUsed, new EventSequencedReactor<CardUsingEventArgs>(this.OnCardUsed));
			base.ReactOwnerEvent<UnitEventArgs>(base.Battle.Player.TurnEnded, new EventSequencedReactor<UnitEventArgs>(this.OnTurnEnded));
		}

		private IEnumerable<BattleAction> OnTurnEnded(UnitEventArgs args)
		{
			yield return new RemoveStatusEffectAction(this, true, 0.1f);
			yield break;
		}

		private IEnumerable<BattleAction> OnCardUsed(CardUsingEventArgs args)
		{
			bool flag = args.Card.Config.Type == CardType.Attack;
			if (flag)
			{
				base.NotifyActivating();
				yield return new ApplyStatusEffectAction<sebloodstorm>(base.Battle.Player, new int?(base.Level), new int?(0), new int?(0), new int?(0), 0.2f, true);
			}
			yield break;
		}
	}
}
