using System;
using HarmonyLib;
using LBoL.Core;
using LBoL.Core.Units;
using PatchouliCharacterMod.BattleActions;

namespace PatchouliCharacterMod.Patch
{
	[HarmonyPatch]
	internal class CustomGameEventPatch
	{
		public static GameEvent<BoostEventArgs> Boosted { get; set; }

		public static GameEvent<TriggerSignEventArgs> Spellcasting { get; set; }

		public static GameEvent<TriggerSignEventArgs> Spellcasted { get; set; }

		public static GameEvent<TriggerSignEventArgs> SignPassiveTriggering { get; set; }

		public static GameEvent<TriggerSignEventArgs> SignPassiveTriggered { get; set; }

		public static GameEvent<TriggerSignEventArgs> SignActiveTriggering { get; set; }

		public static GameEvent<TriggerSignEventArgs> SignActiveTriggered { get; set; }

		[HarmonyPatch(typeof(GameRunController), "EnterBattle")]
		private static bool Prefix(Unit __instance)
		{
			CustomGameEventPatch.Boosted = new GameEvent<BoostEventArgs>();
			CustomGameEventPatch.Spellcasting = new GameEvent<TriggerSignEventArgs>();
			CustomGameEventPatch.Spellcasted = new GameEvent<TriggerSignEventArgs>();
			CustomGameEventPatch.SignPassiveTriggering = new GameEvent<TriggerSignEventArgs>();
			CustomGameEventPatch.SignPassiveTriggered = new GameEvent<TriggerSignEventArgs>();
			CustomGameEventPatch.SignActiveTriggering = new GameEvent<TriggerSignEventArgs>();
			CustomGameEventPatch.SignActiveTriggered = new GameEvent<TriggerSignEventArgs>();
			return true;
		}
	}
}
