using System;
using System.Reflection.Emit;
using HarmonyLib;

namespace PullFix.Patches
{
	public static class Helpers
	{
		public static CodeMatcher LeaveJumpFix(this CodeMatcher matcher)
		{
			matcher.Start();
			while (matcher.IsValid)
			{
				matcher.MatchEndForward(new CodeMatch[] { OpCodes.Leave }).Advance(1);
				bool isInvalid = matcher.IsInvalid;
				if (isInvalid)
				{
					break;
				}
				matcher.InsertAndAdvance(new CodeInstruction[]
				{
					new CodeInstruction(OpCodes.Nop, null)
				});
			}
			return matcher;
		}
	}
}
