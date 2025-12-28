using System;
using LBoL.Core;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;

namespace ReimuUnifierMod.Localization
{
	public sealed class ReimuUnifierLocalization
	{
		public static void Init()
		{
			ReimuUnifierLocalization.CardsBatchLoc.DiscoverAndLoadLocFiles(ReimuUnifierLocalization.Cards);
			ReimuUnifierLocalization.ExhibitsBatchLoc.DiscoverAndLoadLocFiles(ReimuUnifierLocalization.Exhibits);
			ReimuUnifierLocalization.PlayerUnitBatchLoc.DiscoverAndLoadLocFiles(ReimuUnifierLocalization.PlayerUnit);
			ReimuUnifierLocalization.EnemiesUnitBatchLoc.DiscoverAndLoadLocFiles(ReimuUnifierLocalization.EnemiesUnit);
			ReimuUnifierLocalization.UnitModelBatchLoc.DiscoverAndLoadLocFiles(ReimuUnifierLocalization.UnitModel);
			ReimuUnifierLocalization.UltimateSkillsBatchLoc.DiscoverAndLoadLocFiles(ReimuUnifierLocalization.UltimateSkills);
			ReimuUnifierLocalization.StatusEffectsBatchLoc.DiscoverAndLoadLocFiles(ReimuUnifierLocalization.StatusEffects);
		}

		public static string Cards = "Cards";

		public static string Exhibits = "Exhibits";

		public static string PlayerUnit = "PlayerUnit";

		public static string EnemiesUnit = "EnemyUnit";

		public static string UnitModel = "UnitModel";

		public static string UltimateSkills = "UltimateSkills";

		public static string StatusEffects = "StatusEffects";

		public static BatchLocalization CardsBatchLoc = new BatchLocalization(BepinexPlugin.directorySource, typeof(CardTemplate), ReimuUnifierLocalization.Cards, Locale.En, false);

		public static BatchLocalization ExhibitsBatchLoc = new BatchLocalization(BepinexPlugin.directorySource, typeof(ExhibitTemplate), ReimuUnifierLocalization.Exhibits, Locale.En, false);

		public static BatchLocalization PlayerUnitBatchLoc = new BatchLocalization(BepinexPlugin.directorySource, typeof(PlayerUnitTemplate), ReimuUnifierLocalization.PlayerUnit, Locale.En, false);

		public static BatchLocalization EnemiesUnitBatchLoc = new BatchLocalization(BepinexPlugin.directorySource, typeof(EnemyUnitTemplate), ReimuUnifierLocalization.EnemiesUnit, Locale.En, false);

		public static BatchLocalization UnitModelBatchLoc = new BatchLocalization(BepinexPlugin.directorySource, typeof(UnitModelTemplate), ReimuUnifierLocalization.UnitModel, Locale.En, false);

		public static BatchLocalization UltimateSkillsBatchLoc = new BatchLocalization(BepinexPlugin.directorySource, typeof(UltimateSkillTemplate), ReimuUnifierLocalization.UltimateSkills, Locale.En, false);

		public static BatchLocalization StatusEffectsBatchLoc = new BatchLocalization(BepinexPlugin.directorySource, typeof(StatusEffectTemplate), ReimuUnifierLocalization.StatusEffects, Locale.En, false);
	}
}
