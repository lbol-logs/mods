using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;

namespace Sanae_Kochiya.SampleCharacterUlt
{
	public sealed class SanaeUltWDef : SampleCharacterUltTemplate
	{
		public override UltimateSkillConfig MakeConfig()
		{
			UltimateSkillConfig defaulUltConfig = base.GetDefaulUltConfig();
			defaulUltConfig.PowerCost = 50;
			defaulUltConfig.PowerPerLevel = 100;
			defaulUltConfig.MaxPowerLevel = 2;
			defaulUltConfig.RepeatableType = UsRepeatableType.FreeToUse;
			defaulUltConfig.Damage = 12;
			defaulUltConfig.Value1 = 1;
			defaulUltConfig.RelativeEffects = new List<string> { "Amulet", "AmuletForCard" };
			return defaulUltConfig;
		}
	}
}
