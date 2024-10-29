using System;
using HarmonyLib;

namespace YoumuCharacterMod
{
	public static class PInfo
	{
		public const string GUID = "rmrfmaxx.lbol.YoumuCharacterMod";

		public const string Name = "Youmu Character Mod";

		public const string version = "0.4.14";

		public static readonly Harmony harmony = new Harmony("rmrfmaxx.lbol.YoumuCharacterMod");
	}
}
