using System;
using HarmonyLib;
using LBoL.Presentation.UI.Widgets;
using PatchouliCharacterMod.Cards.Template;

namespace PatchouliCharacterMod.Patch
{
	[HarmonyPatch]
	internal class BoostCardWidgetPatch
	{
		[HarmonyPatch(typeof(CardWidget), "SetProperties")]
		private static void Postfix(CardWidget __instance)
		{
			PatchouliBoostCard patchouliBoostCard = __instance._card as PatchouliBoostCard;
			bool flag = patchouliBoostCard != null;
			if (flag)
			{
				__instance.baseLoyaltyObj.SetActive(true);
				__instance.baseLoyalty.text = patchouliBoostCard.Boost.ToString();
			}
		}
	}
}
