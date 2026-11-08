using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using HarmonyLib;
using LBoL.Base.Extensions;
using LBoL.Core.Units;
using LBoL.Presentation;
using LBoL.Presentation.UI.Widgets;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace AyaShameimaru.EnemyUnits
{
	[HarmonyPatch(typeof(IntentionWidget), "UpdateProperties")]
	internal class IntentionWidget_UpdateProperties_Patch
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static bool Prefix(IntentionWidget __instance)
		{
			if (!(__instance._intention is AyaBossFlandreSpellCardsIntentionDef.AyaBossFlandreSpellCardsIntention))
			{
				goto IL_0010;
			}
			goto IL_01D7;
			int num2;
			Sprite sprite;
			for (;;)
			{
				IL_0015:
				int num = num2;
				uint num3;
				switch ((num3 = (uint)((((num * -1681609507) ^ (1720911861 * ~351628893)) - (658696263 + -1145247931)) * -617235773)) % 18U)
				{
				case 0U:
				{
					string text = IntentionWidget_UpdateProperties_Patch.\u200D\u206B\u202C\u200F\u202B\u206D\u206E\u202C\u202B\u206B\u206B\u200C\u206E\u202A\u202B\u206D\u206F\u206C\u206B\u206D\u200B\u200D\u202C\u200D\u200C\u202A\u206F\u202D\u200D\u200D\u202E\u206D\u200C\u206F\u200C\u206C\u200D\u206B\u206B\u200C\u202E(IntentionWidget_UpdateProperties_Patch.\u206F\u206C\u200D\u206E\u206C\u206B\u202A\u206E\u200C\u200E\u206D\u202A\u202D\u206D\u202B\u206A\u206B\u206B\u200F\u206D\u206E\u200E\u206D\u206C\u202E\u206B\u202C\u200C\u206A\u206F\u206C\u206C\u200F\u202E\u200F\u206A\u202B\u202D\u206A\u200F\u202E(__instance._intention));
					num2 = ((!IntentionWidget_UpdateProperties_Patch.\u200C\u202E\u200C\u202D\u202E\u206C\u206E\u200B\u202C\u206E\u200E\u202D\u206B\u206D\u202B\u200B\u200B\u202B\u206F\u200D\u206E\u200F\u206A\u206A\u200B\u200F\u206D\u200C\u202A\u206D\u206D\u200E\u200F\u202B\u206F\u206A\u202A\u200C\u202E\u202D\u202E(__instance._intention.SpecialIconName)) ? (-1509490653) : 243838113);
					continue;
				}
				case 1U:
					IntentionWidget_UpdateProperties_Patch.\u202C\u206F\u200F\u200E\u202E\u200C\u202E\u200B\u206D\u206A\u200E\u200E\u202A\u202B\u200F\u206C\u206F\u202B\u206E\u200C\u206A\u206F\u206A\u200D\u206A\u206C\u206E\u202A\u206C\u200D\u206A\u200D\u200E\u200F\u206F\u202B\u202A\u202D\u202E\u206B\u202E(__instance.text, new Color32(byte.MaxValue, 0, 0, byte.MaxValue));
					IntentionWidget_UpdateProperties_Patch.\u206D\u206D\u200B\u206B\u206D\u202C\u200F\u200E\u202B\u206B\u202D\u206A\u206E\u200E\u200D\u206C\u202C\u206D\u206E\u202D\u206A\u206E\u202C\u200F\u200F\u202B\u200C\u206E\u206E\u202E\u200E\u206D\u202A\u206E\u206A\u202C\u206D\u202B\u206D\u200F\u202E(IntentionWidget_UpdateProperties_Patch.\u202D\u202A\u200D\u202A\u200C\u206C\u202D\u206A\u206D\u202B\u202E\u202D\u200C\u202B\u206C\u206E\u206E\u202A\u206A\u202B\u200B\u200D\u206A\u200F\u206A\u206C\u202A\u202A\u206C\u206D\u202B\u202E\u202A\u200F\u206C\u206A\u200D\u206A\u202A\u202B\u202E(__instance.text), true);
					num2 = (int)((num3 * 2139247333U) ^ 4001870823U);
					continue;
				case 2U:
					num2 = (int)((num3 * 6136577U) ^ 1577792874U);
					continue;
				case 3U:
					goto IL_00C0;
				case 4U:
					IntentionWidget_UpdateProperties_Patch.\u206F\u202D\u200B\u200D\u206D\u202C\u206A\u202B\u206C\u200B\u206C\u202A\u200E\u202A\u206F\u202B\u202B\u206A\u206B\u202C\u202A\u202A\u206A\u200C\u202D\u202B\u206F\u202C\u206F\u200D\u202D\u206A\u200E\u202A\u206A\u206A\u202D\u206D\u206C\u206E\u202E(IntentionWidget_UpdateProperties_Patch.\u206B\u202C\u206E\u206B\u202A\u206D\u206D\u200B\u206E\u206A\u206D\u206A\u200D\u202C\u202C\u200F\u206C\u206F\u200C\u200E\u202A\u200B\u200B\u206E\u202D\u200D\u200D\u200F\u202D\u200E\u202C\u202E\u202C\u202E\u206C\u200B\u200B\u202A\u202A\u200D\u202E(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-335850789), IntentionWidget_UpdateProperties_Patch.\u200D\u206B\u202C\u200F\u202B\u206D\u206E\u202C\u202B\u206B\u206B\u200C\u206E\u202A\u202B\u206D\u206F\u206C\u206B\u206D\u200B\u200D\u202C\u200D\u200C\u202A\u206F\u202D\u200D\u200D\u202E\u206D\u200C\u206F\u200C\u206C\u200D\u206B\u206B\u200C\u202E(IntentionWidget_UpdateProperties_Patch.\u206F\u206C\u200D\u206E\u206C\u206B\u202A\u206E\u200C\u200E\u206D\u202A\u202D\u206D\u202B\u206A\u206B\u206B\u200F\u206D\u206E\u200E\u206D\u206C\u202E\u206B\u202C\u200C\u206A\u206F\u206C\u206C\u200F\u202E\u200F\u206A\u202B\u202D\u206A\u200F\u202E(__instance._intention))));
					num2 = -2067596298;
					continue;
				case 5U:
				{
					AyaBossKoishiUnconsciousActionIntentionDef.AyaBossKoishiUnconsciousActionIntention ayaBossKoishiUnconsciousActionIntention;
					num2 = (int)(((ayaBossKoishiUnconsciousActionIntention == null) ? 2426681924U : 4286111906U) ^ (num3 * 1849582514U));
					continue;
				}
				case 6U:
					num2 = (int)(((!(__instance._intention is AyaBossKoishiUnconsciousActionIntentionDef.AyaBossKoishiUnconsciousActionIntention)) ? 416437071U : 4130912248U) ^ (num3 * 2129726943U));
					continue;
				case 7U:
					IntentionWidget_UpdateProperties_Patch.\u206D\u206D\u200B\u206B\u206D\u202C\u200F\u200E\u202B\u206B\u202D\u206A\u206E\u200E\u200D\u206C\u202C\u206D\u206E\u202D\u206A\u206E\u202C\u200F\u200F\u202B\u200C\u206E\u206E\u202E\u200E\u206D\u202A\u206E\u206A\u202C\u206D\u202B\u206D\u200F\u202E(IntentionWidget_UpdateProperties_Patch.\u202D\u202A\u200D\u202A\u200C\u206C\u202D\u206A\u206D\u202B\u202E\u202D\u200C\u202B\u206C\u206E\u206E\u202A\u206A\u202B\u200B\u200D\u206A\u200F\u206A\u206C\u202A\u202A\u206C\u206D\u202B\u202E\u202A\u200F\u206C\u206A\u200D\u206A\u202A\u202B\u202E(__instance.text), true);
					num2 = (int)((num3 * 305309940U) ^ 1887383102U);
					continue;
				case 8U:
					goto IL_01D7;
				case 9U:
				{
					string text;
					string text2;
					sprite = IntentionWidget_UpdateProperties_Patch.\u200D\u206F\u200E\u206A\u200E\u202E\u202D\u202E\u206D\u202D\u206B\u200E\u202B\u202A\u206B\u200B\u202C\u202C\u202A\u202B\u206B\u200E\u202A\u206B\u200F\u206F\u200C\u206A\u206C\u206E\u206D\u200D\u200D\u202A\u202E\u206D\u206C\u202C\u206E\u206B\u202E(text, text2);
					num2 = ((!IntentionWidget_UpdateProperties_Patch.\u200D\u206C\u202D\u206D\u202A\u206F\u206C\u206B\u206B\u200F\u200D\u206F\u202C\u206F\u206E\u206D\u206F\u202E\u206E\u202C\u206D\u200C\u206D\u200C\u202C\u206F\u206D\u202A\u200F\u202D\u200E\u206D\u200F\u206E\u200F\u206E\u206D\u200E\u202B\u206B\u202E(sprite, null)) ? 590569080 : (-155343157));
					continue;
				}
				case 10U:
				{
					AyaBossKoishiUnconsciousActionIntentionDef.AyaBossKoishiUnconsciousActionIntention ayaBossKoishiUnconsciousActionIntention;
					IntentionWidget_UpdateProperties_Patch.\u206B\u200C\u200E\u200B\u202E\u202A\u200B\u206E\u202D\u206D\u206B\u202E\u202D\u206D\u200C\u202B\u206B\u206D\u202D\u206E\u206A\u202E\u206B\u200C\u206A\u206C\u200F\u202B\u206B\u206D\u202E\u206A\u200B\u202C\u200F\u200B\u200B\u202D\u200C\u202B\u202E(__instance.text, ayaBossKoishiUnconsciousActionIntention.Counter.ToString());
					IntentionWidget_UpdateProperties_Patch.\u202C\u206F\u200F\u200E\u202E\u200C\u202E\u200B\u206D\u206A\u200E\u200E\u202A\u202B\u200F\u206C\u206F\u202B\u206E\u200C\u206A\u206F\u206A\u200D\u206A\u206C\u206E\u202A\u206C\u200D\u206A\u200D\u200E\u200F\u206F\u202B\u202A\u202D\u202E\u206B\u202E(__instance.text, IntentionWidget.CountDownColor);
					num2 = -913905911;
					continue;
				}
				case 11U:
				{
					Intention intention;
					AyaBossKoishiUnconsciousActionIntentionDef.AyaBossKoishiUnconsciousActionIntention ayaBossKoishiUnconsciousActionIntention = intention as AyaBossKoishiUnconsciousActionIntentionDef.AyaBossKoishiUnconsciousActionIntention;
					num2 = (int)((num3 * 638290271U) ^ 1419450934U);
					continue;
				}
				case 12U:
					goto IL_0010;
				case 13U:
				{
					AyaBossFlandreSpellCardsIntentionDef.AyaBossFlandreSpellCardsIntention ayaBossFlandreSpellCardsIntention;
					IntentionWidget_UpdateProperties_Patch.\u206B\u200C\u200E\u200B\u202E\u202A\u200B\u206E\u202D\u206D\u206B\u202E\u202D\u206D\u200C\u202B\u206B\u206D\u202D\u206E\u206A\u202E\u206B\u200C\u206A\u206C\u200F\u202B\u206B\u206D\u202E\u206A\u200B\u202C\u200F\u200B\u200B\u202D\u200C\u202B\u202E(__instance.text, ayaBossFlandreSpellCardsIntention.Counter.ToString());
					num2 = -533767479;
					continue;
				}
				case 14U:
					return false;
				case 16U:
				{
					string text2 = null;
					Intention intention = __instance._intention;
					AyaBossFlandreSpellCardsIntentionDef.AyaBossFlandreSpellCardsIntention ayaBossFlandreSpellCardsIntention = intention as AyaBossFlandreSpellCardsIntentionDef.AyaBossFlandreSpellCardsIntention;
					num2 = (int)(((ayaBossFlandreSpellCardsIntention != null) ? 234275697U : 2173135713U) ^ (num3 * 3716405767U));
					continue;
				}
				case 17U:
				{
					string text = __instance._intention.SpecialIconName;
					num2 = (int)((num3 * 3780154238U) ^ 3472688251U);
					continue;
				}
				}
				break;
			}
			return true;
			IL_00C0:
			IntentionWidget_UpdateProperties_Patch.\u200F\u202D\u202D\u200E\u206A\u200F\u206D\u202D\u206E\u206E\u202B\u206D\u206E\u202C\u202E\u200B\u202A\u206E\u206F\u206A\u200C\u200C\u206F\u206B\u202E\u202B\u200E\u200B\u206B\u200E\u206D\u202E\u202A\u202E\u202C\u202C\u200F\u200F\u206B\u206B\u202E(__instance.intentionImage, sprite);
			return false;
			IL_0010:
			num2 = 1842999794;
			goto IL_0015;
			IL_01D7:
			IntentionWidget_UpdateProperties_Patch.\u206D\u206D\u200B\u206B\u206D\u202C\u200F\u200E\u202B\u206B\u202D\u206A\u206E\u200E\u200D\u206C\u202C\u206D\u206E\u202D\u206A\u206E\u202C\u200F\u200F\u202B\u200C\u206E\u206E\u202E\u200E\u206D\u202A\u206E\u206A\u202C\u206D\u202B\u206D\u200F\u202E(IntentionWidget_UpdateProperties_Patch.\u202D\u202D\u202D\u206C\u202A\u200E\u206F\u200D\u200C\u200B\u206F\u206B\u200F\u206C\u206D\u206C\u202E\u202D\u200C\u202E\u200E\u206A\u206B\u206A\u200B\u206D\u200B\u200C\u202B\u200E\u202B\u202A\u206D\u200C\u200B\u202A\u206E\u200F\u200F\u202A\u202E(__instance.accuracyParticle), false);
			num2 = -1903415830;
			goto IL_0015;
		}

		static GameObject \u202D\u202D\u202D\u206C\u202A\u200E\u206F\u200D\u200C\u200B\u206F\u206B\u200F\u206C\u206D\u206C\u202E\u202D\u200C\u202E\u200E\u206A\u206B\u206A\u200B\u206D\u200B\u200C\u202B\u200E\u202B\u202A\u206D\u200C\u200B\u202A\u206E\u200F\u200F\u202A\u202E(GameObject A_0)
		{
			return A_0.gameObject;
		}

		static void \u206D\u206D\u200B\u206B\u206D\u202C\u200F\u200E\u202B\u206B\u202D\u206A\u206E\u200E\u200D\u206C\u202C\u206D\u206E\u202D\u206A\u206E\u202C\u200F\u200F\u202B\u200C\u206E\u206E\u202E\u200E\u206D\u202A\u206E\u206A\u202C\u206D\u202B\u206D\u200F\u202E(GameObject A_0, bool A_1)
		{
			A_0.SetActive(A_1);
		}

		static void \u206B\u200C\u200E\u200B\u202E\u202A\u200B\u206E\u202D\u206D\u206B\u202E\u202D\u206D\u200C\u202B\u206B\u206D\u202D\u206E\u206A\u202E\u206B\u200C\u206A\u206C\u200F\u202B\u206B\u206D\u202E\u206A\u200B\u202C\u200F\u200B\u200B\u202D\u200C\u202B\u202E(TMP_Text A_0, string A_1)
		{
			A_0.text = A_1;
		}

		static void \u202C\u206F\u200F\u200E\u202E\u200C\u202E\u200B\u206D\u206A\u200E\u200E\u202A\u202B\u200F\u206C\u206F\u202B\u206E\u200C\u206A\u206F\u206A\u200D\u206A\u206C\u206E\u202A\u206C\u200D\u206A\u200D\u200E\u200F\u206F\u202B\u202A\u202D\u202E\u206B\u202E(Graphic A_0, Color A_1)
		{
			A_0.color = A_1;
		}

		static GameObject \u202D\u202A\u200D\u202A\u200C\u206C\u202D\u206A\u206D\u202B\u202E\u202D\u200C\u202B\u206C\u206E\u206E\u202A\u206A\u202B\u200B\u200D\u206A\u200F\u206A\u206C\u202A\u202A\u206C\u206D\u202B\u202E\u202A\u200F\u206C\u206A\u200D\u206A\u202A\u202B\u202E(Component A_0)
		{
			return A_0.gameObject;
		}

		static Type \u206F\u206C\u200D\u206E\u206C\u206B\u202A\u206E\u200C\u200E\u206D\u202A\u202D\u206D\u202B\u206A\u206B\u206B\u200F\u206D\u206E\u200E\u206D\u206C\u202E\u206B\u202C\u200C\u206A\u206F\u206C\u206C\u200F\u202E\u200F\u206A\u202B\u202D\u206A\u200F\u202E(object A_0)
		{
			return A_0.GetType();
		}

		static string \u200D\u206B\u202C\u200F\u202B\u206D\u206E\u202C\u202B\u206B\u206B\u200C\u206E\u202A\u202B\u206D\u206F\u206C\u206B\u206D\u200B\u200D\u202C\u200D\u200C\u202A\u206F\u202D\u200D\u200D\u202E\u206D\u200C\u206F\u200C\u206C\u200D\u206B\u206B\u200C\u202E(MemberInfo A_0)
		{
			return A_0.Name;
		}

		static bool \u200C\u202E\u200C\u202D\u202E\u206C\u206E\u200B\u202C\u206E\u200E\u202D\u206B\u206D\u202B\u200B\u200B\u202B\u206F\u200D\u206E\u200F\u206A\u206A\u200B\u200F\u206D\u200C\u202A\u206D\u206D\u200E\u200F\u202B\u206F\u206A\u202A\u200C\u202E\u202D\u202E(string A_0)
		{
			return A_0.IsNullOrEmpty();
		}

		static Sprite \u200D\u206F\u200E\u206A\u200E\u202E\u202D\u202E\u206D\u202D\u206B\u200E\u202B\u202A\u206B\u200B\u202C\u202C\u202A\u202B\u206B\u200E\u202A\u206B\u200F\u206F\u200C\u206A\u206C\u206E\u206D\u200D\u200D\u202A\u202E\u206D\u206C\u202C\u206E\u206B\u202E(string A_0, string A_1)
		{
			return ResourcesHelper.TryGetIntention(A_0, A_1);
		}

		static bool \u200D\u206C\u202D\u206D\u202A\u206F\u206C\u206B\u206B\u200F\u200D\u206F\u202C\u206F\u206E\u206D\u206F\u202E\u206E\u202C\u206D\u200C\u206D\u200C\u202C\u206F\u206D\u202A\u200F\u202D\u200E\u206D\u200F\u206E\u200F\u206E\u206D\u200E\u202B\u206B\u202E(global::UnityEngine.Object A_0, global::UnityEngine.Object A_1)
		{
			return A_0 != A_1;
		}

		static void \u200F\u202D\u202D\u200E\u206A\u200F\u206D\u202D\u206E\u206E\u202B\u206D\u206E\u202C\u202E\u200B\u202A\u206E\u206F\u206A\u200C\u200C\u206F\u206B\u202E\u202B\u200E\u200B\u206B\u200E\u206D\u202E\u202A\u202E\u202C\u202C\u200F\u200F\u206B\u206B\u202E(Image A_0, Sprite A_1)
		{
			A_0.sprite = A_1;
		}

		static string \u206B\u202C\u206E\u206B\u202A\u206D\u206D\u200B\u206E\u206A\u206D\u206A\u200D\u202C\u202C\u200F\u206C\u206F\u200C\u200E\u202A\u200B\u200B\u206E\u202D\u200D\u200D\u200F\u202D\u200E\u202C\u202E\u202C\u202E\u206C\u200B\u200B\u202A\u202A\u200D\u202E(string A_0, string A_1)
		{
			return A_0 + A_1;
		}

		static void \u206F\u202D\u200B\u200D\u206D\u202C\u206A\u202B\u206C\u200B\u206C\u202A\u200E\u202A\u206F\u202B\u202B\u206A\u206B\u202C\u202A\u202A\u206A\u200C\u202D\u202B\u206F\u202C\u206F\u200D\u202D\u206A\u200E\u202A\u206A\u206A\u202D\u206D\u206C\u206E\u202E(object A_0)
		{
			Debug.LogWarning(A_0);
		}
	}
}
