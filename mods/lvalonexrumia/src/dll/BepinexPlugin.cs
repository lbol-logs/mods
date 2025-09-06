using System;
using System.Collections.Generic;
using System.Reflection;
using BepInEx;
using BepInEx.Configuration;
using BepInEx.Logging;
using HarmonyLib;
using LBoL.Base;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;
using lvalonexrumia.Cards.Template;
using lvalonexrumia.Config;
using UnityEngine;

namespace lvalonexrumia
{
	[BepInPlugin("llbol.char.exrumia", "EX Rumia", "1.0.4")]
	[BepInDependency("neo.lbol.frameworks.entitySideloader", 1)]
	[BepInProcess("LBoL.exe")]
	public class BepinexPlugin : BaseUnityPlugin
	{
		private void Awake()
		{
			BepinexPlugin.log = base.Logger;
			BepinexPlugin.enableAct1Boss = base.Config.Bind<bool>(BepinexPlugin.enableAct1BossEntry.Section, BepinexPlugin.enableAct1BossEntry.Key, BepinexPlugin.enableAct1BossEntry.Value, BepinexPlugin.enableAct1BossEntry.Description);
			Object.DontDestroyOnLoad(base.gameObject);
			base.gameObject.hideFlags = HideFlags.HideAndDontSave;
			CardIndexGenerator.PromiseClearIndexSet();
			EntityManager.RegisterSelf();
			BepinexPlugin.harmony.PatchAll();
			Func<Sprite> func = () => ResourceLoader.LoadSprite("BossIcon.png", BepinexPlugin.directorySource, null, 1, null);
			EnemyUnitTemplate.AddBossNodeIcon("lvalonexrumia", func, null);
		}

		private void OnDestroy()
		{
			bool flag = BepinexPlugin.harmony != null;
			if (flag)
			{
				BepinexPlugin.harmony.UnpatchSelf();
			}
		}

		public static string modUniqueID = "lvalonexrumia";

		public static string playerName = "EXRumia";

		public static bool useInGameModel = false;

		public static string modelName = "Youmu";

		public static bool modelIsFlipped = true;

		public static List<ManaColor> offColors = new List<ManaColor>
		{
			ManaColor.Colorless,
			ManaColor.White,
			ManaColor.Blue,
			ManaColor.Green
		};

		public static ConfigEntry<bool> enableAct1Boss;

		public static CustomConfigEntry<bool> enableAct1BossEntry = new CustomConfigEntry<bool>(false, "Act 1 Boss", "EnableAct1Boss", "Act 1 Boss");

		private static readonly Harmony harmony = PInfo.harmony;

		internal static ManualLogSource log;

		internal static TemplateSequenceTable sequenceTable = new TemplateSequenceTable(0);

		internal static IResourceSource embeddedSource = new EmbeddedSource(Assembly.GetExecutingAssembly());

		internal static DirectorySource directorySource = new DirectorySource("llbol.char.exrumia", "");
	}
}
