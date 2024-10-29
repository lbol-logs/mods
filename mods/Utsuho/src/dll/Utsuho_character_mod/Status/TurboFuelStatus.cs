using System;
using System.Collections;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Cards;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoL.Presentation;
using LBoLEntitySideloader.Attributes;
using UnityEngine;
using Utsuho_character_mod.Util;

namespace Utsuho_character_mod.Status
{
	[EntityLogic(typeof(TurboFuelEffect))]
	public sealed class TurboFuelStatus : StatusEffect
	{
		public ManaGroup manatype
		{
			get
			{
				return new ManaGroup
				{
					Philosophy = 1
				};
			}
		}

		protected override void OnAdded(Unit unit)
		{
			base.ReactOwnerEvent<UnitEventArgs>(base.Owner.TurnStarted, new EventSequencedReactor<UnitEventArgs>(this.OnOwnerTurnStarted));
		}

		private IEnumerator ResetTrigger()
		{
			yield return new WaitForSecondsRealtime(1f);
			this.NotifyChanged();
			yield break;
		}

		private IEnumerable<BattleAction> OnOwnerTurnStarted(UnitEventArgs args)
		{
			yield return new DrawManyCardAction(base.Level);
			yield return new GainManaAction(new ManaGroup
			{
				Philosophy = base.Level
			});
			Card card = UsefulFunctions.RandomUtsuho(base.Battle.HandZone);
			foreach (BattleAction action in UsefulFunctions.RandomCheck(card, base.Battle))
			{
				yield return action;
				action = null;
			}
			IEnumerator<BattleAction> enumerator = null;
			card.NotifyActivating();
			Singleton<GameMaster>.Instance.StartCoroutine(this.ResetTrigger());
			yield return new ExileCardAction(card);
			yield break;
			yield break;
		}
	}
}
