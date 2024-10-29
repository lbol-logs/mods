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
using PatchouliCharacterMod.Cards.Template;
using PatchouliCharacterMod.GunName;

namespace PatchouliCharacterMod.StatusEffects
{
	[EntityLogic(typeof(PatchouliGrandIncantationSeDef))]
	public sealed class PatchouliGrandIncantationSe : StatusEffect
	{
		protected override void OnAdded(Unit unit)
		{
			base.ReactOwnerEvent<CardUsingEventArgs>(base.Battle.CardUsing, new EventSequencedReactor<CardUsingEventArgs>(this.OnCardUsing));
			base.ReactOwnerEvent<CardUsingEventArgs>(base.Battle.CardUsed, new EventSequencedReactor<CardUsingEventArgs>(this.OnCardUsed));
		}

		private IEnumerable<BattleAction> OnCardUsing(CardUsingEventArgs args)
		{
			Card card = args.Card;
			PatchouliBoostCard boostCard = card as PatchouliBoostCard;
			bool flag = boostCard != null;
			if (flag)
			{
				this.boost = boostCard.Boost;
			}
			yield break;
		}

		private IEnumerable<BattleAction> OnCardUsed(CardUsingEventArgs args)
		{
			Card card = args.Card;
			PatchouliBoostCard boostCard = card as PatchouliBoostCard;
			bool flag = boostCard != null;
			if (flag)
			{
				base.NotifyActivating();
				EnemyUnit enemyUnitWithMaxHP = base.Battle.EnemyGroup.Alives.MaxBy((EnemyUnit unit) => unit.Hp);
				float damage = (float)this.boost * (float)base.Level;
				yield return new DamageAction(base.Battle.Player, enemyUnitWithMaxHP, DamageInfo.Reaction(damage, false), PatchouliGunName.GrandIncantation, GunType.Single);
				this.boost = 0;
				enemyUnitWithMaxHP = null;
			}
			yield break;
		}

		private int boost = 0;
	}
}
