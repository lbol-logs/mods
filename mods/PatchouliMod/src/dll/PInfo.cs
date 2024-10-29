using System;
using HarmonyLib;

namespace PatchouliCharacterMod
{
	public static class PInfo
	{
		public const string GUID = "rmrfmaxx.lbol.PatchouliCharacterMod";

		public const string Name = "Patchouli Character Mod";

		public const string version = "0.1.11";

		public static readonly Harmony harmony = new Harmony("rmrfmaxx.lbol.PatchouliCharacterMod");
	}
}
