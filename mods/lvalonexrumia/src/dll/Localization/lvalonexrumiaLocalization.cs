using System;
using LBoL.Core;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;

namespace lvalonexrumia.Localization
{
	public sealed class lvalonexrumiaLocalization
	{
		public static void Init()
		{
			lvalonexrumiaLocalization.CardsBatchLoc.DiscoverAndLoadLocFiles(lvalonexrumiaLocalization.Cards);
			lvalonexrumiaLocalization.ExhibitsBatchLoc.DiscoverAndLoadLocFiles(lvalonexrumiaLocalization.Exhibits);
			lvalonexrumiaLocalization.PlayerUnitBatchLoc.DiscoverAndLoadLocFiles(lvalonexrumiaLocalization.PlayerUnit);
			lvalonexrumiaLocalization.EnemiesUnitBatchLoc.DiscoverAndLoadLocFiles(lvalonexrumiaLocalization.EnemiesUnit);
			lvalonexrumiaLocalization.UnitModelBatchLoc.DiscoverAndLoadLocFiles(lvalonexrumiaLocalization.UnitModel);
			lvalonexrumiaLocalization.UltimateSkillsBatchLoc.DiscoverAndLoadLocFiles(lvalonexrumiaLocalization.UltimateSkills);
			lvalonexrumiaLocalization.StatusEffectsBatchLoc.DiscoverAndLoadLocFiles(lvalonexrumiaLocalization.StatusEffects);
		}

		public static string Cards = "Cards";

		public static string Exhibits = "Exhibits";

		public static string PlayerUnit = "PlayerUnit";

		public static string EnemiesUnit = "EnemyUnit";

		public static string UnitModel = "UnitModel";

		public static string UltimateSkills = "UltimateSkills";

		public static string StatusEffects = "StatusEffects";

		public static BatchLocalization CardsBatchLoc = new BatchLocalization(BepinexPlugin.directorySource, typeof(CardTemplate), lvalonexrumiaLocalization.Cards, Locale.En, false);

		public static BatchLocalization ExhibitsBatchLoc = new BatchLocalization(BepinexPlugin.directorySource, typeof(ExhibitTemplate), lvalonexrumiaLocalization.Exhibits, Locale.En, false);

		public static BatchLocalization PlayerUnitBatchLoc = new BatchLocalization(BepinexPlugin.directorySource, typeof(PlayerUnitTemplate), lvalonexrumiaLocalization.PlayerUnit, Locale.En, false);

		public static BatchLocalization EnemiesUnitBatchLoc = new BatchLocalization(BepinexPlugin.directorySource, typeof(EnemyUnitTemplate), lvalonexrumiaLocalization.EnemiesUnit, Locale.En, false);

		public static BatchLocalization UnitModelBatchLoc = new BatchLocalization(BepinexPlugin.directorySource, typeof(UnitModelTemplate), lvalonexrumiaLocalization.UnitModel, Locale.En, false);

		public static BatchLocalization UltimateSkillsBatchLoc = new BatchLocalization(BepinexPlugin.directorySource, typeof(UltimateSkillTemplate), lvalonexrumiaLocalization.UltimateSkills, Locale.En, false);

		public static BatchLocalization StatusEffectsBatchLoc = new BatchLocalization(BepinexPlugin.directorySource, typeof(StatusEffectTemplate), lvalonexrumiaLocalization.StatusEffects, Locale.En, false);
	}
}
