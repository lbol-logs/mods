using System;
using HarmonyLib;
using LBoL.Presentation.UI.Widgets;
using PatchouliCharacterMod.StatusEffects;

namespace PatchouliCharacterMod.Patch
{
	[HarmonyPatch]
	internal class SignStatusEffectWidgetPatch
	{
		[HarmonyPatch(typeof(StatusEffectWidget), "TextRefresh")]
		private static void Postfix(StatusEffectWidget __instance)
		{
			PatchouliSignSe patchouliSignSe = __instance._statusEffect as PatchouliSignSe;
			bool flag = patchouliSignSe != null;
			if (flag)
			{
				__instance.downText.text = patchouliSignSe.PassiveAmount.ToString() + "/" + patchouliSignSe.ActiveAmount.ToString();
			}
		}
	}
}
