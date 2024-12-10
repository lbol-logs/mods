using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;

namespace Momiji.Source
{
	public class SampleCharacterLoadouts
	{
		public static string UltimateSkillA = "RabiesBite";

		public static string UltimateSkillB = "ExpelleesCanan";

		public static string ExhibitA = "HeavyBlade";

		public static string ExhibitB = "BatteredShield";

		public static List<string> DeckA = new List<string> { "Shoot", "Shoot", "Boundary", "Boundary", "MomijiAttackR", "MomijiAttackR", "MomijiBlockW", "MomijiBlockW", "MomijiBlockW", "GuardBreak" };

		public static List<string> DeckB = new List<string> { "Shoot", "Shoot", "Boundary", "Boundary", "MomijiAttackW", "MomijiAttackW", "MomijiBlockR", "MomijiBlockR", "EyeforanEye", "FarSight" };

		public static PlayerUnitConfig playerUnitConfig = new PlayerUnitConfig(BepinexPlugin.modUniqueID, 8, 0, new int?(0), "", "#e58c27", true, 80, new ManaGroup
		{
			White = 2,
			Blue = 0,
			Black = 0,
			Red = 2,
			Green = 0,
			Colorless = 0,
			Philosophy = 0
		}, 60, 0, SampleCharacterLoadouts.UltimateSkillA, SampleCharacterLoadouts.UltimateSkillB, SampleCharacterLoadouts.ExhibitA, SampleCharacterLoadouts.ExhibitB, SampleCharacterLoadouts.DeckA, SampleCharacterLoadouts.DeckB, 1, 2);
	}
}
