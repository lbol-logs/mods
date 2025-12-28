using System;
using System.Collections.Generic;
using LBoL.ConfigData;

namespace ReimuUnifierMod.ReimuUnifierUlt
{
	public sealed class ReimuUnifierUltADef : ReimuUnifierUltTemplate
	{
		public override UltimateSkillConfig MakeConfig()
		{
			UltimateSkillConfig defaulUltConfig = base.GetDefaulUltConfig();
			defaulUltConfig.RelativeCards = new List<string> { "ReimuUnifierMarisaKirisameFriend" };
			return defaulUltConfig;
		}
	}
}
