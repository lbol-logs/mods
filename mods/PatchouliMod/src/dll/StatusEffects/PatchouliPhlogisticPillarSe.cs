using System;
using System.Collections.Generic;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoLEntitySideloader.Attributes;
using PatchouliCharacterMod.Cards.Template;

namespace PatchouliCharacterMod.StatusEffects
{
	[EntityLogic(typeof(PatchouliPhlogisticPillarSeDef))]
	public sealed class PatchouliPhlogisticPillarSe : StatusEffect
	{
		protected override void OnAdded(Unit unit)
		{
			base.ReactOwnerEvent<CardUsingEventArgs>(base.Battle.CardUsed, new EventSequencedReactor<CardUsingEventArgs>(this.OnCardUsed));
		}

		private IEnumerable<BattleAction> OnCardUsed(CardUsingEventArgs args)
		{
			bool flag = args.Card is PatchouliBoostCard;
			if (flag)
			{
				base.NotifyActivating();
				yield return new CastBlockShieldAction(base.Battle.Player, base.Battle.Player, 0, base.Level, BlockShieldType.Direct, true);
			}
			yield break;
		}
	}
}
