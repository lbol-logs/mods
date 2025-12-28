using System;
using HarmonyLib;

namespace ReimuUnifierMod
{
	public static class PInfo
	{
		public const string GUID = "Saevin.ReimuUnifierMod";

		public const string Name = "ReimuUnifier";

		public const string version = "1.1.3";

		public static readonly Harmony harmony = new Harmony("Saevin.ReimuUnifierMod");
	}
}
