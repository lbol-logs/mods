using System;
using System.Collections.Generic;
using LBoL.ConfigData;
using lvalonexrumia.StatusEffects;

namespace lvalonmeme.StatusEffects
{
	public sealed class sebosshealDef : lvalonexrumiaStatusEffectTemplate
	{
		public override StatusEffectConfig MakeConfig()
		{
			StatusEffectConfig defaultStatusEffectConfig = lvalonexrumiaStatusEffectTemplate.GetDefaultStatusEffectConfig();
			defaultStatusEffectConfig.RelativeEffects = new List<string> { "seincrease" };
			return defaultStatusEffectConfig;
		}
	}
}
