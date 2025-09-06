using System;
using HarmonyLib;
using LBoL.ConfigData;
using LBoL.Core;
using LBoL.Core.Randoms;
using LBoL.Core.Stations;
using LBoL.Core.Units;
using LBoL.Presentation;

namespace lvalonexrumia.Patches
{
	[HarmonyPatch]
	internal class CustomGameEventManager
	{
		public static GameEvent<ChangeLifeEventArgs> PreChangeLifeEvent { get; set; }

		public static GameEvent<ChangeLifeEventArgs> PostChangeLifeEvent { get; set; }

		[HarmonyPatch(typeof(GameRunController), "EnterBattle")]
		private static bool Prefix(GameRunController __instance)
		{
			CustomGameEventManager.PreChangeLifeEvent = new GameEvent<ChangeLifeEventArgs>();
			CustomGameEventManager.PostChangeLifeEvent = new GameEvent<ChangeLifeEventArgs>();
			return true;
		}

		[HarmonyPatch(typeof(ExhibitWeightTable), "WeightFor", new Type[] { typeof(ExhibitConfig) })]
		[HarmonyPostfix]
		public static void OverrideWeightFor(ExhibitWeightTable __instance, ExhibitConfig exhibitConfig, ref float __result)
		{
			bool flag = Singleton<GameMaster>.Instance.CurrentGameRun != null;
			if (flag)
			{
				bool flag2 = Singleton<GameMaster>.Instance.CurrentGameRun.Player.Id == "lvalonexrumia" && exhibitConfig.Id == "Duandai";
				if (flag2)
				{
					__result = 0f;
				}
			}
		}

		[HarmonyPatch(typeof(AudioManager), "PlayBossBgm")]
		internal class AudioManager_PlayBossBgm_Patch_exrumia
		{
			private static bool Prefix(AudioManager __instance)
			{
				GameMaster instance = Singleton<GameMaster>.Instance;
				bool flag = instance == null;
				object obj;
				if (flag)
				{
					obj = null;
				}
				else
				{
					GameRunController currentGameRun = instance.CurrentGameRun;
					obj = ((currentGameRun != null) ? currentGameRun.CurrentStation : null);
				}
				Station station = (Station)obj;
				BossStation bossStation = (BossStation)((station is BossStation) ? station : null);
				bool flag2 = bossStation != null;
				if (flag2)
				{
					EnemyGroup enemyGroup = bossStation.EnemyGroup;
					bool flag3 = ((enemyGroup != null) ? enemyGroup.Id : null) == BepinexPlugin.modUniqueID;
					if (flag3)
					{
						BepinexPlugin.log.LogInfo("now playing exrumia bgm");
						AudioManager.PlayInLayer1("lvalonexrumiabgm");
						return false;
					}
				}
				return true;
			}
		}
	}
}
