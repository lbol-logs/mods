using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;

namespace lvalonexrumia
{
	public class lvalonexrumiaLoadouts
	{
		// Note: this type is marked as 'beforefieldinit'.
		static lvalonexrumiaLoadouts()
		{
			string modUniqueID = BepinexPlugin.modUniqueID;
			bool flag = false;
			string text = "";
			int num = 0;
			int num2 = 1000;
			int? num3 = new int?(0);
			bool flag2 = true;
			ManaGroup manaGroup = new ManaGroup
			{
				Black = 2,
				Red = 2
			};
			lvalonexrumiaLoadouts.playerUnitConfig = new PlayerUnitConfig(modUniqueID, flag, text, num, num2, num3, flag2, null, ManaColor.Black, ManaColor.Red, manaGroup, "#FF0808", 100, 50, 0, lvalonexrumiaLoadouts.UltimateSkillA, lvalonexrumiaLoadouts.UltimateSkillB, lvalonexrumiaLoadouts.ExhibitA, lvalonexrumiaLoadouts.ExhibitB, lvalonexrumiaLoadouts.DeckA, lvalonexrumiaLoadouts.DeckB, 3, 3);
		}

		public static string UltimateSkillA = "exulta";

		public static string UltimateSkillB = "exultb";

		public static string ExhibitA = "exexa";

		public static string ExhibitB = "exexb";

		public static List<string> DeckA = new List<string> { "Shoot", "Shoot", "Boundary", "Boundary", "cardexaa", "cardexaa", "cardexab", "cardexab", "cardbite", "cardbloodwork" };

		public static List<string> DeckB = new List<string> { "Shoot", "Shoot", "Boundary", "Boundary", "cardexba", "cardexba", "cardexbb", "cardexbb", "cardexbb", "cardblooduse" };

		public static PlayerUnitConfig playerUnitConfig;
	}
}
