using System;
using LBoL.Core;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;

namespace PatchouliCharacterMod.Localization
{
	public sealed class PatchouliLocalization
	{
		public static string Cards = "Cards";

		public static string Exhibits = "Exhibits";

		public static string PlayerUnit = "PlayerUnit";

		public static string UnitModel = "UnitModel";

		public static string UltimateSkills = "UltimateSkills";

		public static string StatusEffects = "StatusEffects";

		public static BatchLocalization CardsBatchLoc = new BatchLocalization(BepinexPlugin.directorySource, typeof(CardTemplate), PatchouliLocalization.Cards, Locale.En, false);

		public static BatchLocalization ExhibitsBatchLoc = new BatchLocalization(BepinexPlugin.directorySource, typeof(ExhibitTemplate), PatchouliLocalization.Exhibits, Locale.En, false);

		public static BatchLocalization PlayerUnitBatchLoc = new BatchLocalization(BepinexPlugin.directorySource, typeof(PlayerUnitTemplate), PatchouliLocalization.PlayerUnit, Locale.En, false);

		public static BatchLocalization UnitModelBatchLoc = new BatchLocalization(BepinexPlugin.directorySource, typeof(UnitModelTemplate), PatchouliLocalization.UnitModel, Locale.En, false);

		public static BatchLocalization UltimateSkillsBatchLoc = new BatchLocalization(BepinexPlugin.directorySource, typeof(UltimateSkillTemplate), PatchouliLocalization.UltimateSkills, Locale.En, false);

		public static BatchLocalization StatusEffectsBatchLoc = new BatchLocalization(BepinexPlugin.directorySource, typeof(StatusEffectTemplate), PatchouliLocalization.StatusEffects, Locale.En, false);
	}
}
