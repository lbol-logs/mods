using System;
using LBoL.Base;
using LBoL.ConfigData;

namespace Sanae_Kochiya.SampleCharacterUlt
{
	public sealed class SanaeUltUDef : SampleCharacterUltTemplate
	{
		public override UltimateSkillConfig MakeConfig()
		{
			UltimateSkillConfig defaulUltConfig = base.GetDefaulUltConfig();
			defaulUltConfig.PowerCost = 60;
			defaulUltConfig.PowerPerLevel = 120;
			defaulUltConfig.MaxPowerLevel = 2;
			defaulUltConfig.RepeatableType = UsRepeatableType.FreeToUse;
			defaulUltConfig.Damage = 20;
			defaulUltConfig.Value1 = 2;
			return defaulUltConfig;
		}
	}
}
