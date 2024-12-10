using System;
using HarmonyLib;

namespace Momiji
{
	public static class PInfo
	{
		public const string GUID = "worldsoul.test.momiji.mod";

		public const string Name = "Momiji Mod";

		public const string version = "1.1.3";

		public static readonly Harmony harmony = new Harmony("worldsoul.test.momiji.mod");
	}
}
