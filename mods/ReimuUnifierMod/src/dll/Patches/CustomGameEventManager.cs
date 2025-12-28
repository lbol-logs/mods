using System;
using HarmonyLib;
using LBoL.Core;
using ReimuUnifierMod.BattleActions;

namespace ReimuUnifierMod.Patches
{
	[HarmonyPatch]
	internal class CustomGameEventManager
	{
		public static GameEvent<TeamUpEventArgs> TeamUpSuccess { get; set; }

		[HarmonyPatch(typeof(GameRunController), "EnterBattle")]
		private static bool Prefix(GameRunController __instance)
		{
			CustomGameEventManager.TeamUpSuccess = new GameEvent<TeamUpEventArgs>();
			return true;
		}
	}
}
