using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoLEntitySideloader.Attributes;

namespace PatchouliCharacterMod.StatusEffects
{
	[EntityLogic(typeof(PatchouliGirlOfShadeSeDef))]
	public sealed class PatchouliGirlOfShadeSe : StatusEffect
	{
		protected override void OnAdded(Unit unit)
		{
			base.ReactOwnerEvent<CardEventArgs>(base.Battle.CardExiled, new EventSequencedReactor<CardEventArgs>(this.OnCardExiled));
		}

		private IEnumerable<BattleAction> OnCardExiled(CardEventArgs args)
		{
			bool flag = args.Card.CardType == CardType.Status || args.Card.CardType == CardType.Misfortune;
			if (flag)
			{
				base.NotifyActivating();
				yield return new ApplyStatusEffectAction<Firepower>(base.Battle.Player, new int?(base.Level), null, null, null, 0f, true);
				yield return new ApplyStatusEffectAction<Spirit>(base.Battle.Player, new int?(base.Level), null, null, null, 0f, true);
			}
			yield break;
		}
	}
}
