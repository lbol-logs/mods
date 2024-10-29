using System;
using System.Collections.Generic;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Cards;
using LBoL.Core.StatusEffects;
using LBoLEntitySideloader.Attributes;
using Sanae_Kochiya.Cards.Template;

namespace Sanae_Kochiya.Source.Cards.Rare
{
	[EntityLogic(typeof(SanaeHisouLeftLegDef))]
	public sealed class SanaeHisouLeftLeg : SampleCharacterCard
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
				bool isUpgraded = this.IsUpgraded;
				if (isUpgraded)
				{
					yield return base.DebuffAction<Weak>(base.Battle.Player, 0, base.Value1, 0, 0, false, 0.2f);
				}
				else
				{
					yield return base.DebuffAction<Fragil>(base.Battle.Player, 0, base.Value1, 0, 0, false, 0.2f);
				}
			}
			yield break;
		}
	}
}
