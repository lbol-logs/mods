using System;
using System.Collections.Generic;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoLEntitySideloader.Attributes;

namespace YoumuCharacterMod.StatusEffects
{
	[EntityLogic(typeof(YoumuAscensionToBuddhahoodSeDef))]
	public sealed class YoumuAscensionToBuddhahoodSe : StatusEffect
	{
		protected override void OnAdded(Unit unit)
		{
			base.ReactOwnerEvent<CardUsingEventArgs>(base.Battle.CardUsing, new EventSequencedReactor<CardUsingEventArgs>(this.OnCardUsing));
			base.ReactOwnerEvent<UnitEventArgs>(base.Battle.Player.TurnEnded, new EventSequencedReactor<UnitEventArgs>(this.OnTurnEnded));
			base.ReactOwnerEvent<StatusEffectApplyEventArgs>(base.Battle.Player.StatusEffectAdded, new EventSequencedReactor<StatusEffectApplyEventArgs>(this.OnOwnerStatusEffectAdded));
		}

		private IEnumerable<BattleAction> OnOwnerStatusEffectAdded(StatusEffectApplyEventArgs args)
		{
			bool flag = args.Effect is YoumuAscensionToBuddhahoodSe;
			if (flag)
			{
				base.Count += args.Level.Value;
			}
			yield break;
		}

		private IEnumerable<BattleAction> OnTurnEnded(UnitEventArgs args)
		{
			base.Count = base.Level;
			yield break;
		}

		private IEnumerable<BattleAction> OnCardUsing(CardUsingEventArgs args)
		{
			bool flag = !args.Card.IsCopy && args.Card.CanBeDuplicated && base.Count > 0;
			if (flag)
			{
				base.NotifyActivating();
				args.Card.IsEcho = true;
				int count = base.Count;
				base.Count = count - 1;
			}
			yield break;
		}
	}
}
