using System;
using LBoL.Core;

namespace PatchouliCharacterMod.BattleActions
{
	public class TriggerSignPassiveEventArgs : GameEventArgs
	{
		public int Sign { get; internal set; }

		public override string GetBaseDebugString()
		{
			return "Trigger passive Sign: " + this.Sign.ToString();
		}
	}
}
