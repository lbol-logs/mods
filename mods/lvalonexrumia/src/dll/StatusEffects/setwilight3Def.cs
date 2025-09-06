using System;
using LBoL.Base;
using LBoL.ConfigData;

namespace lvalonexrumia.StatusEffects
{
	public sealed class setwilight3Def : lvalonexrumiaStatusEffectTemplate
	{
		public override StatusEffectConfig MakeConfig()
		{
			StatusEffectConfig defaultStatusEffectConfig = lvalonexrumiaStatusEffectTemplate.GetDefaultStatusEffectConfig();
			defaultStatusEffectConfig.Type = StatusEffectType.Positive;
			defaultStatusEffectConfig.HasCount = true;
			defaultStatusEffectConfig.Order = 2;
			return defaultStatusEffectConfig;
		}
	}
}
