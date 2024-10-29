using System;
using System.Reflection;
using BepInEx;
using BepInEx.Bootstrap;
using BepInEx.Logging;
using HarmonyLib;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Resource;
using UnityEngine;

namespace YoumuCharacterMod
{
	[BepInPlugin("rmrfmaxx.lbol.YoumuCharacterMod", "Youmu Character Mod", "0.4.14")]
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

		private static readonly Harmony harmony = PInfo.harmony;

		internal static ManualLogSource log;

		internal static TemplateSequenceTable sequenceTable = new TemplateSequenceTable(0);

		internal static IResourceSource embeddedSource = new EmbeddedSource(Assembly.GetExecutingAssembly());

		internal static DirectorySource directorySource = new DirectorySource("rmrfmaxx.lbol.YoumuCharacterMod", "");
	}
}
