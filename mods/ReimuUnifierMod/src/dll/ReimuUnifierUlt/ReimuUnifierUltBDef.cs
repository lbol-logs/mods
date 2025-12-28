using System;
using System.Collections.Generic;
using LBoL.ConfigData;

namespace ReimuUnifierMod.ReimuUnifierUlt
{
	public sealed class ReimuUnifierUltBDef : ReimuUnifierUltTemplate
	{
		public override UltimateSkillConfig MakeConfig()
		{
			UltimateSkillConfig defaulUltConfig = base.GetDefaulUltConfig();
			defaulUltConfig.RelativeEffects = new List<string> { "Invincible" };
			return defaulUltConfig;
		}
	}
}
