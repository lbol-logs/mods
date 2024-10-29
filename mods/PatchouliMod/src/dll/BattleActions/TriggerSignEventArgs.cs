using System;
using LBoL.Core;
using PatchouliCharacterMod.StatusEffects;

namespace PatchouliCharacterMod.BattleActions
{
	public class TriggerSignEventArgs : GameEventArgs
	{
		public PatchouliSignSe Sign { get; internal set; }

		public bool IsActive { get; internal set; }

		public bool Spellcasting { get; internal set; }

		public override string GetBaseDebugString()
		{
			string text = "Sign = ";
			PatchouliSignSe sign = this.Sign;
			return text + ((sign != null) ? sign.ToString() : null);
		}
	}
}
