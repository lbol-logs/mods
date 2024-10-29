using System;
using HarmonyLib;
using LBoL.Presentation.UI.Widgets;
using YoumuCharacterMod.Cards.Template;

namespace YoumuCharacterMod.Patches
{
	[HarmonyPatch]
	internal class CardWidgetPatch
	{
		[HarmonyPatch(typeof(CardWidget), "SetProperties")]
		private static void Postfix(CardWidget __instance)
		{
			YoumuCard youmuCard = __instance._card as YoumuCard;
			bool flag = youmuCard != null && youmuCard.HasDisplayField;
			if (flag)
			{
				__instance.baseLoyaltyObj.SetActive(true);
				__instance.baseLoyalty.text = youmuCard.DisplayField.ToString();
			}
		}
	}
}
