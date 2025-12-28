using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;

namespace ReimuUnifierMod
{
	public class ReimuUnifierLoadouts
	{
		// Note: this type is marked as 'beforefieldinit'.
		static ReimuUnifierLoadouts()
		{
			string modUniqueID = BepinexPlugin.modUniqueID;
			bool flag = true;
			string text = "";
			int num = 0;
			int num2 = 8;
			int? num3 = new int?(0);
			bool flag2 = true;
			ManaGroup manaGroup = new ManaGroup
			{
				White = 2,
				Blue = 0,
				Black = 0,
				Red = 2,
				Green = 0,
				Colorless = 0,
				Philosophy = 0
			};
			ReimuUnifierLoadouts.playerUnitConfig = new PlayerUnitConfig(modUniqueID, flag, text, num, num2, num3, flag2, null, ManaColor.Red, ManaColor.White, manaGroup, "#e58c27", 80, 20, 0, ReimuUnifierLoadouts.UltimateSkillA, ReimuUnifierLoadouts.UltimateSkillB, ReimuUnifierLoadouts.ExhibitA, ReimuUnifierLoadouts.ExhibitB, ReimuUnifierLoadouts.DeckA, ReimuUnifierLoadouts.DeckB, 2, 1);
		}

		public static string UltimateSkillA = "ReimuUnifierUltA";

		public static string UltimateSkillB = "ReimuUnifierUltB";

		public static string ExhibitA = "ReimuUnifierExhibitA";

		public static string ExhibitB = "ReimuUnifierExhibitB";

		public static List<string> DeckA = new List<string> { "Shoot", "Shoot", "Boundary", "Boundary", "ReimuUnifierAttackR", "ReimuUnifierAttackR", "ReimuUnifierBlockW", "ReimuUnifierBlockW", "ReimuUnifierMarisaKirisameFriend", "ReimuUnifierCoordinatedStrike" };

		public static List<string> DeckB = new List<string> { "Shoot", "Shoot", "Boundary", "Boundary", "ReimuUnifierAttackW", "ReimuUnifierAttackW", "ReimuUnifierBlockR", "ReimuUnifierBlockR", "ReimuUnifierYukariYakumoFriend", "ReimuUnifierReinforcedBoundary" };

		public static PlayerUnitConfig playerUnitConfig;
	}
}
