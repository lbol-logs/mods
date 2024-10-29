using System;
using System.Reflection;
using BepInEx;
using BepInEx.Bootstrap;
using BepInEx.Logging;
using HarmonyLib;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;
using UnityEngine;

namespace Utsuho_character_mod
{
	[BepInPlugin("zosit.lbol.test.utsuho", "Character Mod", "1.0.0")]
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
			Func<Sprite> func = () => ResourceLoader.LoadSprite("BossIcon.png", BepinexPlugin.directorySource, null, 1, null);
			EnemyUnitTemplate.AddBossNodeIcon("Utsuho", func, null);
			IntentionTemplate.CreateIntention<VentIntentionDef.VentIntention>();
			IntentionTemplate.CreateIntention<PullIntentionDef.PullIntention>();
		}

		private void OnDestroy()
		{
			bool flag = BepinexPlugin.harmony != null;
			if (flag)
			{
				BepinexPlugin.harmony.UnpatchSelf();
			}
			AssetBundle assetBundle = BepinexPlugin.utsuhoAB;
			if (assetBundle != null)
			{
				assetBundle.Unload(false);
			}
		}

		private static readonly Harmony harmony = PInfo.harmony;

		internal static ManualLogSource log;

		internal static TemplateSequenceTable sequenceTable = new TemplateSequenceTable(0);

		internal static IResourceSource embeddedSource = new EmbeddedSource(Assembly.GetExecutingAssembly());

		internal static DirectorySource directorySource = new DirectorySource("zosit.lbol.test.utsuho", "");

		internal static AssetBundle utsuhoAB;
	}
}
