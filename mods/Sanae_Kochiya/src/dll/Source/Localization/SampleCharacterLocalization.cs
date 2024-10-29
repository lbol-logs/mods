using System;
using LBoL.Core;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;

namespace Sanae_Kochiya.Source.Localization
{
	public sealed class SampleCharacterLocalization
	{
		public static void Init()
		{
			SampleCharacterLocalization.CardsBatchLoc.DiscoverAndLoadLocFiles(SampleCharacterLocalization.Cards);
			SampleCharacterLocalization.ExhibitsBatchLoc.DiscoverAndLoadLocFiles(SampleCharacterLocalization.Exhibits);
			SampleCharacterLocalization.EnemyUnitBatchLoc.DiscoverAndLoadLocFiles(SampleCharacterLocalization.EnemyUnit);
			SampleCharacterLocalization.PlayerUnitBatchLoc.DiscoverAndLoadLocFiles(SampleCharacterLocalization.PlayerUnit);
			SampleCharacterLocalization.UnitModelBatchLoc.DiscoverAndLoadLocFiles(SampleCharacterLocalization.UnitModel);
			SampleCharacterLocalization.UltimateSkillsBatchLoc.DiscoverAndLoadLocFiles(SampleCharacterLocalization.UltimateSkills);
			SampleCharacterLocalization.StatusEffectsBatchLoc.DiscoverAndLoadLocFiles(SampleCharacterLocalization.StatusEffects);
		}

		public static string Cards = "Cards";

		public static string Exhibits = "Exhibits";

		public static string EnemyUnit = "EnemyUnit";

		public static string PlayerUnit = "PlayerUnit";

		public static string UnitModel = "UnitModel";

		public static string UltimateSkills = "UltimateSkills";

		public static string StatusEffects = "StatusEffects";

		public static BatchLocalization CardsBatchLoc = new BatchLocalization(BepinexPlugin.directorySource, typeof(CardTemplate), SampleCharacterLocalization.Cards, Locale.En, false);

		public static BatchLocalization ExhibitsBatchLoc = new BatchLocalization(BepinexPlugin.directorySource, typeof(ExhibitTemplate), SampleCharacterLocalization.Exhibits, Locale.En, false);

		public static BatchLocalization EnemyUnitBatchLoc = new BatchLocalization(BepinexPlugin.directorySource, typeof(EnemyUnitTemplate), SampleCharacterLocalization.EnemyUnit, Locale.En, false);

		public static BatchLocalization PlayerUnitBatchLoc = new BatchLocalization(BepinexPlugin.directorySource, typeof(PlayerUnitTemplate), SampleCharacterLocalization.PlayerUnit, Locale.En, false);

		public static BatchLocalization UnitModelBatchLoc = new BatchLocalization(BepinexPlugin.directorySource, typeof(UnitModelTemplate), SampleCharacterLocalization.UnitModel, Locale.En, false);

		public static BatchLocalization UltimateSkillsBatchLoc = new BatchLocalization(BepinexPlugin.directorySource, typeof(UltimateSkillTemplate), SampleCharacterLocalization.UltimateSkills, Locale.En, false);

		public static BatchLocalization StatusEffectsBatchLoc = new BatchLocalization(BepinexPlugin.directorySource, typeof(StatusEffectTemplate), SampleCharacterLocalization.StatusEffects, Locale.En, false);
	}
}
