using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Cards;
using LBoLEntitySideloader.Attributes;
using PatchouliCharacterMod.Cards.Template;

namespace PatchouliCharacterMod.Cards
{
	[EntityLogic(typeof(PatchouliEveryAngleShotDef))]
	public sealed class PatchouliEveryAngleShot : PatchouliBoostCard
	{
		public bool ReturnToHand { get; set; } = false;

		protected override bool HasTreshold { get; set; } = true;

		protected override int BoostThreshold1 { get; set; } = 4;

		protected override void OnEnterBattle(BattleController battle)
		{
			base.OnEnterBattle(battle);
			base.ReactBattleEvent<UnitEventArgs>(base.Battle.Player.TurnStarted, new EventSequencedReactor<UnitEventArgs>(this.OnTurnStarted));
		}

		private IEnumerable<BattleAction> OnTurnStarted(UnitEventArgs args)
		{
			bool flag = base.Zone == CardZone.Exile && this.ReturnToHand;
			if (flag)
			{
				this.ReturnToHand = false;
				yield return new MoveCardAction(this, CardZone.Hand);
			}
			yield break;
		}

		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			yield return base.AttackAction(selector, base.GunName);
			bool flag = base.Boost >= this.BoostThreshold1 && !base.Battle.BattleShouldEnd;
			if (flag)
			{
				this.ReturnToHand = true;
				base.ResetBoost();
			}
			yield break;
		}
	}
}
