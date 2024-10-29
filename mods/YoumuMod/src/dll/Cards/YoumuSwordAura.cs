using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Cards;
using LBoL.Core.StatusEffects;
using LBoLEntitySideloader.Attributes;
using YoumuCharacterMod.Cards.Template;
using YoumuCharacterMod.Patches;

namespace YoumuCharacterMod.Cards
{
	[EntityLogic(typeof(YoumuSwordAuraDef))]
	public sealed class YoumuSwordAura : YoumuCard
	{
		protected override void OnEnterBattle(BattleController battle)
		{
			base.ReactBattleEvent<GameEventArgs>(CustomGameEventPatch.Unsheathed, new EventSequencedReactor<GameEventArgs>(this.OnUnsheathe));
		}

		private IEnumerable<BattleAction> OnUnsheathe(GameEventArgs args)
		{
			bool flag = base.Zone == CardZone.Hand;
			if (flag)
			{
				base.DeltaValue1++;
			}
			yield break;
		}

		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			yield return base.BuffAction<Firepower>(base.Value1, 0, 0, 0, 0.2f);
			yield break;
		}

		public override IEnumerable<BattleAction> OnMove(CardZone srcZone, CardZone dstZone)
		{
			bool flag = !base.Battle.BattleShouldEnd && srcZone == CardZone.Hand && dstZone != CardZone.Hand;
			if (flag)
			{
				base.DeltaValue1 = 0;
			}
			bool flag2 = dstZone != CardZone.Hand;
			IEnumerable<BattleAction> enumerable;
			if (flag2)
			{
				enumerable = null;
			}
			else
			{
				enumerable = base.OnMove(srcZone, dstZone);
			}
			return enumerable;
		}

		public override IEnumerable<BattleAction> OnDiscard(CardZone srcZone)
		{
			bool flag = !base.Battle.BattleShouldEnd && srcZone == CardZone.Hand;
			if (flag)
			{
				base.DeltaValue1 = 0;
			}
			return base.OnDiscard(srcZone);
		}

		public override IEnumerable<BattleAction> OnExile(CardZone srcZone)
		{
			bool flag = !base.Battle.BattleShouldEnd && srcZone == CardZone.Hand;
			if (flag)
			{
				base.DeltaValue1 = 0;
			}
			return base.OnExile(srcZone);
		}
	}
}
