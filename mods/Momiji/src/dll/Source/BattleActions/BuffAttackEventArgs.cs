using System;
using LBoL.Core;
using LBoL.Core.Cards;

namespace Momiji.Source.BattleActions
{
	public class BuffAttackEventArgs : GameEventArgs
	{
		public Card Card { get; internal set; }

		public int Amount { get; internal set; }

		public override string GetBaseDebugString()
		{
			return "Buff: " + this.Amount.ToString();
		}
	}
}
