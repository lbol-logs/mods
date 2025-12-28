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
using ReimuUnifierMod.Cards.Template;
using UnityEngine;

namespace ReimuUnifierMod
{
	[BepInPlugin("Saevin.ReimuUnifierMod", "ReimuUnifier", "1.1.3")]
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
			Func<Sprite> <>9__11_;
			if ((<>9__11_ = BepinexPlugin.<>c.<>9__11_0) == null)
			{
				BepinexPlugin.<>c.<>9__11_0 = () => ResourceLoader.LoadSprite("BossIcon.png", BepinexPlugin.directorySource, null, 1, null);
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

		public static string modUniqueID = "ReimuUnifierMod";

		public static string playerName = "ReimuAlt";

		public static bool useInGameModel = true;

		public static string modelName = "Reimu";

		public static bool modelIsFlipped = false;

		public static List<ManaColor> offColors = new List<ManaColor>
		{
			ManaColor.Blue,
			ManaColor.Green,
			ManaColor.Black,
			ManaColor.Colorless
		};

		private static readonly Harmony harmony = PInfo.harmony;

		internal static ManualLogSource log;

		internal static TemplateSequenceTable sequenceTable = new TemplateSequenceTable(0);

		internal static IResourceSource embeddedSource = new EmbeddedSource(Assembly.GetExecutingAssembly());

		internal static DirectorySource directorySource = new DirectorySource("Saevin.ReimuUnifierMod", "");
	}
}
