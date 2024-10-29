using System;
using System.Collections.Generic;
using HarmonyLib;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.EntityLib.EnemyUnits.Character;
using LBoL.EntityLib.StatusEffects.Enemy;
using Sanae_Kochiya.Source.Boss;

[HarmonyPatch(typeof(Siji))]
internal class Siji_OnBattleStarted_Patch
{
	[HarmonyPatch("OnBattleStarted", new Type[] { typeof(GameEventArgs) })]
	private static bool Prefix(Siji __instance, ref IEnumerable<BattleAction> __result, GameEventArgs arg)
	{
		string id = __instance.GameRun.Player.Id;
		bool flag = id == "Sanae_Kochiya";
		bool flag4;
		if (flag)
		{
			string text = "净颇梨审判";
			text += " -博丽灵梦-";
			Type typeFromHandle = typeof(Sanae_KochiyaBossDef.Sanae_Kochiya);
			string text2 = "Chat.Siji2".LocalizeFormat(new object[] { __instance.Battle.Player.GetName() });
			int count = __instance.Battle.Player.Exhibits.Count;
			int num = 1;
			bool flag2 = count >= 20;
			if (flag2)
			{
				num = 3;
			}
			else
			{
				bool flag3 = count >= 10;
				if (flag3)
				{
					num = 2;
				}
			}
			__result = new List<BattleAction>
			{
				PerformAction.Chat(__instance, "Chat.Siji1".Localize(true), 3f, 0f, 3.2f, true),
				PerformAction.Animation(__instance, "shoot2", 0f, null, 0f, -1),
				PerformAction.Chat(__instance, text2, 3f, 0f, 3.2f, true),
				PerformAction.Animation(__instance, "spell", 0f, null, 0f, -1),
				PerformAction.Spell(__instance, text),
				new SpawnEnemyAction(__instance, typeFromHandle, 2, 0f, 0.3f, false),
				new ApplyStatusEffectAction<SijiZui>(__instance, new int?(num), null, null, null, 0f, true)
			};
			flag4 = false;
		}
		else
		{
			flag4 = true;
		}
		return flag4;
	}
}
