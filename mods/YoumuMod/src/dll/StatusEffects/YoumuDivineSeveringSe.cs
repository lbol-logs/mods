using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Cards;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoLEntitySideloader.Attributes;
using YoumuCharacterMod.Cards.Template;
using YoumuCharacterMod.Patches;

namespace YoumuCharacterMod.StatusEffects
{
	[EntityLogic(typeof(YoumuDivineSeveringSeDef))]
	public sealed class YoumuDivineSeveringSe : StatusEffect
	{
		protected override void OnAdded(Unit unit)
		{
			base.ReactOwnerEvent<GameEventArgs>(CustomGameEventPatch.Unsheathed, new EventSequencedReactor<GameEventArgs>(this.OnUnsheathe));
			base.HandleOwnerEvent<DamageDealingEventArgs>(unit.DamageDealing, new GameEventHandler<DamageDealingEventArgs>(this.OnDamageDealing));
		}

		private void OnDamageDealing(DamageDealingEventArgs args)
		{
			Card card = args.ActionSource as Card;
			bool flag = card != null && YoumuCard.IsSlashCard(card) && card.CardType == CardType.Attack;
			if (flag)
			{
				args.DamageInfo = args.DamageInfo.IncreaseBy(base.Count);
				args.AddModifier(this);
			}
		}

		private IEnumerable<BattleAction> OnUnsheathe(GameEventArgs args)
		{
			base.Count += base.Level;
			yield break;
		}
	}
}
