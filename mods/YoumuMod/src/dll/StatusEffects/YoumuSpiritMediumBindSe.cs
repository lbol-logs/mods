using System;
using System.Collections.Generic;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Cards;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoLEntitySideloader.Attributes;
using YoumuCharacterMod.GunName;

namespace YoumuCharacterMod.StatusEffects
{
	[EntityLogic(typeof(YoumuSpiritMediumBindSeDef))]
	public sealed class YoumuSpiritMediumBindSe : StatusEffect
	{
		protected override void OnAdded(Unit unit)
		{
			base.ReactOwnerEvent<CardEventArgs>(base.Battle.CardExiled, new EventSequencedReactor<CardEventArgs>(this.OnCardExiled));
		}

		private IEnumerable<BattleAction> OnCardExiled(CardEventArgs args)
		{
			base.NotifyActivating();
			int damage = base.Level;
			yield return new DamageAction(base.Owner, base.Battle.AllAliveEnemies, DamageInfo.Reaction((float)damage, false), YoumuGunName.SpiritMediumBindSe, GunType.Single);
			yield break;
		}
	}
}
