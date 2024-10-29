using System;
using HarmonyLib;
using LBoL.Core;

namespace YoumuCharacterMod.Patches
{
	[HarmonyPatch]
	internal class CustomGameEventPatch
	{
		public static GameEvent<GameEventArgs> Unsheathing { get; set; }

		public static GameEvent<GameEventArgs> Unsheathed { get; set; }

		[HarmonyPatch(typeof(GameRunController), "EnterBattle")]
		private static bool Prefix(GameRunController __instance)
		{
			CustomGameEventPatch.Unsheathing = new GameEvent<GameEventArgs>();
			CustomGameEventPatch.Unsheathed = new GameEvent<GameEventArgs>();
			return true;
		}
	}
}
