using System;
using System.Collections.Generic;
using LBoL.ConfigData;

namespace lvalonexrumia.lvalonexrumiaUlt
{
	public sealed class exultbDef : lvalonexrumiaUltTemplate
	{
		public override UltimateSkillConfig MakeConfig()
		{
			UltimateSkillConfig defaulUltConfig = base.GetDefaulUltConfig();
			defaulUltConfig.Damage = 10;
			defaulUltConfig.Value1 = 1;
			defaulUltConfig.Value2 = 2;
			defaulUltConfig.RelativeEffects = new List<string> { "sebleed" };
			return defaulUltConfig;
		}
	}
}
