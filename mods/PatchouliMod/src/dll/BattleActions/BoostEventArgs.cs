using System;
using LBoL.Core;
using LBoL.Core.Cards;

namespace PatchouliCharacterMod.BattleActions
{
	public class BoostEventArgs : GameEventArgs
	{
		public Card Card { get; internal set; }

		public int Amount { get; internal set; }

		public override string GetBaseDebugString()
		{
			return "Boost " + this.Card.Id + "by " + this.Amount.ToString();
		}
	}
}
