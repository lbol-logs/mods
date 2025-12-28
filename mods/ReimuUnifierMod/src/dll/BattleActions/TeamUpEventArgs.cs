using System;
using LBoL.Core;
using LBoL.Core.Cards;

namespace ReimuUnifierMod.BattleActions
{
	public class TeamUpEventArgs : GameEventArgs
	{
		public Card SourceCard { get; internal set; }

		public Card TeamUpCard { get; internal set; }

		protected override string GetBaseDebugString()
		{
			return "TeamUp: SourceCard";
		}
	}
}
