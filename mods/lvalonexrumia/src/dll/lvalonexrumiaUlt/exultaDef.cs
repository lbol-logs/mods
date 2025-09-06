using System;
using System.Collections.Generic;
using LBoL.ConfigData;

namespace lvalonexrumia.lvalonexrumiaUlt
{
	public sealed class exultaDef : lvalonexrumiaUltTemplate
	{
		public override UltimateSkillConfig MakeConfig()
		{
			UltimateSkillConfig defaulUltConfig = base.GetDefaulUltConfig();
			defaulUltConfig.Damage = 10;
			defaulUltConfig.Value1 = 1;
			defaulUltConfig.Value2 = 3;
			defaulUltConfig.RelativeEffects = new List<string> { "sebloodmark" };
			return defaulUltConfig;
		}
	}
}
