﻿using System;
using System.Collections.Generic;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Cards;
using LBoLEntitySideloader.Attributes;
using Sanae_Kochiya.Cards.Template;

namespace Sanae_Kochiya.Source.Cards.Rare
{
	[EntityLogic(typeof(SanaeHisouRightArmDef))]
	public sealed class SanaeHisouRightArm : SampleCharacterCard
	{
		protected override void OnEnterBattle(BattleController battle)
		{
			base.ReactBattleEvent<UnitEventArgs>(base.Battle.Player.TurnEnding, new EventSequencedReactor<UnitEventArgs>(this.OnPlayerTurnEnding));
		}

		private IEnumerable<BattleAction> OnPlayerTurnEnding(UnitEventArgs args)
		{
			bool flag = !base.Battle.BattleShouldEnd && base.Zone == CardZone.Hand;
			if (flag)
			{
				base.NotifyActivating();
				yield return base.DamageSelfAction(base.Value1, "StarPas");
			}
			yield break;
		}
	}
}
