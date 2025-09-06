using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;

namespace lvalonexrumia.StatusEffects
{
	public sealed class setornDef : lvalonexrumiaStatusEffectTemplate
	{
		public override StatusEffectConfig MakeConfig()
		{
			StatusEffectConfig defaultStatusEffectConfig = lvalonexrumiaStatusEffectTemplate.GetDefaultStatusEffectConfig();
			defaultStatusEffectConfig.Type = StatusEffectType.Positive;
			defaultStatusEffectConfig.RelativeEffects = new List<string> { "seatkincrease", "seincrease" };
			defaultStatusEffectConfig.HasCount = true;
			return defaultStatusEffectConfig;
		}
	}
}
