using System;
using System.Reflection;
using BepInEx;
using BepInEx.Bootstrap;
using BepInEx.Logging;
using HarmonyLib;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;
using Sanae_Kochiya.Cards.Template;
using UnityEngine;

namespace Sanae_Kochiya
{
	[BepInPlugin("xeno.lbol.character.Sanae_Kochiya", "Sanae_Kochiya", "0.5.4")]
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
			Func<Sprite> func = () => ResourceLoader.LoadSprite("BossIconSanae.png", BepinexPlugin.directorySource, null, 1, null);
			EnemyUnitTemplate.AddBossNodeIcon("Sanae_Kochiya", func, null);
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

		public static string modUniqueID = "Sanae_Kochiya";

		public static string playerName = "Sanae";

		public static bool useInGameModel = true;

		public static string model_name = "Sanae";

		public static bool model_is_flipped = false;

		private static readonly Harmony harmony = PInfo.harmony;

		internal static ManualLogSource log;

		internal static TemplateSequenceTable sequenceTable = new TemplateSequenceTable(0);

		internal static IResourceSource embeddedSource = new EmbeddedSource(Assembly.GetExecutingAssembly());

		internal static DirectorySource directorySource = new DirectorySource("xeno.lbol.character.Sanae_Kochiya", "");
	}
}
