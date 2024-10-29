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
	[EntityLogic(typeof(PatchouliRoyalFlareDef))]
	public sealed class PatchouliRoyalFlare : PatchouliCard
	{
		protected override void OnEnterBattle(BattleController battle)
		{
			base.ReactBattleEvent<UnitEventArgs>(base.Battle.Player.TurnStarting, new EventSequencedReactor<UnitEventArgs>(this.OnPlayerTurnStarting));
			base.ReactBattleEvent<TriggerSignEventArgs>(CustomGameEventPatch.Spellcasted, new EventSequencedReactor<TriggerSignEventArgs>(this.OnSignGained));
		}

		private IEnumerable<BattleAction> OnSignGained(TriggerSignEventArgs args)
		{
			bool flag = base.Zone == CardZone.Hand;
			if (flag)
			{
				base.NotifyActivating();
				base.DeltaValue2--;
				bool flag2 = base.Value2 <= 0;
				if (flag2)
				{
					base.DeltaValue2 = 0;
					yield return new DamageAction(base.Battle.Player, base.Battle.EnemyGroup.Alives, DamageInfo.Reaction(base.Damage.Amount, false), base.GunName, GunType.Single);
					bool flag3 = !base.Battle.BattleShouldEnd;
					if (flag3)
					{
						yield return new DiscardAction(this);
					}
				}
			}
			yield break;
		}

		private IEnumerable<BattleAction> OnPlayerTurnStarting(UnitEventArgs args)
		{
			bool flag = base.Zone == CardZone.Hand;
			if (flag)
			{
				yield return base.BuffAction<PatchouliTemporaryIntelligenceSe>(base.Value1, 0, 0, 0, 0.2f);
			}
			yield break;
		}

		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			yield break;
		}
	}
}
