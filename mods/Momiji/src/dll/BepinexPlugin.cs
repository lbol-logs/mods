using System;
using System.Collections.Generic;
using System.Reflection;
using BepInEx;
using BepInEx.Bootstrap;
using BepInEx.Logging;
using HarmonyLib;
using LBoL.Base;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Resource;
using Momiji.Source;
using UnityEngine;

namespace Momiji
{
	[BepInPlugin("worldsoul.test.momiji.mod", "Momiji Mod", "1.1.3")]
	[BepInDependency("neo.lbol.frameworks.entitySideloader", 1)]
	[BepInDependency("neo.lbol.tools.watermark", 2)]
	[BepInProcess("LBoL.exe")]
	public class BepinexPlugin : BaseUnityPlugin
	{
		private void Awake()
		{
			BepinexPlugin.log = base.Logger;
			Object.DontDestroyOnLoad(base.gameObject);
			base.gameObject.hideFlags = HideFlags.HideAndDontSave;
			CardIndexGenerator.PromiseClearIndexSet();
			EntityManager.RegisterSelf();
			BepinexPlugin.harmony.PatchAll();
			bool flag = Chainloader.PluginInfos.ContainsKey("neo.lbol.tools.watermark");
			if (flag)
			{
				WatermarkWrapper.ActivateWatermark();
			}
		}

		private void OnDestroy()
		{
			bool flag = BepinexPlugin.harmony != null;
			if (flag)
			{
				BepinexPlugin.harmony.UnpatchSelf();
			}
		}

		public static string modUniqueID = "Momiji";

		public static string playerName = "Momiji";

		public static bool useInGameModel = false;

		public static string modelName = "Youmu";

		public static bool modelIsFlipped = true;

		public static List<ManaColor> offColors = new List<ManaColor>
		{
			ManaColor.White,
			ManaColor.Red,
			ManaColor.Black,
			ManaColor.Green,
			ManaColor.Blue,
			ManaColor.Colorless
		};

		private static readonly Harmony harmony = PInfo.harmony;

		internal static ManualLogSource log;

		internal static TemplateSequenceTable sequenceTable = new TemplateSequenceTable(0);

		internal static IResourceSource embeddedSource = new EmbeddedSource(Assembly.GetExecutingAssembly());

		internal static DirectorySource directorySource = new DirectorySource("worldsoul.test.momiji.mod", "");
	}
}
