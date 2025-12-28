using System;
using System.Collections.Generic;
using System.Linq;
using LBoL.Core.Battle;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoLEntitySideloader.Attributes;
using ReimuUnifierMod.BattleActions;
using ReimuUnifierMod.Patches;

namespace ReimuUnifierMod.StatusEffects
{
	[EntityLogic(typeof(ReimuUnifierOmnidirectionalBarrageSeDef))]
	public sealed class ReimuUnifierOmnidirectionalBarrageSe : StatusEffect
	{
		protected override void OnAdded(Unit unit)
		{
			base.ReactOwnerEvent<TeamUpEventArgs>(CustomGameEventManager.TeamUpSuccess, new EventSequencedReactor<TeamUpEventArgs>(this.OnTeamUp));
		}

		private IEnumerable<BattleAction> OnTeamUp(TeamUpEventArgs args)
		{
			bool flag = !base.Battle.BattleShouldEnd && args.TeamUpCard.GetPassiveActions() != null && args.TeamUpCard.GetPassiveActions().Count<BattleAction>() > 0;
			if (flag)
			{
				int num;
				for (int i = 0; i < base.Level; i = num + 1)
				{
					foreach (BattleAction action in args.TeamUpCard.GetPassiveActions())
					{
						yield return action;
						action = null;
					}
					IEnumerator<BattleAction> enumerator = null;
					num = i;
				}
			}
			yield break;
			yield break;
		}
	}
}
