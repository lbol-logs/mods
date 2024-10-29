using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using LBoLEntitySideloader.Entities;

namespace Sanae_Kochiya.Source.Config
{
	public sealed class SampleCharacterDefaultConfig
	{
		public static string GetDefaultID(EntityDefinition entity)
		{
			string name = entity.GetType().Name;
			return name.Remove(name.Length - 3);
		}

		public static CardConfig GetCardDefaultConfig()
		{
			return new CardConfig(0, "", 10, true, new string[0][], "", "", 0, false, true, true, false, true, Rarity.Common, CardType.Unknown, null, new List<ManaColor>(), false, default(ManaGroup), null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, Keyword.None, Keyword.None, false, Keyword.None, Keyword.None, new List<string>(), new List<string>(), new List<string>(), new List<string>(), SampleCharacterDefaultConfig.OwnerName, "", "", false, null, new List<string>());
		}

		public static ExhibitConfig GetDefaultExhibitConfig()
		{
			return new ExhibitConfig(0, "", 10, false, false, false, false, AppearanceType.Nowhere, SampleCharacterDefaultConfig.OwnerName, ExhibitLosableType.DebutLosable, Rarity.Shining, null, null, null, new ManaGroup?(default(ManaGroup)), null, new ManaColor?(ManaColor.White), 1, false, null, Keyword.None, new List<string>(), new List<string>());
		}

		public static StatusEffectConfig GetDefaultStatusEffectConfig()
		{
			return new StatusEffectConfig(0, "", 10, StatusEffectType.Positive, false, true, null, true, new StackType?(StackType.Add), false, new StackType?(StackType.Add), DurationDecreaseTiming.Custom, false, new StackType?(StackType.Keep), new StackType?(StackType.Keep), false, Keyword.None, new List<string>(), "Default", "Default", "Default");
		}

		public static UltimateSkillConfig GetDefaultUltConfig()
		{
			return new UltimateSkillConfig("", 10, 100, 100, 2, UsRepeatableType.OncePerTurn, 1, 0, 0, Keyword.Accuracy, new List<string>(), new List<string>());
		}

		private static readonly string OwnerName = BepinexPlugin.modUniqueID;
	}
}
