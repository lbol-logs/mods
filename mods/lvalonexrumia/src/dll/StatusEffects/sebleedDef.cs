using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;

namespace lvalonexrumia.StatusEffects
{
	public sealed class sebleedDef : lvalonexrumiaStatusEffectTemplate
	{
		public override StatusEffectConfig MakeConfig()
		{
			StatusEffectConfig defaultStatusEffectConfig = lvalonexrumiaStatusEffectTemplate.GetDefaultStatusEffectConfig();
			defaultStatusEffectConfig.Type = StatusEffectType.Negative;
			defaultStatusEffectConfig.HasCount = true;
			defaultStatusEffectConfig.RelativeEffects = new List<string> { "sedecrease" };
			return defaultStatusEffectConfig;
		}
	}
}
