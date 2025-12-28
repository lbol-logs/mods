using System;
using System.Collections.Generic;
using LBoL.Core.Battle;
using LBoL.Core.Cards;
using ReimuUnifierMod.Patches;

namespace ReimuUnifierMod.BattleActions
{
	internal class TeamUpAction : SimpleAction
	{
		internal TeamUpAction(Card Sourcecard, Card TeamUpCard)
		{
			this._args = new TeamUpEventArgs();
			this._args.SourceCard = Sourcecard;
			this._args.TeamUpCard = TeamUpCard;
		}

		public override IEnumerable<Phase> GetPhases()
		{
			yield return base.CreateEventPhase<TeamUpEventArgs>("TeamUpSuccess", this._args, CustomGameEventManager.TeamUpSuccess);
			yield break;
		}

		private readonly TeamUpEventArgs _args;
	}
}
