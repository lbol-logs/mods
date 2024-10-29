using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Cards;
using LBoLEntitySideloader.Attributes;
using PatchouliCharacterMod.BattleActions;
using PatchouliCharacterMod.Cards.Template;
using PatchouliCharacterMod.Patch;
using PatchouliCharacterMod.StatusEffects;

namespace PatchouliCharacterMod.Cards
{
	[EntityLogic(typeof(PatchouliSylphyHornDef))]
	public sealed class PatchouliSylphyHorn : PatchouliCard
	{
		protected override void OnEnterBattle(BattleController battle)
		{
			base.ReactBattleEvent<TriggerSignEventArgs>(CustomGameEventPatch.SignActiveTriggered, new EventSequencedReactor<TriggerSignEventArgs>(this.OnSignActiveTriggered));
		}

		private IEnumerable<BattleAction> OnSignActiveTriggered(TriggerSignEventArgs args)
		{
			bool flag = base.Zone == CardZone.Exile && args.Sign is PatchouliWoodSignSe;
			if (flag)
			{
				yield return new MoveCardAction(this, CardZone.Hand);
			}
			yield break;
		}

		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			yield return base.BuffAction<PatchouliWoodSignSe>(base.Value1, 0, 0, PatchouliSignSe.TurnLimit, 0.2f);
			yield break;
		}
	}
}
