using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;

namespace Sanae_Kochiya
{
	public class SampleCharacterLoadouts
	{
		public static string UltimateSkillA = "SanaeUltW";

		public static string UltimateSkillB = "SanaeUltU";

		public static string ExhibitA = "SanaeExhibitW";

		public static string ExhibitB = "SanaeExhibitU";

		public static List<string> DeckA = new List<string> { "Shoot", "Shoot", "Boundary", "Boundary", "SanaeAttackW", "SanaeAttackW", "SanaeBlockG", "SanaeBlockG", "SanaeBlockG", "SanaeStarterW" };

		public static List<string> DeckB = new List<string> { "Shoot", "Shoot", "Boundary", "Boundary", "SanaeAttackU", "SanaeAttackU", "SanaeBlockG", "SanaeBlockG", "SanaeBlockG", "SanaeStarterU" };

		public static PlayerUnitConfig playerUnitConfig = new PlayerUnitConfig(BepinexPlugin.modUniqueID, 8, 0, new int?(0), "", "#28e25a", true, 80, new ManaGroup
		{
			White = 1,
			Blue = 1,
			Black = 0,
			Red = 0,
			Green = 2,
			Colorless = 0,
			Philosophy = 0
		}, 60, 0, SampleCharacterLoadouts.UltimateSkillA, SampleCharacterLoadouts.UltimateSkillB, SampleCharacterLoadouts.ExhibitA, SampleCharacterLoadouts.ExhibitB, SampleCharacterLoadouts.DeckA, SampleCharacterLoadouts.DeckB, 3, 2);
	}
}
