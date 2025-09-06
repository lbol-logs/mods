using System;
using LBoL.Core;
using LBoL.Core.Units;

namespace lvalonexrumia.Patches
{
	public class ChangeLifeEventArgs : GameEventArgs
	{
		public int Amount { get; set; }

		public Unit argsunit { get; set; }

		public override string GetBaseDebugString()
		{
			return "Life Changed: " + this.Amount.ToString() + " for " + ((this.argsunit != null) ? this.argsunit.Name : "Player");
		}
	}
}
