using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoLEntitySideloader.Attributes;
using ReimuUnifierMod.BattleActions;
using ReimuUnifierMod.Patches;

namespace ReimuUnifierMod.StatusEffects
{
	[EntityLogic(typeof(ReimuUnifierBattleFeverSeDef))]
	public sealed class ReimuUnifierBattleFeverSe : StatusEffect
	{
		private ManaGroup SePreviewMana
		{
			get
			{
				return ManaGroup.Reds(base.Level);
			}
		}

		protected override void OnAdded(Unit unit)
		{
			base.ReactOwnerEvent<TeamUpEventArgs>(CustomGameEventManager.TeamUpSuccess, new EventSequencedReactor<TeamUpEventArgs>(this.OnTeamUp));
		}

		private IEnumerable<BattleAction> OnTeamUp(TeamUpEventArgs args)
		{
			bool flag = !base.Battle.BattleShouldEnd;
			if (flag)
			{
				yield return new GainManaAction(new ManaGroup
				{
					Red = base.Level
				});
			}
			yield break;
		}
	}
}
