using System;
using System.Collections.Generic;
using System.Linq;
using LBoL.ConfigData;
using UnityEngine;

namespace PatchouliCharacterMod.GunName
{
	public struct PatchouliGunName
	{
		public static string GetGunFromId(int id)
		{
			string text = "";
			try
			{
				text = (from config in PatchouliGunName.gunConfig
					where config.Id == id
					select config.Name).ToList<string>()[0];
			}
			catch
			{
				Debug.Log("id: " + id.ToString() + " doesn't exist. Check whether the ID is correct.");
				text = "Instant";
			}
			return text;
		}

		public static string PatchouliAttackU { get; internal set; } = PatchouliGunName.GetGunFromId(802);

		public static string PatchouliAttackB { get; internal set; } = PatchouliGunName.GetGunFromId(804);

		public static string PatchouliCondensedBubble { get; internal set; } = PatchouliGunName.GetGunFromId(21071);

		public static string PatchouliManaDrain { get; internal set; } = PatchouliGunName.GetGunFromId(4700);

		public static string PatchouliDiamondRing { get; internal set; } = PatchouliGunName.GetGunFromId(824);

		public static string PatchouliSunshineReflector { get; internal set; } = PatchouliGunName.GetGunFromId(6064);

		public static string PatchouliAgniShine { get; internal set; } = PatchouliGunName.GetGunFromId(7100);

		public static string PatchouliDoyouSpear { get; internal set; } = PatchouliGunName.GetGunFromId(25010);

		public static string PatchouliLavaCromlech { get; internal set; } = PatchouliGunName.GetGunFromId(6061);

		public static string PatchouliForestBlaze { get; internal set; } = PatchouliGunName.GetGunFromId(6062);

		public static string PatchouliObservatory { get; internal set; } = PatchouliGunName.GetGunFromId(12160);

		public static string PatchouliEveryAngleShot { get; internal set; } = PatchouliGunName.GetGunFromId(7160);

		public static string PatchouliKrakenWave { get; internal set; } = PatchouliGunName.GetGunFromId(4157);

		public static string PatchouliNoachianDeluge { get; internal set; } = PatchouliGunName.GetGunFromId(25054);

		public static string PatchouliSpellMastery { get; internal set; } = PatchouliGunName.GetGunFromId(4711);

		public static string PatchouliMetalFatigue { get; internal set; } = PatchouliGunName.GetGunFromId(6003);

		public static string PatchouliWaterElf { get; internal set; } = PatchouliGunName.GetGunFromId(25141);

		public static string PatchouliPhlogisticRain { get; internal set; } = PatchouliGunName.GetGunFromId(25053);

		public static string PatchouliGreenStorm { get; internal set; } = PatchouliGunName.GetGunFromId(4152);

		public static string PatchouliRingOfAgni { get; internal set; } = PatchouliGunName.GetGunFromId(4150);

		public static string PatchouliRoyalFlare { get; internal set; } = PatchouliGunName.GetGunFromId(23071);

		public static string PatchouliSaintElmoPillar { get; internal set; } = PatchouliGunName.GetGunFromId(60003);

		public static string PatchouliJellyfishPrincess { get; internal set; } = PatchouliGunName.GetGunFromId(25183);

		public static string PatchouliSpringWind { get; internal set; } = PatchouliGunName.GetGunFromId(6180);

		public static string PatchouliSpellCreation { get; internal set; } = PatchouliGunName.GetGunFromId(21520);

		public static string PatchouliAutumnBlade { get; internal set; } = PatchouliGunName.GetGunFromId(21511);

		public static string Voile { get; internal set; } = PatchouliGunName.GetGunFromId(401);

		public static string GrandIncantation { get; internal set; } = PatchouliGunName.GetGunFromId(4712);

		public static string FireSign { get; internal set; } = PatchouliGunName.GetGunFromId(862);

		public static string WoodSign { get; internal set; } = PatchouliGunName.GetGunFromId(25185);

		public static string SunSign { get; internal set; } = PatchouliGunName.GetGunFromId(23011);

		public static string UltimateSkillU { get; internal set; } = PatchouliGunName.GetGunFromId(4158);

		public static string UltimateSkillB { get; internal set; } = PatchouliGunName.GetGunFromId(25191);

		private static IReadOnlyList<GunConfig> gunConfig = GunConfig.AllConfig();
	}
}
