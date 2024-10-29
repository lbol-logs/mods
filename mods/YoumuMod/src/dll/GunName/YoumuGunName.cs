using System;
using System.Collections.Generic;
using System.Linq;
using LBoL.ConfigData;
using UnityEngine;

namespace YoumuCharacterMod.GunName
{
	public struct YoumuGunName
	{
		public static string GetGunFromId(int id)
		{
			string text = "";
			try
			{
				text = (from config in YoumuGunName.gunConfig
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

		private static IReadOnlyList<GunConfig> gunConfig = GunConfig.AllConfig();

		public static string YoumuAttackG = YoumuGunName.GetGunFromId(805);

		public static string YoumuAttackW = YoumuGunName.GetGunFromId(801);

		public static string AsuraSword = YoumuGunName.GetGunFromId(6162);

		public static string AsuraSwordBurst = YoumuGunName.GetGunFromId(851);

		public static string SwordOfBinding = YoumuGunName.GetGunFromId(25020);

		public static string PhosphoricSlash = YoumuGunName.GetGunFromId(4152);

		public static string ClosedEyeSlash = YoumuGunName.GetGunFromId(6160);

		public static string SlashOfPresent = YoumuGunName.GetGunFromId(520);

		public static string InsightfulSword = YoumuGunName.GetGunFromId(821);

		public static string GhostSlash = YoumuGunName.GetGunFromId(6190);

		public static string SlashOfKarmicWind = YoumuGunName.GetGunFromId(22020);

		public static string SlashOfKarmicWindBurst = YoumuGunName.GetGunFromId(851);

		public static string SlashOfMeditation = YoumuGunName.GetGunFromId(512);

		public static string LotusPostureSlash = YoumuGunName.GetGunFromId(851);

		public static string SatelliteSlash = YoumuGunName.GetGunFromId(7090);

		public static string CrescentMoonSlash = YoumuGunName.GetGunFromId(13190);

		public static string ReflectionSlash = YoumuGunName.GetGunFromId(6400);

		public static string SlashOfDeparture = YoumuGunName.GetGunFromId(4131);

		public static string SlashDraw = YoumuGunName.GetGunFromId(21100);

		public static string WaterfowlDance = YoumuGunName.GetGunFromId(6300);

		public static string TransmigrationSlash = YoumuGunName.GetGunFromId(6180);

		public static string PretaSword = YoumuGunName.GetGunFromId(6002);

		public static string DyingDeva = YoumuGunName.GetGunFromId(865);

		public static string Hakugyokurou = YoumuGunName.GetGunFromId(11120);

		public static string RiposteSe = YoumuGunName.GetGunFromId(4034);

		public static string SpiritMediumBindSe = YoumuGunName.GetGunFromId(863);

		public static string FlashOfTheNetherworldSe = YoumuGunName.GetGunFromId(4535);

		public static string UltimateSkillG = YoumuGunName.GetGunFromId(521);

		public static string UltimateSkillGBurst = YoumuGunName.GetGunFromId(851);

		public static string UltimateSkillW = YoumuGunName.GetGunFromId(521);
	}
}
